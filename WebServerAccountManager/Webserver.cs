using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace WebServerAccountManager
{
    public class Webserver
    {
        public List<Person> accounts = new List<Person>();
        private HttpClient client = new HttpClient();

        public string domain { get; set; }
        private string plan;
        private string base_url;
        private string api_version;

        public Webserver(string domain, string plan, string user, string token)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("whm", String.Format("{0}:{1}", user, token));

            this.domain = domain;
            this.plan = plan;
            this.base_url = string.Format("https://{0}:2087/json-api/", domain);
            this.api_version = "?api.version=1";

            getAccounts();
        }

        // Returns a list of created accounts
        public async Task<(List<Person>, List<Person>)> createAccounts(List<Person> students)
        {
            List<Person> createdAccounts = new List<Person>();
            List<Person> failedAccounts = new List<Person>();

            if (students.Count < await getSpacesLeft())
            {
                foreach (var student in students)
                {
                    // Check if the student already has an account
                    if (accounts.Any(a => a.firstname == student.firstname && a.lastname == student.lastname))
                        continue;

                    // Check if the generated usernames already exists
                    if (accounts.Any(a => a.username == student.username))
                        student.username += "1";

                    student.domain = String.Format("{0}.{1}", student.username, domain);

                    string url = baseUrl("createacct");
                    url += "&username=" + student.username;
                    url += "&domain=" + student.domain;
                    url += "&plan=" + plan;
                    url += "&password=" + generatePassword(10);
                    url += "&contactemail=" + student.email;

                    HttpResponseMessage response = await request(url);
                    if (response.IsSuccessStatusCode)
                    {
                        accounts.Add(student);
                        createdAccounts.Add(student);
                    }
                    else
                    {
                        failedAccounts.Add(student);
                    }
                }

                return (createdAccounts, failedAccounts);
            }
            else
            {
                return (null, null);
            }
        }

        public async Task<(List<Person>, List<Person>)> deleteAccounts(bool excludeTeachers)
        {
            List<Person> deletedAccounts = new List<Person>();
            List<Person> failedAccounts = new List<Person>();

            var deleteList = accounts.Where(a => a.delete && a.safeDelete).ToList();
            deleteList = deleteList.Where(a => a.firstname.Length != 1).ToList();

            foreach (var a in deleteList)
            {
                string url = baseUrl("removeacct");
                url += "&username=" + a.username;

                HttpResponseMessage response = await request(url);
                if (response.IsSuccessStatusCode)
                {
                    deletedAccounts.Add(a);
                }
                else
                {
                    failedAccounts.Add(a);
                }
            }

            return (deletedAccounts, failedAccounts);
        }

        private string generatePassword(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        private string baseUrl(string function)
        {
            return String.Format("{0}{1}{2}", base_url, function, api_version);
        }

        // Generates API url based on passed function.
        private async Task<HttpResponseMessage> request(string url)
        {
            try
            {
                return await client.GetAsync(url);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(String.Format("Applicatie kan geen verbinding maken met het internet.{0}" +
                    "Controlleer uw netwerk instellingen.", Environment.NewLine), "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return null;
        }

        // Get all accounts on the webserver.
        private async void getAccounts()
        {
            HttpResponseMessage response = await request(baseUrl("listaccts"));
            if (response.IsSuccessStatusCode)
            {
                using (var sr = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    dynamic data = JsonConvert.DeserializeObject(sr.ReadToEnd());
                    foreach (dynamic user in data.data.acct)
                    {
                        string domain = user.domain;
                        string username = user.user;
                        string email = user.email;

                        accounts.Add(new Person(domain, username, email));
                    }
                }
            }
            else
            {
                MessageBox.Show("Fout bij het ophalen van de accounts van " + domain, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            accounts = accounts.OrderBy(a => a.lastname).ToList();
        }

        // Calculates the number of accounts that can still be created.
        private async Task<int> getSpacesLeft()
        {
            HttpResponseMessage response = await request(baseUrl("acctcounts"));
            if (response.IsSuccessStatusCode)
            {
                using (var sr = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    dynamic data = JsonConvert.DeserializeObject(sr.ReadToEnd());
                    int accounts = data.data.reseller.active + data.data.reseller.suspended;
                    return data.data.reseller.limit - accounts;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
