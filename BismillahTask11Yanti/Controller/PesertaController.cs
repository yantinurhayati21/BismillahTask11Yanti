using BismillahTask11Yanti.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BismillahTask11Yanti.Controller
{
    internal class PesertaController: Model.Connection
    {
        Connection koneksi = new Connection();
        public DataTable selectPeserta(MySqlCommand command)
        {
            DataTable datePeserta = new DataTable();
            try
            {
                string selectPeserta = "SELECT * FROM Peserta";
                da = new MySqlConnector.MySqlDataAdapter(selectPeserta, GetConn());
                da.Fill(datePeserta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return datePeserta;
        }

        public void addPeserta(string idPst, string nmPst, string email, string noTelp)
        {
            string tambah = "insert into Peserta values(" + "@nama_peserta, @email, @no_telepon)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idPst;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = nmPst;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTelp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }

        }

        public void tambahPeserta(string id, string nmPs, string email, string noTelp)
        {
            string addPeserta = "insert into Peserta values(" + "@id, @nama_peserta, @email, @no_telepon)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addPeserta, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = nmPs;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTelp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }

        }

        public void updatePeserta(string id, string nmPs, string email, string noTelp)
        {
            string update = "update Peserta set " + "nama_peserta=@nama_peserta, email=@email, no_telepon=@no_telepon " + "where id=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = nmPs;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTelp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }

        public void deletePeserta(string id)
        {
            string delete = "delete from Peserta where id=" + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }

        }

        public DataTable searchPeserta(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand
                    ("select * from Peserta where concat(id, nama_peserta,email,no_telepon)like '%" + search + "%'",koneksi.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}
