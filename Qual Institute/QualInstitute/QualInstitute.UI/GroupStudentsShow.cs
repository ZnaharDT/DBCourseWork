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
    public partial class GroupStudentsShow : Form
    {
        public delegate void GroupAndSubjectSelected(object sender, GroupAndSubjectEventArgs e);

        public event GroupAndSubjectSelected OnGroupAndSubjectSelectedEvent;

        public GroupStudentsShow()
        {
            InitializeComponent();
            GroupComboBox.Items.AddRange(InstituteDB.Repository.Groups.Select(g => g.Name).ToArray());
            SubjectComboBox.Enabled = false;
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectComboBox.Enabled = true;
            SubjectComboBox.Items.AddRange(InstituteDB.Repository.Subjects.Select(s => s.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group gr = InstituteDB.Repository.Groups.First(g => g.Name == GroupComboBox.SelectedItem.ToString());
            Subject sub = InstituteDB.Repository.Subjects.First(s => s.Name == SubjectComboBox.SelectedItem.ToString());
            OnGroupAndSubjectSelectedEvent?.Invoke(this, new GroupAndSubjectEventArgs {Group = gr, Subject = sub});
        }
    }

    public class GroupAndSubjectEventArgs : EventArgs
    {
        public Group Group { get; set; }
        public Subject Subject { get; set; }
    }
}
