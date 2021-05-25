using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BekerjaDenganData2
{
    public partial class FormBekerjaDenganData : Form
    {
        public FormBekerjaDenganData()
        {
            InitializeComponent();
        }

        private void btnInputJabatan_Click(object sender, EventArgs e)
        {
            FormInputJabatan inJab = new FormInputJabatan();
            inJab.Show();
        }

        private void btnInputKaryawan_Click(object sender, EventArgs e)
        {
            FormInputKaryawan inKar = new FormInputKaryawan();
            inKar.Show();
        }

        private void btnUpdateKaryawan_Click(object sender, EventArgs e)
        {
            UpdateKaryawan upKar = new UpdateKaryawan();
            upKar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteKaryawan delKar = new DeleteKaryawan();
            delKar.Show();
        }
    }
}
