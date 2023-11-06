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
    public partial class Pelatihan : Form
    {
        ValidasiController val=new ValidasiController();
        public Pelatihan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.ValidateName(txtNmin.Text) && val.ValidateName(txtInsin.Text) && val.ValidateAddress(txtDescin.Text) && val.ValidateAddress(txtLksin.Text))
            {
                try
                {
                    PelatihanController pelatihanControlller = new PelatihanController();
                    pelatihanControlller.addTraining(txtIdin.Text, txtNmin.Text, txtDescin.Text, dtStart.Value, dtFinish.Value, txtInsin.Text, txtLksin.Text, txtHrgin.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtIdin.Focus();
                    MessageBox.Show("Saved Successfully");
                    Form1 lk = new Form1();
                    lk.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 utama = new Form1();
            utama.Show();      
            this.Close();
        }

        private void dtFinish_ValueChanged(object sender, EventArgs e)
        {
            dtFinish.CustomFormat = "dd/MM/yyyy";
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtStart.CustomFormat = "dd/MM/yyyy";
        }

        private void txtIdin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtDescin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtInsin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtHrgin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Pelatihan_Load(object sender, EventArgs e)
        {
            txtIdin.MaxLength = 4;
            txtNmin.MaxLength = 40;
            txtDescin.MaxLength = 100;
            txtInsin.MaxLength= 40;
            txtLksin.MaxLength = 50;
            txtHrgin.MaxLength = 30;
        }

        private void txtLksin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
