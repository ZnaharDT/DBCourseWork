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
    public partial class AddStudent : Form
    {
        private List<Group> Groups;

        public AddStudent()
        {
            InitializeComponent();
            Groups = InstituteDB.Repository.Groups.ToList();

            comboBoxGroup.Items.AddRange(Groups.Select(g => g.Name).ToArray());
        }

        private void buttonAddSud_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxSecName.Text) ||
                string.IsNullOrEmpty(textBoxSurname.Text) ||
                string.IsNullOrEmpty(textBoxOrganisation.Text) ||
                string.IsNullOrEmpty(comboBoxGroup.SelectedItem.ToString()))
            { 
                MessageBox.Show(@"Заповніть всі поля, будь-ласка.");
                return;
            }

            InstituteDB.Repository.Students.Add(new Student
                {
                    GroupID = Groups.First(g => g.Name == comboBoxGroup.Text).GroupID,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Organisation = textBoxOrganisation.Text
                });
            InstituteDB.Repository.SaveChanges();
            MessageBox.Show(@"Запис додано успішно!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = String.Empty;
            textBoxSecName.Text = String.Empty;
            textBoxSurname.Text = String.Empty;
            textBoxOrganisation.Text = String.Empty;
            comboBoxGroup.SelectedItem = null;
        }
    }
}
