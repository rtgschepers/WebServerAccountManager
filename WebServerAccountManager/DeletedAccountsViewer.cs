using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServerAccountManager
{
    public partial class DeletedAccountsViewer : Form
    {
        Webserver ws;
        List<Person> deletedAccounts;
        List<Person> failedAccounts;

        public DeletedAccountsViewer(Webserver ws, List<Person> deletedAccounts, List<Person> failedAccounts)
        {
            InitializeComponent();
            gbDeletedAccounts.Height = this.Height / 2;

            this.ws = ws;
            this.deletedAccounts = deletedAccounts;
            this.failedAccounts = failedAccounts;
        }

        private void DeletedAccountsViewer_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} - Verwijderde Accounts", ws.domain);
            dgvDeletedAccounts.DataSource = deletedAccounts;
            dgvFailedAccounts.DataSource = failedAccounts;
        }

        private void DeletedAccountsViewer_Resize(object sender, EventArgs e)
        {
            gbDeletedAccounts.Height = this.Height / 2;
        }
    }
}
