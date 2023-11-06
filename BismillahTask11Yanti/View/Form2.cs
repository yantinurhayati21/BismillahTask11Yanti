using BismillahTask11Yanti.Controller;
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

namespace BismillahTask11Yanti.View
{
    public partial class Form2 : Form
    {
        private PesertaController pesertaController;
        public Form2()
        {
            pesertaController = new PesertaController();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridViewPst.DataSource = pesertaController.selectPeserta(new MySqlCommand("select * from Peserta"));
            dataGridViewPst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main utama = new Main();
            utama.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PesertaAdd pAdd = new PesertaAdd();
            pAdd.Show();
            this.Hide();
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            PesertaUpt pUpd = new PesertaUpt();
            pUpd.Show();
            this.Hide();

            pUpd.txtIdPs.Text = this.dataGridViewPst.CurrentRow.Cells[0].Value.ToString();
            pUpd.txtNmPs.Text = this.dataGridViewPst.CurrentRow.Cells[1].Value.ToString();
            pUpd.txtEmail.Text = this.dataGridViewPst.CurrentRow.Cells[2].Value.ToString();
            pUpd.txtNoT.Text = this.dataGridViewPst.CurrentRow.Cells[3].Value.ToString();
        }
        bool verify()
        {
            if ((txtIdPst.Text == "") || (txtNamePst.Text == "") || (txtEmail.Text == "") || (txtHrg.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {

                    pesertaController.deletePeserta(txtIdPst.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Peserta Deleted Succesfully", "Delete Peserta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPst.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Peserta not delete", "Delete Peserta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdPst.Clear();
            txtNamePst.Clear();
            txtEmail.Clear();
            txtHrg.Clear();
        }

        private void dataGridViewPst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPst.Text = dataGridViewPst.CurrentRow.Cells[0].Value.ToString();
            txtNamePst.Text = dataGridViewPst.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGridViewPst.CurrentRow.Cells[2].Value.ToString();
            txtHrg.Text = dataGridViewPst.CurrentRow.Cells[3].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewPst.Width, this.dataGridViewPst.Height);
            dataGridViewPst.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewPst.Width, this.dataGridViewPst.Height));
            e.Graphics.DrawImage(btm, 170, 120);
            e.Graphics.DrawString(lblPrintf.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 50));
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridViewPst.DataSource = pesertaController.searchPeserta(txtSearch.Text);
        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void pcrClean_Click(object sender, EventArgs e)
        {
            txtIdPst.Clear();
            txtNamePst.Clear();
            txtEmail.Clear();
            txtHrg.Clear();
        }

        private void pcrUpt_Click(object sender, EventArgs e)
        {
            PesertaUpt pUpd = new PesertaUpt();
            pUpd.Show();
            this.Hide();

            pUpd.txtIdPs.Text = this.dataGridViewPst.CurrentRow.Cells[0].Value.ToString();
            pUpd.txtNmPs.Text = this.dataGridViewPst.CurrentRow.Cells[1].Value.ToString();
            pUpd.txtEmail.Text = this.dataGridViewPst.CurrentRow.Cells[2].Value.ToString();
            pUpd.txtNoT.Text = this.dataGridViewPst.CurrentRow.Cells[3].Value.ToString();
        }

        private void pcrAdd_Click(object sender, EventArgs e)
        {
            PesertaAdd pAdd = new PesertaAdd();
            pAdd.Show();
            this.Hide();
        }

        private void pcrDlt_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {

                    pesertaController.deletePeserta(txtIdPst.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Peserta Deleted Succesfully", "Delete Peserta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPst.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Peserta not delete", "Delete Peserta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
