using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QualInstitute.Domain;
using QualInstitute.UI;

namespace QualInstitute
{
    public partial class MarksPrintForm : Form
    {
        private Group currentGroup;
        private IQueryable<Student> groupStudents;
        private List<SubjectView> groupSubjects;
        private List<List<MarkView>> groupMarks;
        private int subjectCounter = 0;
        private int marksCounter = 0;

        private class MarkView
        {
            public string Student;
            public string Mark;

            public List<string> GetList()
            {
                return new List<string>() { Student, Mark };
            }
        }

        private class SubjectView
        {
            public int SubjectID;
            public int SpecialityID;
            public string Subject;
        }

        public MarksPrintForm()
        {
            InitializeComponent();
            GroupComboBox.Items.AddRange(InstituteDB.Repository.Groups.Select(g => g.Name).ToArray());
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            GetPrintData();
            subjectCounter = 0;
            marksCounter = 0;
            printMarksPreviewDialog.ShowDialog();
        }

        private void GetPrintData()
        {

            currentGroup = InstituteDB.Repository.Groups
                .First(g => g.Name == GroupComboBox.SelectedItem.ToString());

            groupStudents = (from s in InstituteDB.Repository.Students
                             where s.GroupID == currentGroup.GroupID
                             select s);


            groupSubjects = (from i in InstituteDB.Repository.StudyingPlan
                             where i.SpecialityID == currentGroup.SpecialityID
                             join Subject s in InstituteDB.Repository.Subjects
                             on i.SubjectID equals s.SubjectID
                             select new SubjectView { SubjectID = i.SubjectID, SpecialityID = i.SpecialityID, Subject = s.Name }).ToList();

            groupMarks = new List<List<MarkView>>();

            foreach (SubjectView sj in groupSubjects)
            {
                List<MarkView> subjectMarks = new List<MarkView>();
                foreach (Student s in groupStudents)
                {
                    var studentMarks = (from m in InstituteDB.Repository.Marks
                                        where m.StudentID == s.StudentID && m.SubjectID == sj.SubjectID
                                        orderby m.SubjectID
                                        select new MarkView { Student = s.Name + " " + s.Surname, Mark = m.MarkValue.ToString() });
                    subjectMarks.AddRange(studentMarks);
                }
                groupMarks.Add(subjectMarks);
            }

        }

        private int[] FindColumnWidths(Graphics gr,
            Font headerFont,
            Font bodyFont,
            string[] headers,
            List<List<MarkView>> values)
        {
            // Make room for the widths.
            int[] widths = new int[headers.Length];

            // Find the width for each column.
            foreach (List<MarkView> l in values)
            {
                for (int col = 0; col < widths.Length; col++)
                {
                    // Check the column header.
                    widths[col] = (int)gr.MeasureString(headers[col], headerFont).Width;

                    // Check the items.
                    for (int row = 0; row < l.Count; row++)
                    {
                        int valueWidth = (int)gr.MeasureString(l[row].GetList()[col], bodyFont).Width;
                        if (widths[col] < valueWidth)
                            widths[col] = valueWidth;
                    }

                    // Add some extra space.
                    widths[col] += 20;
                }
            }

            return widths;
        }

        private void printMarks_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Use this font.
            using (Font headerFont = new Font("Times New Roman", 16, FontStyle.Bold))
            {
                using (Font bodyFont = new Font("Times New Roman", 12))
                {
                    // We'll skip this much space between rows.
                    int line_spacing = 50;

                    // See how wide the columns must be.
                    string[] headers = { "Студент", "Оцінка", };
                    int[] columnWidths = FindColumnWidths(e.Graphics,
                        headerFont,
                        bodyFont,
                        headers,
                        groupMarks);


                    // Print by columns.

                    // Print the header.

                    int y = e.MarginBounds.Top;
                    // Print the items in the column.


                    while (groupMarks.Count != 0)
                    {

                        // Start at the left margin.
                        int x = e.MarginBounds.Left;
                        e.Graphics.DrawString(groupSubjects.ToList()[0].Subject,
                            headerFont,
                            Brushes.Blue,
                            x,
                            y);
                        y += (int)(line_spacing * 1.5);
                        for (int c = 0; c < headers.Length; c++)
                        {
                            string h = headers[c];
                            e.Graphics.DrawString(h,
                                headerFont,
                                Brushes.Blue,
                                x,
                                y);

                            // Move to the next column.
                            x += columnWidths[c];
                        }
                        y += (int)(line_spacing * 1.5);


                        while (groupMarks[0].Count != 0)
                        {
                            x = e.MarginBounds.Left;
                            for (int c = 0; c < headers.Length; c++)
                            {
                                MarkView mark = groupMarks[0][0];
                                e.Graphics.DrawString(mark.GetList()[c],
                                    bodyFont,
                                    Brushes.Black,
                                    x,
                                    y);
                                if (c == headers.Length - 1)
                                    groupMarks[0].RemoveAt(0);

                                // Move to the next column.
                                x += columnWidths[c];
                            }

                            y += line_spacing;
                            if (y >= e.MarginBounds.Bottom - 100)
                            {
                                e.HasMorePages = true;
                                break;
                            }
                        }

                        if (groupMarks[0].Count == 0)
                        {
                            groupMarks.RemoveAt(0);
                            groupSubjects.RemoveAt(0);
                        }

                        if (y >= e.MarginBounds.Bottom - 100)
                        {
                            e.HasMorePages = true;
                            break;
                        }

                    }
                } // Looping over columns
            } // using body_font
        } // using header_font

    }
}

