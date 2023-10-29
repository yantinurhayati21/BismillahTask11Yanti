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
    public partial class PesertaAdd : Form
    {
        public PesertaAdd()
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
            pesertaController.tambahPeserta(txtIdPs.Text, txtNmPs.Text, txtEmail.Text, txtNoT.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIdPs.Focus();
            MessageBox.Show("data disimpan");
            Form2 lk = new Form2();

            lk.Show();
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

        private void txtIdPs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNmPs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNoT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void PesertaAdd_Load(object sender, EventArgs e)
        {
            txtIdPs.MaxLength = 4;
            txtNmPs.MaxLength = 40;
            txtEmail.MaxLength = 30;
            txtNoT.MaxLength = 13;
        }
    }
}
