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
    public partial class AddSpeciality : Form
    {
        public AddSpeciality()
        {
            InitializeComponent();
        }

        private void buttonAddSpec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxStudyingTime.Text) ||
                string.IsNullOrEmpty(textBoxTimesAtYear.Text))
            {
                MessageBox.Show(@"Заповніть всі поля, будь-ласка.");
                return;
            }

            InstituteDB.Repository.Specialities.Add(new Speciality
            {
                Name = textBoxName.Text,
                StudyingTime = Int32.Parse(textBoxStudyingTime.Text),
                TimesAtYear = Int32.Parse(textBoxTimesAtYear.Text),
                HasHostel = checkBoxHostel.Checked
            });
            InstituteDB.Repository.SaveChanges();
            MessageBox.Show(@"Запис додано успішно!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = String.Empty;
            textBoxStudyingTime.Text = String.Empty;
            textBoxTimesAtYear.Text = String.Empty;
            checkBoxHostel.Checked = false;
        }
    }
}
