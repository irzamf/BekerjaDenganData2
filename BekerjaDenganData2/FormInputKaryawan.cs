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
    public partial class FormInputKaryawan : Form
    {
        public FormInputKaryawan()
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
                com.CommandText = "sp_InputKaryawan";
                // Mengatur tipe command yang akan digunakan
                com.CommandType = CommandType.StoredProcedure;

                // Parameter yang akan dikirimkan ke sp di basis data
                if (txtNIK.Text == "" || txtNamaKaryawan.Text == "" || cbJabatan.Text == "")
                {
                    MessageBox.Show("Semua Data Harus Diisi!");
                }
                else
                {
                    com.Parameters.AddWithValue("@nik", txtNIK.Text);
                    com.Parameters.AddWithValue("@nama_karyawan", txtNamaKaryawan.Text);
                    com.Parameters.AddWithValue("@jabatan", cbJabatan.SelectedValue.ToString());

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
                        MessageBox.Show("Input data gagal!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bekerjaDenganData2DataSet.jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.bekerjaDenganData2DataSet.jabatan);

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtNIK.Clear();
            txtNamaKaryawan.Clear();
            cbJabatan.Text = "";
        }
    }
}
