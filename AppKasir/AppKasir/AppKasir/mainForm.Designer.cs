namespace AppKasir
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.lapDataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.gantiPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMaster,
            this.menuTransaksi,
            this.menuLaporan,
            this.menuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1787, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogout,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(224, 26);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(224, 26);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(224, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuMaster
            // 
            this.menuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karyawanToolStripMenuItem,
            this.barangToolStripMenuItem});
            this.menuMaster.Name = "menuMaster";
            this.menuMaster.Size = new System.Drawing.Size(68, 24);
            this.menuMaster.Text = "Master";
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            this.karyawanToolStripMenuItem.Click += new System.EventHandler(this.karyawanToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // menuTransaksi
            // 
            this.menuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanToolStripMenuItem});
            this.menuTransaksi.Name = "menuTransaksi";
            this.menuTransaksi.Size = new System.Drawing.Size(82, 24);
            this.menuTransaksi.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // menuLaporan
            // 
            this.menuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapDataMasterToolStripMenuItem,
            this.lapPenjualanToolStripMenuItem});
            this.menuLaporan.Name = "menuLaporan";
            this.menuLaporan.Size = new System.Drawing.Size(77, 24);
            this.menuLaporan.Text = "Laporan";
            // 
            // lapDataMasterToolStripMenuItem
            // 
            this.lapDataMasterToolStripMenuItem.Name = "lapDataMasterToolStripMenuItem";
            this.lapDataMasterToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.lapDataMasterToolStripMenuItem.Text = "Lap Data Master";
            // 
            // lapPenjualanToolStripMenuItem
            // 
            this.lapPenjualanToolStripMenuItem.Name = "lapPenjualanToolStripMenuItem";
            this.lapPenjualanToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.lapPenjualanToolStripMenuItem.Text = "Lap Penjualan";
            // 
            // menuUtility
            // 
            this.menuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gantiPasswordToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuUtility.Name = "menuUtility";
            this.menuUtility.Size = new System.Drawing.Size(62, 24);
            this.menuUtility.Text = "Utility";
            // 
            // gantiPasswordToolStripMenuItem
            // 
            this.gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            this.gantiPasswordToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 699);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Beranda";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem menuFile;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuLogout;
        public System.Windows.Forms.ToolStripMenuItem menuExit;
        public System.Windows.Forms.ToolStripMenuItem menuMaster;
        public System.Windows.Forms.ToolStripMenuItem menuTransaksi;
        public System.Windows.Forms.ToolStripMenuItem menuLaporan;
        public System.Windows.Forms.ToolStripMenuItem menuUtility;
        public System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem lapDataMasterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem lapPenjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gantiPasswordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}