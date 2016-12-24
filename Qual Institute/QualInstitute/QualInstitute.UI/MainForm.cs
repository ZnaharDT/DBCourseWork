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
using QualInstitute.Domain.Entities;

namespace QualInstitute.UI
{
    public partial class MainForm : Form
    {
        private Type _currentTableEntity;
        public User CurrentUser { get; set; }

        public MainForm(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            if (!CurrentUser.IsAdmin)
            {
                buttonAdd.Enabled = false;
                buttonRemove.Enabled = false;
            }
            FilterComboBox.Enabled = false;
            SecondFilterComboBox.Enabled = false;
        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Items.Clear();

            _currentTableEntity = typeof(Student);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;
            BindingSource studentsBind = new BindingSource();
            foreach (var student in InstituteDB.Repository.Students.Join(InstituteDB.Repository.Groups,
                s => s.GroupID,
                g => g.GroupID,
                (s, g) => new
                {
                    Name = s.Name,
                    Surname = s.Surname,
                    Organisation = s.Organisation,
                    Group = g.Name
                }))
            {
                studentsBind.Add(student);
            }
            dataGrid.DataSource = studentsBind;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ім'я", DataPropertyName = "Name" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Прізвище", DataPropertyName = "Surname" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Organisation", DataPropertyName = "Organisation" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Group", DataPropertyName = "Group" });
            FilterComboBox.Enabled = true;
            FilterComboBox.Items.AddRange(InstituteDB.Repository.Groups.Select(g => g.Name).Distinct().ToArray());
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = false;

            _currentTableEntity = typeof(Group);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;
            
            BindingSource groupsBindingSource = new BindingSource();
            foreach (var group in InstituteDB.Repository.Groups
                .Join(InstituteDB.Repository.Specialities,
                s => s.SpecialityID,
                g => g.SpecialityID,
                (g, s) => new { g.Name, Speciality = s.Name}))
            {
                groupsBindingSource.Add(group);
            }
            dataGrid.DataSource = groupsBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Група", DataPropertyName = "Name" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Спеціальність", DataPropertyName = "Speciality" });
            dataGrid.AutoResizeColumns();

        }

        private void спеціальностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = false;

            _currentTableEntity = typeof(Speciality);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;

            BindingSource specBindingSource = new BindingSource();
            foreach (
                     var speciality in
                     InstituteDB.Repository.Specialities.Select(
                         s => new { s.Name, s.StudyingTime, s.TimesAtYear, HasHostel = s.HasHostel ? "Є" : "Немає" }))
            {
                specBindingSource.Add(speciality);
            }
            dataGrid.DataSource = specBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Спеціальність", DataPropertyName = "Name" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Час навч. (міс.)", DataPropertyName = "StudyingTime" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Набір (раз на рік)", DataPropertyName = "TimesAtYear" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Гуртожиток", DataPropertyName = "HasHostel" });
            dataGrid.AutoResizeColumns();
        }

        private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = true;
            FilterComboBox.Items.Clear();
            _currentTableEntity = typeof(ScheduleItem);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;
            BindingSource scheduleBindingSource = new BindingSource();

            var items = from i in InstituteDB.Repository.Schedule
                        join Group g in InstituteDB.Repository.Groups
                        on i.GroupID equals g.GroupID
                        join Subject s in InstituteDB.Repository.Subjects
                        on i.SubjectID equals s.SubjectID
                        join Teacher t in InstituteDB.Repository.Teachers
                        on i.TeacherID equals t.TeacherID
                        select new { Group = g.Name, Subject = s.Name, Teacher = t.Name + " " + t.Surname, Day = i.Day, Time = i.Time };
            foreach (var schedueItem in items)
            {
                scheduleBindingSource.Add(schedueItem);
            }
            dataGrid.DataSource = scheduleBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Группа", DataPropertyName = "Group" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Предмет", DataPropertyName = "Subject" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Викладач", DataPropertyName = "Teacher" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "День", DataPropertyName = "Day" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Час", DataPropertyName = "Time" });

            FilterComboBox.Items.AddRange(items.Select(s => s.Group).ToArray());
        }


        private void переглядОцінокToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = true;
            FilterComboBox.Items.Clear();

            _currentTableEntity = typeof(Mark);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;

            BindingSource marksBindingSource = new BindingSource();
            var studentMarks = from m in InstituteDB.Repository.Marks
                               join Student s in InstituteDB.Repository.Students
                               on m.StudentID equals s.StudentID
                               join Subject sj in InstituteDB.Repository.Subjects
                               on m.SubjectID equals sj.SubjectID
                               select new { m.MarkValue, Student = s.Name + " " + s.Surname, Subject = sj.Name };
            foreach (var mark in studentMarks)
            {
                marksBindingSource.Add(mark);
            }
            dataGrid.DataSource = marksBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Оцінка", DataPropertyName = "MarkValue" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Студент", DataPropertyName = "Student" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Предмет", DataPropertyName = "Subject" });
            dataGrid.AutoResizeColumns();

            FilterComboBox.Items.AddRange(InstituteDB.Repository.Groups.Select(g => g.Name).ToArray());

        }

        private class TeacherView
        {
            public Teacher Teacher { get; set; }

            public string Name => Teacher.Name;

            public string Surname => Teacher.Surname;

            public string Qual => Teacher.Qual ? "Є" : "Немає";
            
            public double Salary { get; set; }
        }

        private void викладачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = false;

            _currentTableEntity = typeof(Teacher);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;

            BindingSource teachersBindingSource = new BindingSource();
            teachersBindingSource.DataSource = typeof(TeacherView);

            var teachersSalaries = from t in InstituteDB.Repository.Teachers
                                   join TeacherMonthWork w in InstituteDB.Repository.MonthReport
                                   on t.TeacherID equals w.TeacherID
                                   select new TeacherView
                                   {
                                       Teacher = t,
                                       Salary = (w.LectureHours * InstituteDB.Repository.Payments.FirstOrDefault(p => p.Qual == t.Qual).Rate
                                         + w.PracticeHours * InstituteDB.Repository.Payments.FirstOrDefault(p => p.Qual == false).Rate)
                                   };
            foreach (var t in teachersSalaries)
            {

                teachersBindingSource.Add(t);
            }
            dataGrid.DataSource = teachersBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ім'я", DataPropertyName = "Name" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Прізвише", DataPropertyName = "Surname" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Заробітна плата", DataPropertyName = "Salary" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Кваліфікація", DataPropertyName = "Qual" });
            dataGrid.AutoResizeColumns();
        }

        private void предметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterComboBox.Enabled = false;
            SecondFilterComboBox.Enabled = false;

            _currentTableEntity = typeof(Subject);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;

            BindingSource subjectsBindingSource = new BindingSource();
            foreach (var sub in InstituteDB.Repository.Subjects)
            {
                subjectsBindingSource.Add(sub);
            }
            dataGrid.DataSource = subjectsBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Назва", DataPropertyName = "Name" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Лекційних годин", DataPropertyName = "LectionHours" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Практичних годин", DataPropertyName = "PracticeHours" });
            dataGrid.AutoResizeColumns();
        }
        
        private void планаРоботиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPlanPreviewDialog.ShowDialog();
        }

        private void розкладуГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupPrintForm f = new GroupPrintForm();
            f.Show();
        }

        private void printPlan_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Use this font.
            using (Font headerFont = new Font("Times New Roman",
                16, FontStyle.Bold))
            {
                using (Font bodyFont
                    = new Font("Times New Roman", 12))
                {
                    // We'll skip this much space between rows.
                    int line_spacing = 20;

                    var plan = (from i in InstituteDB.Repository.StudyingPlan
                        join Speciality s in InstituteDB.Repository.Specialities
                        on i.SpecialityID equals s.SpecialityID
                        join Subject sj in InstituteDB.Repository.Subjects
                        on i.SubjectID equals sj.SubjectID
                        select new PlanItemView
                        {
                            Speciality = s.Name,
                            Subject = sj.Name,
                            LectionHours = sj.LectionHours.ToString(),
                            PracticeHours = sj.PracticeHours.ToString()
                        }).ToList();

                    // See how wide the columns must be.
                    string[] headers = { "Спеціальність", "Предмет", "Лекц. год.", "Практ. год." };
                    int[] columnWidths = FindColumnWidths(e.Graphics,
                        headerFont,
                        bodyFont,
                        headers,
                        plan.Cast<IListed>().ToList());

                    // Start at the left margin.
                    int x = e.MarginBounds.Left - 50;

                    // Print by columns.
                    for (int col = 0; col < headers.Length; col++)
                    {
                        // Print the header.
                        int y = e.MarginBounds.Top;
                        e.Graphics.DrawString(headers[col],
                            headerFont, Brushes.Blue, x, y);
                        y += (int)(line_spacing * 1.5);

                        // Print the items in the column.
                        foreach (PlanItemView planItem in plan)
                        {
                            e.Graphics.DrawString(planItem.GetList()[col],
                                bodyFont, Brushes.Black, x, y);
                            y += line_spacing;
                        }

                        // Move to the next column.
                        x += columnWidths[col];
                    } // Looping over columns
                } // using body_font
            } // using header_font

            //DrawGrid(e, y)
            e.HasMorePages = false;
        }

        public interface IListed
        {
            List<string> GetList();
        }

        private class PlanItemView : IListed
        {
            public string Speciality { get; set; }
            public string Subject { get; set; }
            public string LectionHours { get; set; }
            public string PracticeHours { get; set; }

            public List<string> GetList()
            {
                return new List<string>() { Speciality, Subject, LectionHours, PracticeHours };
            }
        }

        private int[] FindColumnWidths(Graphics gr,
            Font headerFont,
            Font bodyFont,
            string[] headers,
            IList<IListed> values)
        {
            // Make room for the widths.
            int[] widths = new int[headers.Length];

            // Find the width for each column.
            for (int col = 0; col < widths.Length; col++)
            {
                // Check the column header.
                widths[col] = (int)gr.MeasureString(headers[col], headerFont).Width;

                // Check the items.
                for (int row = 0; row < values.Count; row++)
                {
                    int valueWidth = (int)gr.MeasureString(values[row].GetList()[col], bodyFont).Width;
                    if (widths[col] < valueWidth)
                        widths[col] = valueWidth;
                }

                // Add some extra space.
                widths[col] += 20;
            }

            return widths;
        }

        private void екзаменаційноїВідомостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksPrintForm f = new MarksPrintForm();
            f.Show();
        }
        

        private void printSalary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Use this font.
            using (Font headerFont = new Font("Times New Roman",
                16, FontStyle.Bold))
            {
                using (Font bodyFont
                    = new Font("Times New Roman", 12))
                {
                    // We'll skip this much space between rows.
                    int line_spacing = 20;

                    var hoursWorked = from t in InstituteDB.Repository.Teachers
                        join TeacherMonthWork w in InstituteDB.Repository.MonthReport
                        on t.TeacherID equals w.TeacherID
                        select new {t.TeacherID, t.Name, t.Surname, t.Qual, w.LectureHours, w.PracticeHours};

                    var teachers = (from t in hoursWorked
                        select new SalaryView {Teacher = t.Name + " " + t.Surname,
                            Qual = t.Qual ? "Є" : "Немає",
                            Salary = (t.LectureHours * InstituteDB.Repository.Payments.FirstOrDefault(p => p.Qual == t.Qual).Rate 
                                + t.PracticeHours * InstituteDB.Repository.Payments.FirstOrDefault(p => p.Qual == false).Rate).ToString()})
                                .ToList();

                    // See how wide the columns must be.
                    string[] headers = { "Викладач", "Степінь", "Зарплата за місяць" };
                    int[] columnWidths = FindColumnWidths(e.Graphics,
                        headerFont,
                        bodyFont,
                        headers,
                        teachers.Cast<IListed>().ToList());

                    // Start at the left margin.
                    int x = e.MarginBounds.Left - 50;

                    // Print by columns.
                    for (int col = 0; col < headers.Length; col++)
                    {
                        // Print the header.
                        int y = e.MarginBounds.Top;
                        e.Graphics.DrawString(headers[col],
                            headerFont, Brushes.Blue, x, y);
                        y += (int)(line_spacing * 1.5);

                        // Print the items in the column.
                        foreach (var planItem in teachers)
                        {
                            e.Graphics.DrawString(planItem.GetList()[col],
                                bodyFont, Brushes.Black, x, y);
                            y += line_spacing;
                        }

                        // Move to the next column.
                        x += columnWidths[col];
                    } // Looping over columns
                } // using body_font
            } // using header_font

            //DrawGrid(e, y)
            e.HasMorePages = false;
        }

        public class SalaryView : IListed
        {
            public string Teacher;
            public string Qual;
            public string Salary;

            public List<string> GetList()
            {
                return new List<string> {Teacher, Qual, Salary};
            }
        }

        private void зарплатноїВідомостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printSalaryPreviewDialog.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OnAddClick(this, new EventArgs());
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            if (_currentTableEntity == typeof(Student))
            {
                Form f = new AddStudent();
                f.Show(this);
            }
            if (_currentTableEntity == typeof(Speciality))
            {
                Form f = new AddSpeciality();
                f.Show(this);
            }
            if (_currentTableEntity == typeof(Group))
            {
                Form f = new AddGroup();
                f.Show(this);
            }
            if (_currentTableEntity == typeof(Subject))
            {
                Form f = new AddSubject();
                f.Show(this);
            }
            if (_currentTableEntity == typeof(Teacher))
            {
                Form f = new AddTeacher();
                f.Show(this);
            }
            if (_currentTableEntity == typeof(ScheduleItem))
            {
                Form f = new AddShedule();
                f.Show(this);
            }
        }

        private class ScheduleItemBind
        {
            public ScheduleItem ScheduleItem { get; set; }

            public string Teacher
            {
                get
                {
                    var teacher = InstituteDB.Repository.Teachers.First(t => t.TeacherID == ScheduleItem.TeacherID);
                    return teacher.Name + " " + teacher.Surname;
                }
            }
            public string Subject
            {
                get
                {
                    var subject = InstituteDB.Repository.Subjects.First(t => t.SubjectID == ScheduleItem.SubjectID);
                    return subject.Name;
                }
            }

            public string Day => ScheduleItem.Day.ToString();

            public string Time => ScheduleItem.Time.ToString(@"hh\:mm\:ss");
        }
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentTableEntity == typeof(Student))
            {
                dataGrid.Columns.Clear();
                dataGrid.Rows.Clear();
                dataGrid.AutoGenerateColumns = false;
                BindingSource studentsBind = new BindingSource();
                studentsBind.DataSource = typeof(Student);
                int groupID = InstituteDB.Repository.Groups.First(group => group.Name == FilterComboBox.SelectedItem.ToString()).GroupID;
                foreach (var student in InstituteDB.Repository.Students.Where(student => student.GroupID == groupID))
                {
                    studentsBind.Add(student);
                }
                dataGrid.DataSource = studentsBind;

                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ім'я", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "Name" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Прізвище", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "Surname" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Organisation", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "Organisation" });
            }
            if (_currentTableEntity == typeof(ScheduleItem))
            {
                dataGrid.Columns.Clear();
                dataGrid.Rows.Clear();
                dataGrid.AutoGenerateColumns = false;
                BindingSource scheduleBind = new BindingSource();
                scheduleBind.DataSource = typeof(ScheduleItemBind);
                int groupID = InstituteDB.Repository.Groups.First(group => group.Name == FilterComboBox.SelectedItem.ToString()).GroupID;
                foreach (var item in InstituteDB.Repository.Schedule.Where(item => item.GroupID == groupID))
                {
                    scheduleBind.Add(new ScheduleItemBind {ScheduleItem = item});
                }
                dataGrid.DataSource = scheduleBind;
                
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Предмет", DataPropertyName = "Subject" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Викладач", DataPropertyName = "Teacher" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "День", DataPropertyName = "Day" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Час", DataPropertyName = "Time" });
            }
            else if(_currentTableEntity == typeof(Mark))
            {
                SecondFilterComboBox.Enabled = true;
                dataGrid.Columns.Clear();
                dataGrid.Rows.Clear();
                dataGrid.AutoGenerateColumns = false;
                BindingSource studentsBind = new BindingSource();

              

                int groupID = InstituteDB.Repository.Groups.First(group => group.Name == FilterComboBox.SelectedItem.ToString()).GroupID;
                var groupStudents = InstituteDB.Repository.Students.Where(s => s.GroupID == groupID);
                var studentMarks = from m in InstituteDB.Repository.Marks
                                   join Student s in groupStudents
                                   on m.StudentID equals s.StudentID
                                   join Subject sj in InstituteDB.Repository.Subjects
                                   on m.SubjectID equals sj.SubjectID
                                   select new { m.MarkValue, Student = s.Name + " " + s.Surname, Subject = sj.Name };

                foreach (var mark in studentMarks)
                {
                    studentsBind.Add(mark);
                }
                dataGrid.DataSource = studentsBind;

                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Оцінка", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "MarkValue" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Студент", DataPropertyName = "Student" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Предмет", DataPropertyName = "Subject" });
                dataGrid.AutoResizeColumns();

                SecondFilterComboBox.Items.AddRange(studentMarks.Select(s => s.Subject).Distinct().ToArray());
            }
        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            InstituteDB.Repository.SaveChanges();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_currentTableEntity == typeof(Student))
            {
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                {
                    var surname = item.Cells[1].Value.ToString();
                    var name = item.Cells[0].Value.ToString();
                    InstituteDB.Repository.Students.Remove(
                        InstituteDB.Repository.Students.First(s => s.Surname == surname && s.Name == name));
                    dataGrid.Rows.RemoveAt(item.Index);
                }

                InstituteDB.Repository.SaveChanges();
            }
            if (_currentTableEntity == typeof(Group))
            {
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                {
                    var groupName = item.Cells[0].Value.ToString();
                    var spec = InstituteDB.Repository.Specialities.First(s => s.Name == item.Cells[1].Value.ToString()).SpecialityID;
                    InstituteDB.Repository.Groups.Remove(
                        InstituteDB.Repository.Groups.First(g => g.Name == groupName && g.SpecialityID == spec));
                    dataGrid.Rows.RemoveAt(item.Index);
                }

                InstituteDB.Repository.SaveChanges();
            }
            if (_currentTableEntity == typeof(Teacher))
            {
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                {
                    var surname = item.Cells[1].Value.ToString();
                    var name = item.Cells[0].Value.ToString();
                    InstituteDB.Repository.Teachers.Remove(
                        InstituteDB.Repository.Teachers.First(s => s.Surname == surname && s.Name == name));
                    dataGrid.Rows.RemoveAt(item.Index);
                }

                InstituteDB.Repository.SaveChanges();
            }
            if (_currentTableEntity == typeof(Subject))
            {
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                {
                    var subjName = item.Cells[0].Value.ToString();
                    InstituteDB.Repository.Subjects.Remove(
                        InstituteDB.Repository.Subjects.First(s => s.Name == subjName));
                    dataGrid.Rows.RemoveAt(item.Index);
                }

                InstituteDB.Repository.SaveChanges();
            }
            if (_currentTableEntity == typeof(Speciality))
            {
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                {
                    var specName = item.Cells[1].Value.ToString();
                    InstituteDB.Repository.Specialities.Remove(
                        InstituteDB.Repository.Specialities.First(s => s.Name == specName));
                    dataGrid.Rows.RemoveAt(item.Index);
                }

                InstituteDB.Repository.SaveChanges();
            }
            if (_currentTableEntity == typeof(ScheduleItem))
            {
                foreach (DataGridViewRow item in dataGrid.SelectedRows)
                {
                    var groupID = InstituteDB.Repository.Groups.First(g => g.Name == item.Cells[0].Value).GroupID;
                    var subjID = InstituteDB.Repository.Subjects.First(s => s.Name == item.Cells[1].Value).SubjectID;
                    var day = item.Cells[3].Value.ToString();
                    var time = item.Cells[4].Value.ToString();
                    var specName = item.Cells[1].Value.ToString();
                    InstituteDB.Repository.Schedule.Remove(
                        InstituteDB.Repository.Schedule.First(
                            s =>
                                s.GroupID == groupID && 
                                s.SubjectID == subjID && 
                                s.Day.ToString() == day &&
                                s.Time.ToString(@"hh\:mm\:ss") == time));
                    dataGrid.Rows.RemoveAt(item.Index);
                }

                InstituteDB.Repository.SaveChanges();
            }
        }

        private void SecondFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentTableEntity == typeof(Mark))
            {
                dataGrid.Columns.Clear();
                dataGrid.Rows.Clear();
                dataGrid.AutoGenerateColumns = false;
                BindingSource studentsBind = new BindingSource();



                int groupID =
                    InstituteDB.Repository.Groups.First(group => group.Name == FilterComboBox.SelectedItem.ToString())
                        .GroupID;
                int subjectID =
                    InstituteDB.Repository.Subjects.First(s => s.Name == SecondFilterComboBox.SelectedItem.ToString())
                        .SubjectID;
                var groupStudents = InstituteDB.Repository.Students.Where(s => s.GroupID == groupID);
                var groupSubjects = InstituteDB.Repository.Subjects.Where(s => s.SubjectID == subjectID);
                var studentMarks = from m in InstituteDB.Repository.Marks
                                   join Student s in groupStudents
                                   on m.StudentID equals s.StudentID
                                   join Subject sj in groupSubjects
                                   on m.SubjectID equals sj.SubjectID
                                   select new { m.MarkValue, Student = s.Name + " " + s.Surname};

                foreach (var mark in studentMarks)
                {
                    studentsBind.Add(mark);
                }
                dataGrid.DataSource = studentsBind;

                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Оцінка", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "MarkValue" });
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Студент", DataPropertyName = "Student" });
                dataGrid.AutoResizeColumns();
            }
        }

        private class MarkBind
        {
            public Mark Mark { get; set; }

            public int MarkValue
            {
                get { return Mark.MarkValue; }
                set { Mark.MarkValue = value; }
            }
            public string StudentFullName { get; set; }
        }

        private void MakeGroupMarks(object sender, GroupAndSubjectEventArgs e)
        {
            List<Mark> newMarks = new List<Mark>();

            List<Mark> oldMarks = new List<Mark>();
            foreach (Student student in InstituteDB.Repository.Students.Where(s => s.GroupID == e.Group.GroupID))
            {
                var mark = InstituteDB.Repository.Marks.FirstOrDefault(
                    m => m.StudentID == student.StudentID && m.SubjectID == e.Subject.SubjectID);
                if (mark == null)
                {
                    newMarks.Add(new Mark
                    {
                        SubjectID = e.Subject.SubjectID,
                        StudentID = student.StudentID
                    });
                }
                else
                {
                    oldMarks.Add(mark);
                }
            }

            InstituteDB.Repository.Marks.AddRange(newMarks);

            List<Mark> allMarks = new List<Mark>();
            allMarks.AddRange(oldMarks);
            allMarks.AddRange(newMarks);

            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = false;
            _currentTableEntity = typeof(MarkBind);
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;

            BindingSource marksBindingSource = new BindingSource();
            var studentMarks = from m in allMarks
                               join Student s in InstituteDB.Repository.Students
                               on m.StudentID equals s.StudentID
                               select new MarkBind { Mark = m, StudentFullName = s.Name + " " + s.Surname};
            foreach (var mark in studentMarks)
            {
                marksBindingSource.Add(mark);
            }
            dataGrid.DataSource = marksBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Студент", DataPropertyName = "StudentFullName" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Оцінка", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "MarkValue" });
            dataGrid.AutoResizeColumns();

        }

        private void сформуватиВідомістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupStudentsShow f = new GroupStudentsShow();
            f.OnGroupAndSubjectSelectedEvent += MakeGroupMarks;
            f.Show();
        }

        private void змінитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Autorisation();
            this.Hide();
            f.Show();
        }

        private class TeacherMonthWorkBind
        {
            public TeacherMonthWork TeacherMonthWork { get; set; }

            public string TeacherFullName
            {
                get
                {
                    var teacher = InstituteDB.Repository.Teachers.First(t => t.TeacherID == TeacherMonthWork.TeacherID);
                    return teacher.Name + " " + teacher.Surname;
                }
            }

            public int LectHours
            {
                get { return TeacherMonthWork.LectureHours; }
                set { TeacherMonthWork.LectureHours = value; }
            }

            public int PracticeHours
            {
                get { return TeacherMonthWork.PracticeHours; }
                set { TeacherMonthWork.PracticeHours = value; }
            }

        }

        private void планРоботиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentTableEntity = typeof(TeacherMonthWork);
            SecondFilterComboBox.Enabled = false;
            FilterComboBox.Enabled = false;
            
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
            dataGrid.AutoGenerateColumns = false;

            BindingSource specBindingSource = new BindingSource();
            specBindingSource.DataSource = typeof(TeacherMonthWorkBind);
            foreach (
                     var teacherMonthWork in
                     InstituteDB.Repository.MonthReport.Select(
                         r => new TeacherMonthWorkBind {TeacherMonthWork = r}))
            {
                specBindingSource.Add(teacherMonthWork);
            }
            dataGrid.DataSource = specBindingSource;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Викладач", DataPropertyName = "TeacherFullName" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Лекц. годин", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "LectHours" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Практ. годин", ReadOnly = !CurrentUser.IsAdmin, DataPropertyName = "PracticeHours" });
            dataGrid.AutoResizeColumns();

        }
    }
}