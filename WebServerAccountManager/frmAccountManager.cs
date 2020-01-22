using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServerAccountManager
{
    public partial class frmAccountManager : Form
    {
        GroupViewer gv;
        private List<Webserver> webservers = new List<Webserver>();

        private List<Person> students = new List<Person>();
        private List<string> groups = new List<string>();

        public frmAccountManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webservers.Add(new Webserver(ENV.domain1, ENV.plan1, ENV.user1, ENV.token1));
            webservers.Add(new Webserver(ENV.domain2, ENV.plan2, ENV.user2, ENV.token2));

            bsWebservers.DataSource = webservers;
            cmbWebservers.DisplayMember = "domain";

            // List of students from magister
            try
            {
                using (var reader = new StreamReader("Leerlingen.csv", Encoding.GetEncoding("ISO-8859-1")))
                {
                    reader.ReadLine(); // Skip the header line
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        line = line.Substring(1, line.Length - 1);
                        var values = Regex.Split(line, ",");

                        students.Add(new Person(values[2], values[4], values[1], values[6]));
                    }

                    students = students.OrderBy(s => s.lastname).ToList();
                }
            }
            catch (IOException)
            {
                ShowMessage(string.Format("Het bestand \"Leerlingen.csv\" kan niet worden gelezen.{0}" +
                                          "Controleer de volgende punten:{0}{0}" +
                                          "- Staat het bestand in dezelfde map is dit programma?{0}" +
                                          "- Heeft het bestand de juist naam? (studenten.csv){0}" +
                                          "- Wordt het bestand niet door een ander programma gebruikt?",
                    Environment.NewLine));
                Application.Exit();
            }
            catch (IndexOutOfRangeException)
            {
                ShowMessage(string.Format("Het bestand \"Leerlingen.csv\" kan niet worden verwerkt.{0}" +
                                          "Is de bestandsindeling van de magister CSV export veranderd?",
                    Environment.NewLine));
                Application.Exit();
            }

            groups = students.OrderBy(p => p.group).Select(p => p.group).Distinct().ToList();
            cmbGroups.DataSource = groups;

            showGroupDetailForm();
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Informatie bericht", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showGroupDetailForm()
        {
            // Check if a group is selected to show students
            string group = (string)cmbGroups.SelectedItem;
            if (string.IsNullOrEmpty(group))
            {
                ShowMessage("Selecteer een klas.");
                return;
            }
            // Get all the students in the selected group
            List<Person> studentsInGroup = students.FindAll(s => s.group == group);
            gv = new GroupViewer(studentsInGroup);
            gv.Show();
            gv.Top = Top;
            gv.Left = Left + Width;
            gv.Height = Height;
        }

        private void tcTabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gv != null)
                gv.Visible = !gv.Visible;

            if (webservers.All(ws => ws.accounts.All(a => a.delete == false)))
                markSafeUnsafe();
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a group is selected to show students
            string group = (string)cmbGroups.SelectedItem;
            if (string.IsNullOrEmpty(group))
            {
                ShowMessage("Selecteer een klas.");
                return;
            }
            // Pass a new group to the groupViewer form to display
            List<Person> studentsInGroup = students.FindAll(s => s.group == group);
            if (gv != null)
                gv.changeGroup(studentsInGroup);
        }

        private async void btnCreateAccounts_Click(object sender, EventArgs e)
        {
            // Check if a group is selected to create accounts for
            string group = (string)cmbGroups.SelectedItem;
            if (string.IsNullOrEmpty(group))
            {
                ShowMessage("Selecteer een klas.");
                return;
            }

            // Get the webserver on which the accounts should be created
            Webserver ws = (Webserver)cmbWebservers.SelectedItem;
            if (!webservers.Contains(ws))
            {
                ShowMessage("Selecteer een webserver");
                return;
            }

            // Confirm the button was not clicked on accident.
            var confirm = MessageBox.Show(
                string.Format(
                    "Bij bevestiging worden direct accounts voor {0} aangemaakt op het domein \"{1}\".{2}{2}Weet je zeker dat je dit wilt?",
                    group, ws.domain, Environment.NewLine),
                "Bevestig aanmaken accounts", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Disable the button to prevent multiple executions
            btnCreateAccounts.Enabled = false;
            btnCreateAccounts.Text = "Working...";

            List<Person> studentsInGroup = students.FindAll(s => s.group == group);
            var result = await ws.createAccounts(studentsInGroup);

            // Split the result in successful and failed account creations
            List<Person> createdAccounts = result.Item1;
            List<Person> failedAccounts = result.Item2;

            // Null will be returned if there is not enough space
            if (createdAccounts == null)
            {
                ShowMessage("Er is niet genoeg ruimte beschikbaar op de server");
                return;
            }

            // Show the accounts that were successfully created
            dgvSuccessAccounts.DataSource = createdAccounts;
            gbSuccessAccounts.Text = string.Format("Succesvol aangemaakte accounts ({0})", createdAccounts.Count);

            // Show the accounts that were unsuccessfully created
            dgvFailedAccounts.DataSource = failedAccounts;
            gbFailedAccounts.Text = string.Format("Onsuccesvol aangemaakte accounts ({0})", failedAccounts.Count);

            // Re-enable the button
            btnCreateAccounts.Enabled = true;
            btnCreateAccounts.Text = "START";
        }

        private void cmbListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bind a different list depending on what list the user selected
            var index = cmbListType.SelectedIndex;
            if (index == 0)
            {
                // Get all accounts from the list of accounts from the list of webservers, where the account is marked to be deleted and safely so
                var safeDelete = webservers.SelectMany(ws => ws.accounts, (ws, p) => p).Where(p => p.delete && p.safeDelete).OrderBy(p => p.firstname).ThenBy(p => p.lastname).ToList();

                // Exclude teacher accounts who's firstname is only character long
                if (chkExcludeTeachers.Checked)
                    safeDelete = safeDelete.Where(p => p.firstname.Length != 1).ToList();

                dgvDeleteAccounts.DataSource = safeDelete;
                gbDeleteAccounts.Text = string.Format("Accounts die verwijderd moeten worden ({0})", safeDelete.Count);
            }
            else if (index == 1)
            {
                // Get all accounts from the list of accounts from the list of webservers, where the account is marked to be deleted but not yet safely so
                var manualCheck = webservers.SelectMany(ws => ws.accounts, (ws, p) => p).Where(p => p.delete && !p.safeDelete).OrderBy(p => p.firstname).ThenBy(p => p.lastname).ToList();

                // Exclude teacher accounts who's firstname is only character long
                if (chkExcludeTeachers.Checked)
                    manualCheck = manualCheck.Where(p => p.firstname.Length != 1).ToList();

                dgvDeleteAccounts.DataSource = manualCheck;
                gbDeleteAccounts.Text = string.Format("Accounts die handmatig gecontrolleerd moeten worden ({0})", manualCheck.Count);
            }
            else
                ShowMessage("Selecteer een lijst om weer te geven.");
        }


        private void chkExcludeTeachers_CheckedChanged(object sender, EventArgs e)
        {
            cmbListType_SelectedIndexChanged(sender, e);
        }

        private void markSafeUnsafe()
        {
            foreach (var ws in webservers)
            {
                foreach (var p in ws.accounts)
                {
                    // Students who's name and email match are presumed to still be enrolled, and thus need their account.
                    if (students.Any(s => s.firstname == p.firstname && s.lastname == p.lastname && s.email == p.email))
                    {
                        p.delete = false;
                        p.safeDelete = false;
                    }
                    // Usually true if more students with same firstname or lastname, used to avoid typo or special characters mixup
                    else if (students.Any(s => s.firstname == p.firstname && s.lastname != p.lastname) || students.Any(s => s.firstname != p.firstname && s.lastname == p.lastname))
                    {
                        p.delete = true;
                        p.safeDelete = false;
                    }
                    // All remaining accounts are safe to be deleted
                    else
                    {
                        p.delete = true;
                        p.safeDelete = true;
                    }
                }
            }
        }

        private void dgvDeleteAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var dgv = (DataGridView)sender;
                int currentMouseOverRow = dgv.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dgv.Rows[currentMouseOverRow].Selected = true;

                    ContextMenuStrip m = new ContextMenuStrip();
                    m.Items.Add("Mark safe").Name = "safe";
                    m.Items.Add("Mark unsafe").Name = "unsafe";
                    m.Items.Add("Mark keep").Name = "keep";
                    m.ItemClicked += (s, cmi) =>
                    {
                        var p = dgv.Rows[currentMouseOverRow].DataBoundItem as Person;
                        if (p != null)
                        {
                            switch (cmi.ClickedItem.Name)
                            {
                                case "safe":
                                    p.safeDelete = true;
                                    break;
                                case "unsafe":
                                    p.safeDelete = false;
                                    break;
                                case "keep":
                                    p.delete = false;
                                    p.safeDelete = false;
                                    break;
                            }
                        }
                        cmbListType_SelectedIndexChanged(sender, e);

                    };
                    m.Show(dgv, new Point(e.X, e.Y));
                }
            }
        }

        private async void btnDeleteAccounts_Click(object sender, EventArgs e)
        {
            // Confirm the button was not clicked on accident.
            var confirm = MessageBox.Show(
                string.Format(
                    "Bij bevestiging worden direct alle accounts verwijderd die gemarkeerd staan als veilig.{0}" +
                    "Docenten accounts worden hierdoor niet verwijderd, ongeacht wat ze gemarkeerd staan{0}{0}" +
                    "Accounts worden verwijderd voor alle gekoppelde webservers{0}" +
                    "Controlleer bij twijfel nogmaals de lijst met veilig te verwijderen accounts.{0}{0}" +
                    "Weet je zeker dat je de accounts wilt verwijderen?",
                    Environment.NewLine),
                "Bevestig aanmaken accounts", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            foreach (var ws in webservers)
            {
                var response = await ws.deleteAccounts(chkExcludeTeachers.Checked);
                DeletedAccountsViewer dav = new DeletedAccountsViewer(ws, response.Item1, response.Item2);
                dav.Show();
            }
        }
    }
}