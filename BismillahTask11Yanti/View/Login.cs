using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Main main = new Main();
            if (main != null)
            {
                main.login = this;
                main.Show();
                this.Hide();
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
        }

        private void txtUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
