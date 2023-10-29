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
    public partial class Main : Form
    {
        public Login login;
        public Main()
        {
            InitializeComponent();
        }

        private void btnPelatihan_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tampil();
        }

        public void tampil()
        {
            if (login != null)
            {
                txtLogin.Text = login.GetName();
            }
        }

        private void btnPeserta_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Contiue or not", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.No)
                Application.Exit();
        }

    }
}
