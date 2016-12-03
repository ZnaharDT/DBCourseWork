using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualInstitute.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource studentsBind = new BindingSource();
            foreach (var student in InstituteDB.Repository.Students)
            {
                studentsBind.Add(student);
            }

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ім'я", DataPropertyName = "Name" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Прізвище", DataPropertyName = "Surname" });
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Группа", DataPropertyName = "Group" });

            dataGrid.DataSource = studentsBind;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
