using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace Responsi
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=lia_responsi";
        public DataTable dt;
        private string sql = null;
        private DataGridViewRow r;
        public static NpgsqlCommand cmd;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            RefreshData();
        }
        void RefreshData()
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = @"SELECT*from kr_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"Select * from kr_insert(: _nama, : id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", txtNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDepKaryawan.SelectedItem.ToString());
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diinputkan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    RefreshData();
                    txtNamaKaryawan.Text = cbDepKaryawan.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }   
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];   
                txtNamaKaryawan.Text = r.Cells["_nama"].Value.ToString();
                cbDepKaryawan.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih Baris data yang akan di edit","Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"Select * from kr_update(: _nama,:_id_dep,:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama",txtNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDepKaryawan.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diedit", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    RefreshData();
                    txtNamaKaryawan.Text = cbDepKaryawan.Text = null;
                    r = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Edit FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                MessageBox.Show("Pilh barus yang akan dihapus","Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Apakah benar anda ingin menghapus data karyawan" + r.Cells["_nama"].Value.ToString()+"?","Konfirmasi terhapus",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"Select * from kr_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        RefreshData();
                        txtNamaKaryawan.Text = cbDepKaryawan.Text = null;
                        r = null;
                    }

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}
