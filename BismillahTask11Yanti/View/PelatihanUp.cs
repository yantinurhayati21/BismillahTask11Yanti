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
    public partial class PelatihanUp : Form
    {
        public PelatihanUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 utama = new Form1();
            utama.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PelatihanController pelatihanController = new PelatihanController();

            pelatihanController.updateTraining(txtIdin.Text, txtNmin.Text, txtDescin.Text, dtStart.Value, dtFinish.Value, txtInsin.Text, txtLksin.Text, txtHrgin.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIdin.Focus();
            MessageBox.Show("Update Succesfully");
            Form1 upd1 = new Form1();

            upd1.Show();
            this.Hide();
        }

        private void dtFinish_ValueChanged(object sender, EventArgs e)
        {
            dtFinish.CustomFormat = "dd/MM/yyyy";
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtStart.CustomFormat = "dd/MM/yyyy";
        }
    }
}
