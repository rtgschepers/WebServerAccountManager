using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebServerAccountManager
{
    public class Person
    {
        [System.ComponentModel.Browsable(false)]
        public string firstname { get; }
        [System.ComponentModel.Browsable(false)]
        public string lastname { get; }
        [System.ComponentModel.Browsable(false)]
        public string group { get;}

        public string name
        {
            get
            {
                return firstname + " " + lastname;
            }
        }
        public string domain { get; set; }
        public string username { get; set; }
        public string email { get; }

        [System.ComponentModel.Browsable(false)]
        public bool delete { get; set; }
        [System.ComponentModel.Browsable(false)]
        public bool safeDelete { get; set; }

        public Person(string firstname, string lastname, string group, string email)
        {
            this.firstname = replaceSpecialChar(firstname.ToLower());
            this.lastname = replaceSpecialChar(lastname.ToLower());
            this.group = group.ToUpper();

            this.username = String.Format("{0}{1}", this.firstname[0], this.lastname);
            this.email = email;

            this.delete = false;
            this.safeDelete = false;
        }

        public Person(string domain, string username, string email)
        {
            this.domain = domain;
            this.username = username;

            var parts = email.Split('@');
            var names = parts[0].Split('.');

            this.firstname = replaceSpecialChar(names[0]);
            this.lastname = replaceSpecialChar(names[1]);
            this.email = email;

            this.delete = false;
            this.safeDelete = false;
        }

        private string replaceSpecialChar(string input)
        {
            // Remove special characters and replace with their normal version
            var temp = input.Normalize(NormalizationForm.FormD);
            IEnumerable<char> filtered = temp;
            filtered = filtered.Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark);
            input = new string(filtered.ToArray());

            // Remove spaces and numbers from string
            input = input.Replace(" ", string.Empty);
            input = Regex.Replace(input, @"[\d-]", string.Empty);
            
            return input;
        }
    }
}
