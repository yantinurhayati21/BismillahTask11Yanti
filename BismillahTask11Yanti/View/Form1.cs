using BismillahTask11Yanti.Controller;
using BismillahTask11Yanti.View;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BismillahTask11Yanti
{
    
    public partial class Form1 : Form
    {
        private PelatihanController pelatihanController;
        public Form1()
        {
            pelatihanController = new PelatihanController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridViewPlt.DataSource = pelatihanController.selectTraining(new MySqlCommand("select * from Pelatihan"));

            dataGridViewPlt.Columns[0].Width = 40;
            dataGridViewPlt.Columns[1].Width = 180;
            dataGridViewPlt.Columns[2].Width = 280;
            dataGridViewPlt.Columns[3].Width = 90;
            dataGridViewPlt.Columns[4].Width = 90;
            dataGridViewPlt.Columns[5].Width = 100;
            dataGridViewPlt.Columns[6].Width = 90;
            dataGridViewPlt.Columns[7].Width = 90;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Pelatihan add = new Pelatihan();
            add.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main utama = new Main();         
            utama.Show();
            this.Hide();
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            PelatihanUp upd = new PelatihanUp();
            upd.Show();
            this.Hide();

            upd.txtIdin.Text = this.dataGridViewPlt.CurrentRow.Cells[0].Value.ToString();
            upd.txtNmin.Text = this.dataGridViewPlt.CurrentRow.Cells[1].Value.ToString();
            upd.txtDescin.Text = this.dataGridViewPlt.CurrentRow.Cells[2].Value.ToString();
            if (DateTime.TryParse(this.dataGridViewPlt.CurrentRow.Cells[3].Value.ToString(), out DateTime startDate))
            {
                upd.dtStart.Value = startDate;
            }
            else
            {
                MessageBox.Show("Kesalahan dalam format tanggal mulai.");
            }

            if (DateTime.TryParse(this.dataGridViewPlt.CurrentRow.Cells[4].Value.ToString(), out DateTime finishDate))
            {
                upd.dtFinish.Value = finishDate;
            }
            else
            {
                MessageBox.Show("Kesalahan dalam format tanggal selesai.");
            }

            upd.txtInsin.Text = this.dataGridViewPlt.CurrentRow.Cells[5].Value.ToString();
            upd.txtLksin.Text = this.dataGridViewPlt.CurrentRow.Cells[6].Value.ToString();
            upd.txtHrgin.Text = this.dataGridViewPlt.CurrentRow.Cells[7].Value.ToString();
        }

        private void dtMulai_ValueChanged(object sender, EventArgs e)
        {
            dtMulai.CustomFormat = "dd/MM/yyyy";
        }

        private void dtSelesai_ValueChanged(object sender, EventArgs e)
        {
            dtSelesai.CustomFormat = "dd/MM/yyyy";
        }

        bool verify()
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDesc.Text) ||
                dtMulai.Value == null || dtSelesai.Value == null ||
                string.IsNullOrEmpty(txtIns.Text) || string.IsNullOrEmpty(txtLks.Text) || string.IsNullOrEmpty(txtHrg.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtIns.Clear();
            txtLks.Clear();
            txtHrg.Clear();
            dtMulai.Value = DateTime.Now;
            dtSelesai.Value = DateTime.Now;
        }

        private void dataGridViewPlt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewPlt.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewPlt.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = dataGridViewPlt.CurrentRow.Cells[2].Value.ToString();

            try
            {
                dtMulai.Value = DateTime.Parse(dataGridViewPlt.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                dtMulai.Value = DateTime.Now;
            }

            try
            {
                dtSelesai.Value = DateTime.Parse(dataGridViewPlt.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                dtSelesai.Value = DateTime.Now;
            }
            txtIns.Text = dataGridViewPlt.CurrentRow.Cells[5].Value.ToString();
            txtLks.Text = dataGridViewPlt.CurrentRow.Cells[6].Value.ToString();
            txtHrg.Text = dataGridViewPlt.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {

                    pelatihanController.deleteTraining(txtId.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Training Deleted Succesfully", "Delete Training", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Training not delete", "Delete Training",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
