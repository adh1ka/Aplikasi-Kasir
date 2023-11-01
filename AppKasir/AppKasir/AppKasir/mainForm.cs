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
    public partial class mainForm : Form
    {
        public static mainForm menu;
        loginForm frmLogin;
        karyawanForm frmKrywn;
        void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }
        void frmKrywn_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKrywn = null;
        }
        void menuLocked()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuLaporan.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menu = this;
        }
        
        void menuUnLocked()
        {
            menuLogin.Enabled = false;
            menuLogout.Enabled = true;
            menuLaporan.Enabled = true;
            menuMaster.Enabled = true;
            menuTransaksi.Enabled = true;
            menuUtility.Enabled = true;
        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new loginForm();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin Mau Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            menuLocked();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if (menuLogout.Enabled == true)
            {
                if (MessageBox.Show("Yakin akan Logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    menuLocked();
                    MessageBox.Show("Logout Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {

                }
            }
            else
            {
               
            }
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKrywn == null)
            {
                frmKrywn = new karyawanForm();
                frmKrywn.FormClosed += new FormClosedEventHandler(frmKrywn_FormClosed);
                frmKrywn.ShowDialog();
            }
            else
            {
                frmKrywn.Activate();
            }
        }
    }
}