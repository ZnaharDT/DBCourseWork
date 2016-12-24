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
using QualInstitute.UI;

namespace QualInstitute
{
    public partial class GroupPrintForm : Form
    {
        private class ScheduleItemView
        {
            public string Subject;
            public string Teacher;
            public string Day;
            public string Time;

            public List<string> GetList()
            {
                return new List<string>() { Subject, Teacher, Day, Time};
            }
        }

        public GroupPrintForm()
        {
            InitializeComponent();

            GroupComboBox.Items.AddRange(InstituteDB.Repository.Groups.Select(g => g.Name).ToArray());
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Use this font.
            using (Font header_font = new Font("Times New Roman",
                16, FontStyle.Bold))
            {
                using (Font body_font = new Font("Times New Roman", 12))
                {
                    // We'll skip this much space between rows.
                    int line_spacing = 20;

                    int groupID =
                        InstituteDB.Repository.Groups.First(g => g.Name == GroupComboBox.SelectedItem.ToString())
                            .GroupID;

                    IList<ScheduleItemView> groupSchedule  = new List<ScheduleItemView>();
                    try
                    {
                        groupSchedule = (from i in InstituteDB.Repository.Schedule
                                join Group g in InstituteDB.Repository.Groups
                                on i.GroupID equals g.GroupID
                                join Subject s in InstituteDB.Repository.Subjects
                                on i.SubjectID equals s.SubjectID
                                join Teacher t in InstituteDB.Repository.Teachers
                                on i.TeacherID equals t.TeacherID
                                where i.GroupID == groupID
                                select
                                new ScheduleItemView { Subject = s.Name, Teacher = t.Name + " " + t.Surname, Day = i.Day.ToString(), Time = i.Time.ToString()})
                            .ToList();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.InnerException.Message);
                    }

                    // See how wide the columns must be.
                    string[] headers = new string[] {"Предмет", "Викладач", "День", "Час"};
                    int[] column_widths = FindColumnWidths(e.Graphics, 
                        header_font, 
                        body_font,
                        headers, 
                        groupSchedule);

                    // Start at the left margin.
                    int x = e.MarginBounds.Left;

                    // Print by columns.
                    for (int col = 0; col < headers.Length; col++)
                    {
                        // Print the header.
                        int y = e.MarginBounds.Top;
                        e.Graphics.DrawString(headers[col],
                            header_font, Brushes.Blue, x, y);
                        y += (int)(line_spacing * 1.5);

                        // Print the items in the column.
                        for (int row = 0; row <
                            groupSchedule.Count; row++)
                        {
                            e.Graphics.DrawString(groupSchedule[row].GetList()[col],
                                body_font, Brushes.Black, x, y);
                            y += line_spacing;
                        }

                        // Move to the next column.
                        x += column_widths[col];
                    } // Looping over columns
                } // using body_font
            } // using header_font

            //DrawGrid(e, y)
            e.HasMorePages = false;

        }

        private int[] FindColumnWidths(Graphics gr, 
            Font header_font, 
            Font body_font, 
            string[] headers, 
            IList<ScheduleItemView> values)
        {
            // Make room for the widths.
            int[] widths = new int[headers.Length];

            // Find the width for each column.
            for (int col = 0; col < widths.Length; col++)
            {
                // Check the column header.
                widths[col] = (int)gr.MeasureString(headers[col], header_font).Width;

                // Check the items.
                for (int row = 0; row < values.Count; row++)
                {
                    int value_width = (int)gr.MeasureString(values[row].GetList()[col], body_font).Width;
                    if (widths[col] < value_width)
                        widths[col] = value_width;
                }

                // Add some extra space.
                widths[col] += 20;
            }

            return widths;
        }
    }
}
