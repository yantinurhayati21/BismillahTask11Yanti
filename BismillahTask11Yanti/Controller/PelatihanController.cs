﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BismillahTask11Yanti.Controller
{
    internal class PelatihanController:Model.Connection
    {
        public DataTable selectTraining(MySqlCommand command)
        {
            DataTable dataPelatihan = new DataTable();
            try
            {
                string select = "SELECT * FROM Pelatihan";
                da = new MySqlConnector.MySqlDataAdapter(select, GetConn());
                da.Fill(dataPelatihan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataPelatihan;
        }

        public bool valName(string name)
        {
            for(int a=0; a<name.Length;a++)
            {
                if ((name[a] >= '0' && name[a] <='9') || name[0] == ' ' || name[name.Length-1] == ' ' || name[a] == ':' || name[a] == ',' || name[0] == '-' || name[name.Length-1] == '-' || name[a] == '/' || name[a] == '\\' || name[a] == '?')
                {
                    MessageBox.Show("Input NAme field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    return false;
                }
            }
            return true;
        }

        public bool valDesc(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' || name[a] == ',' || name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' || name[a] == '?')
                {
                    MessageBox.Show("Input NAme field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public void addTraining(string idTra, string nmTra, string decs, DateTime tm, DateTime ts, string ins, string loc, string hrg)
        {
            string tambah = "insert into Pelatihan values(" + "@id,@nama_pelatihan, @deskripsi, @tanggal_mulai, @tanggal_selesai, @instruktur, @lokasi, @harga)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idTra;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = nmTra;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = decs;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = tm;
                cmd.Parameters.Add("@tanggal_selesai", MySqlConnector.MySqlDbType.VarChar).Value = ts;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = ins;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = loc;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = hrg;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }
        }

        public void updateTraining(string idTra, string nmTra, string decs, DateTime tm, DateTime ts, string ins, string loc, string hrg)
        {
            string update = "update Pelatihan set " + "nama_pelatihan=@nama_pelatihan, deskripsi=@deskripsi, tanggal_mulai=@tanggal_mulai, tanggal_selesai=@tanggal_selesai, instruktur=@instruktur, lokasi=@lokasi, harga=@harga " + "where id=" + idTra;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idTra;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = nmTra;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = decs;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = tm;
                cmd.Parameters.Add("@tanggal_selesai", MySqlConnector.MySqlDbType.VarChar).Value = ts;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = ins;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = loc;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = hrg;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }

        public void deleteTraining(string id)
        {
            string delete = "delete from Pelatihan where id=" + id;

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

    }
}
