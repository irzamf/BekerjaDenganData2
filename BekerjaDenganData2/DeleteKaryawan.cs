using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BekerjaDenganData2
{
    public partial class DeleteKaryawan : Form
    {
        public DeleteKaryawan()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = BekerjaDenganData2";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "sp_CariData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nik", txtNIK.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNamaKaryawan.Text = dt.Rows[0]["nama_karyawan"].ToString();
                txtJabatan.Text = dt.Rows[0]["jabatan"].ToString();
                txtNamaKaryawan.Enabled = true;
                txtJabatan.Enabled = true;
                txtNIK.ReadOnly = true;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtNIK.Clear();
            txtNamaKaryawan.Clear();
            txtJabatan.Text = "";
            txtNIK.ReadOnly = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=BekerjaDenganData2";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_DeleteKaryawan";
                // Mengatur tipe command yang akan digunakan
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@nik", txtNIK.Text);
                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data yang ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Hapus data berhasil!");
                    txtNIK.Clear();
                    txtNamaKaryawan.Clear();
                    txtJabatan.Text = "";
                }
                else
                {
                    MessageBox.Show("Hapus data gagal!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
