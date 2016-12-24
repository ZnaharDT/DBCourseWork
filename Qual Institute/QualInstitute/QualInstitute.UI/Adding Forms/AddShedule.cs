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
    public partial class AddShedule : Form
    {
        private Days[] days;

        public AddShedule()
        {
            InitializeComponent();
            comboBoxTeacher.Items.Clear();
            comboBoxTeacher.Items.AddRange(InstituteDB.Repository.Teachers.Select(t => t.Surname).ToArray());
            comboBoxSubject.Items.Clear();
            comboBoxSubject.Items.AddRange(InstituteDB.Repository.Subjects.Select(s => s.Name).ToArray());
            comboBoxGroup.Items.Clear();
            comboBoxGroup.Items.AddRange(InstituteDB.Repository.Groups.Select(g => g.Name).ToArray());
            comboBoxDay.Items.Clear();
            days = new Days[]
            {
                Days.Monday,
                Days.Tuesday,
                Days.Wednesday,
                Days.Thursday,
                Days.Friday,
                Days.Saturday,
                Days.Sunday
            };
            comboBoxDay.Items.AddRange(new[]
            {
                Days.Monday.ToString(),
                Days.Tuesday.ToString(),
                Days.Wednesday.ToString(),
                Days.Thursday.ToString(),
                Days.Friday.ToString(),
                Days.Saturday.ToString(),
                Days.Sunday.ToString()
            });
            for (int i = 1; i <= 24; i++)
                comboBoxHour.Items.Add(i.ToString());
            for (int i = 1; i <= 60; i++)
                comboBoxMinute.Items.Add(i.ToString());
        }

        private void buttonAddShed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxGroup.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(comboBoxSubject.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(comboBoxTeacher.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(comboBoxDay.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(comboBoxHour.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(comboBoxMinute.SelectedItem.ToString()))
            {
                MessageBox.Show(@"Заповніть всі поля, будь-ласка.");
                return;
            }

            InstituteDB.Repository.Schedule.Add(new ScheduleItem
            {
                GroupID =
                    InstituteDB.Repository.Groups.First(g => g.Name == comboBoxGroup.SelectedItem.ToString()).GroupID,
                TeacherID =
                    InstituteDB.Repository.Teachers.First(t => t.Surname == comboBoxTeacher.SelectedItem.ToString())
                        .TeacherID,
                SubjectID =
                    InstituteDB.Repository.Subjects.First(s => s.Name == comboBoxSubject.SelectedItem.ToString())
                        .SubjectID,
                Day = days.First(d => d.ToString() == comboBoxDay.SelectedItem.ToString()),
                Time = new TimeSpan(int.Parse(comboBoxHour.SelectedItem.ToString()),
                    int.Parse(comboBoxMinute.SelectedItem.ToString()), 0
                )
            });

            InstituteDB.Repository.SaveChanges();
            MessageBox.Show(@"Запис додано успішно!");
        }
    }
}