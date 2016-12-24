using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QualInstitute.Domain.Entities;

namespace QualInstitute.UI
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User currentUser =
                InstituteDB.Repository.Users.FirstOrDefault(
                    u => u.Username == textBoxLogin.Text && u.Password == textBoxPass.Text);
            if (currentUser == null)
                MessageBox.Show(@"Невірний логін або пароль");
            else
            {
                MainForm f = new MainForm(currentUser);
                f.Show();
                this.Hide();
            }

        }
    }
}
