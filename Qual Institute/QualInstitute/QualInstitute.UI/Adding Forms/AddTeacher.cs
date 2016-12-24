using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QualInstitute.Domain;

namespace QualInstitute.UI
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show(@"Заповніть всі поля, будь-ласка.");
                return;
            }

            InstituteDB.Repository.Teachers.Add(new Teacher
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Qual = checkBoxQual.Checked
            });

            InstituteDB.Repository.SaveChanges();
            MessageBox.Show(@"Запис додано успішно!");
        }
    }
}
