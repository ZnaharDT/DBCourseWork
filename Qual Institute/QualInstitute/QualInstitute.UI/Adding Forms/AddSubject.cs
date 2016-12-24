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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxLectHours.Text) ||
                string.IsNullOrEmpty(textBoxPracticeHours.Text))
            {
                MessageBox.Show(@"Заповніть всі поля, будь-ласка.");
                return;
            }

            InstituteDB.Repository.Subjects.Add(new Subject
            {
                Name = textBoxName.Text,
                LectionHours = int.Parse(textBoxLectHours.Text),
                PracticeHours = int.Parse(textBoxPracticeHours.Text)
            });

            InstituteDB.Repository.SaveChanges();
            MessageBox.Show(@"Запис додано успішно!");
        }
    }
}
