using BismillahTask11Yanti.Controller;
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
    public partial class PesertaUpt : Form
    {
        public PesertaUpt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PesertaController pesertaController = new PesertaController();

            pesertaController.updatePeserta(txtIdPs.Text, txtNmPs.Text, txtEmail.Text, txtNoT.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIdPs.Focus();
            MessageBox.Show("data diupdate");
            Form2 upd1 = new Form2();

            upd1.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2 upd2 = new Form2();
            upd2.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Form2 upd2 = new Form2();
            upd2.Show();
            this.Hide();
        }
    }
}
