using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class loginForm : Form
    {
        koneksi Konn = new koneksi();
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "KodeKaryawan", "Password" };
            string[] value = {tbName.Text, tbPwd.Text};
            if (koneksi.validate("tblkaryawan", namaKolom, value))
            {
                MessageBox.Show("Selamat datang kembali, " +tbName.Text+"", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.menu.menuLogin.Enabled = false;
                mainForm.menu.menuLogout.Enabled = true;
                mainForm.menu.menuLaporan.Enabled = true;
                mainForm.menu.menuMaster.Enabled = true;
                mainForm.menu.menuTransaksi.Enabled = true;
                mainForm.menu.menuUtility.Enabled = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kode atau Password yang anda masukan belum tepat, Silakan masukan ulang", "Login Gagal", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
