using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BismillahTask11Yanti.View
{
    public partial class Login : Form
    {
        public string name;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {        
            string username = "yanti";
            string password = "admin";
            if (txtUs.Text == username && txtPsw.Text == password)
            {
                this.Hide();
                MessageBox.Show("Login Succes");
                Main main = new Main();
                main.login = this;
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUs.Clear();
                txtPsw.Clear();
                txtUs.Focus();
            }
        }
        public string GetName()
        {
            this.name = "Hello " + this.txtUs.Text;
            return this.name;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUs.MaxLength = 7;
            txtPsw.MaxLength = 7;
        }

        private void txtUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
