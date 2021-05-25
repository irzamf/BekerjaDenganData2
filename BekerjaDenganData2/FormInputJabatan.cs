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
    public partial class FormInputJabatan : Form
    {
        public FormInputJabatan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=BekerjaDenganData2";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_InputJabatan";
                // Mengatur tipe command yang akan digunakan
                com.CommandType = CommandType.StoredProcedure;

                // Parameter yang akan dikirimkan ke sp di basis data
                if (txtIdJabatan.Text == "" || txtNamaJabatan.Text == "")
                {
                    MessageBox.Show("Semua Data Harus Diisi!");
                }
                else
                {
                    com.Parameters.AddWithValue("@id_jabatan", txtIdJabatan.Text);
                    com.Parameters.AddWithValue("@nama_jabatan", txtNamaJabatan.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();
                    // cek apakah ada data yang ditambahkan
                    if (result != 0)
                    {
                        MessageBox.Show("Input data berhasil!");
                    }
                    else
                    {
                        MessageBox.Show("Inut data gagal!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtIdJabatan.Text = "";
            txtNamaJabatan.Text = "";
        }
    }
}
