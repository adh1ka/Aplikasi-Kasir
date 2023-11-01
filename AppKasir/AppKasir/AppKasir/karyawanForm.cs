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
    public partial class karyawanForm : Form
    {
        public karyawanForm()
        {
            InitializeComponent();
        }

        koneksi Konn = new koneksi();

        void Clear()
        {
            tbKodeK.Text = string.Empty;
            tbNamaK.Text = string.Empty;
            tbPwK.Text = string.Empty;
            tbJbt.Text = string.Empty;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbKodeK.Text == "" || tbNamaK.Text == "" || tbPwK.Text == "" || tbJbt.Text == "")
            {
                MessageBox.Show("Harap masukkan data terlebih dahulu", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    string[] namaKolom = { "KodeKaryawan", "Nama", "Password", "Jabatan"};
                    string[] value = { tbKodeK.Text, tbNamaK.Text, tbPwK.Text, tbJbt.Text};
                    koneksi.insert("tblkaryawan", namaKolom, value);
                    koneksi.Tampil("tblkaryawan", namaKolom, dataGridView1);
                    MessageBox.Show("Data dengan kode " + tbKodeK.Text + " berhasil diinsert!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "KodeKaryawan", "Nama", "Jabatan" };
            string[] value = {tbKodeK.Text, tbNamaK.Text, tbJbt.Text };

            if ( koneksi.getID("tblkaryawan", namaKolom, value) == 0)
            {
                MessageBox.Show("Harap pilih data terlebih dahulu!", "Delete Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try 
                    {
                        string [] nk = { "KodeKaryawan", "Nama", "Password", "Jabatan" };
                        koneksi.delete("tblkaryawan", koneksi.getID("tblkaryawan", namaKolom, value));
                        koneksi.Tampil("tblKaryawan", nk, dataGridView1);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] namaKolom = { "KodeKaryawan", "Nama", "Password", "Jabatan" };
                string[] value = {tbKodeK.Text, tbNamaK.Text, tbPwK.Text, tbJbt.Text};
                string[] nk = { "KodeKaryawan", "Nama", "Jabatan" };
                koneksi.update("tblkaryawan", namaKolom, value,koneksi.getID("tblkaryawan", nk, v));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void karyawanForm_Load(object sender, EventArgs e)
        {
            string[] namaKolom = { "KodeKaryawan", "Nama", "Jabatan" };
            koneksi.Tampil("tblkaryawan", namaKolom, dataGridView1);
        }

        public string[] v;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            Array.Resize(ref v, 0);
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbKodeK.Text = row.Cells[0].Value.ToString();
                tbNamaK.Text = row.Cells[1].Value.ToString();
                tbJbt.Text = row.Cells[2].Value.ToString();
                Array.Resize(ref v, 3);
                v[0] = tbKodeK.Text;
                v[1] = tbNamaK.Text;
                v[2] = tbJbt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
