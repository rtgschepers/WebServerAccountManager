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
    public partial class GroupViewer : Form
    {
        public GroupViewer(List<Person> students)
        {
            InitializeComponent();
            initForm(students);
        }

        public void changeGroup(List<Person> students)
        {
            initForm(students);
        }

        private void initForm(List<Person> students)
        {

            this.Text = string.Format("{0} ({1})", students[0].group, students.Count);
            dgvStudents.DataSource = students;
        }
    }
}
