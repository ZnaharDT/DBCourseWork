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
    public partial class AddGroup : Form
    {
        private List<Speciality> Specialities = new List<Speciality>();

        public AddGroup()
        {
            InitializeComponent();
            Specialities = new List<Speciality>();
            Specialities.AddRange(InstituteDB.Repository.Specialities);
            comboBoxSpec.Items.AddRange(Specialities.Select(s => s.Name).ToArray());
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGroupName.Text)||
                String.IsNullOrEmpty(comboBoxSpec.SelectedItem.ToString()))
            {
                MessageBox.Show(@"Заповніть всі поля, будь-ласка.");
                return;
            }

            InstituteDB.Repository.Groups.Add(new Group
            {
                Name = textBoxGroupName.Text,
                SpecialityID = Specialities.First(s => s.Name == comboBoxSpec.SelectedItem.ToString()).SpecialityID
            });

            InstituteDB.Repository.SaveChanges();
            MessageBox.Show(@"Запис додано успішно!");
        }
    }
}
