namespace stokTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGrişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokTemizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokCinsiEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailSistemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokMenüsüToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.mailSistemiToolStripMenuItem,
            this.adminPaneliToolStripMenuItem,
            this.yedeklemeToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(799, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokMenüsüToolStripMenuItem
            // 
            this.stokMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGrişToolStripMenuItem,
            this.stokGüncellemeToolStripMenuItem,
            this.stokTemizlemeToolStripMenuItem,
            this.stokBilgileriToolStripMenuItem,
            this.stokCinsiEklemeToolStripMenuItem});
            this.stokMenüsüToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokMenüsüToolStripMenuItem.Image")));
            this.stokMenüsüToolStripMenuItem.Name = "stokMenüsüToolStripMenuItem";
            this.stokMenüsüToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.stokMenüsüToolStripMenuItem.Text = "Stok Menüsü";
            // 
            // stokGrişToolStripMenuItem
            // 
            this.stokGrişToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokGrişToolStripMenuItem.Image")));
            this.stokGrişToolStripMenuItem.Name = "stokGrişToolStripMenuItem";
            this.stokGrişToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokGrişToolStripMenuItem.Text = "Stok Giriş";
            this.stokGrişToolStripMenuItem.Click += new System.EventHandler(this.stokGrişToolStripMenuItem_Click);
            // 
            // stokGüncellemeToolStripMenuItem
            // 
            this.stokGüncellemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokGüncellemeToolStripMenuItem.Image")));
            this.stokGüncellemeToolStripMenuItem.Name = "stokGüncellemeToolStripMenuItem";
            this.stokGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokGüncellemeToolStripMenuItem.Text = "Stok Güncelleme";
            this.stokGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.stokGüncellemeToolStripMenuItem_Click);
            // 
            // stokTemizlemeToolStripMenuItem
            // 
            this.stokTemizlemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokTemizlemeToolStripMenuItem.Image")));
            this.stokTemizlemeToolStripMenuItem.Name = "stokTemizlemeToolStripMenuItem";
            this.stokTemizlemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokTemizlemeToolStripMenuItem.Text = "Stok Temizleme";
            this.stokTemizlemeToolStripMenuItem.Click += new System.EventHandler(this.stokTemizlemeToolStripMenuItem_Click);
            // 
            // stokBilgileriToolStripMenuItem
            // 
            this.stokBilgileriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokBilgileriToolStripMenuItem.Image")));
            this.stokBilgileriToolStripMenuItem.Name = "stokBilgileriToolStripMenuItem";
            this.stokBilgileriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokBilgileriToolStripMenuItem.Text = "Stok Bilgileri";
            // 
            // stokCinsiEklemeToolStripMenuItem
            // 
            this.stokCinsiEklemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokCinsiEklemeToolStripMenuItem.Image")));
            this.stokCinsiEklemeToolStripMenuItem.Name = "stokCinsiEklemeToolStripMenuItem";
            this.stokCinsiEklemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokCinsiEklemeToolStripMenuItem.Text = "Stok Cinsi Ekleme";
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükRaporlamaToolStripMenuItem,
            this.aylıkRaporlamaToolStripMenuItem,
            this.senelikRaporlamaToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporlamaToolStripMenuItem.Image")));
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // günlükRaporlamaToolStripMenuItem
            // 
            this.günlükRaporlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("günlükRaporlamaToolStripMenuItem.Image")));
            this.günlükRaporlamaToolStripMenuItem.Name = "günlükRaporlamaToolStripMenuItem";
            this.günlükRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.günlükRaporlamaToolStripMenuItem.Text = "Günlük Raporlama";
            this.günlükRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.günlükRaporlamaToolStripMenuItem_Click);
            // 
            // aylıkRaporlamaToolStripMenuItem
            // 
            this.aylıkRaporlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aylıkRaporlamaToolStripMenuItem.Image")));
            this.aylıkRaporlamaToolStripMenuItem.Name = "aylıkRaporlamaToolStripMenuItem";
            this.aylıkRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aylıkRaporlamaToolStripMenuItem.Text = "Aylık Raporlama";
            this.aylıkRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.aylıkRaporlamaToolStripMenuItem_Click);
            // 
            // senelikRaporlamaToolStripMenuItem
            // 
            this.senelikRaporlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("senelikRaporlamaToolStripMenuItem.Image")));
            this.senelikRaporlamaToolStripMenuItem.Name = "senelikRaporlamaToolStripMenuItem";
            this.senelikRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.senelikRaporlamaToolStripMenuItem.Text = "Senelik Raporlama";
            this.senelikRaporlamaToolStripMenuItem.Click += new System.EventHandler(this.senelikRaporlamaToolStripMenuItem_Click);
            // 
            // mailSistemiToolStripMenuItem
            // 
            this.mailSistemiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.aylıkStokToolStripMenuItem,
            this.senelikStokToolStripMenuItem,
            this.günlükSatışToolStripMenuItem,
            this.aylıkSatışToolStripMenuItem,
            this.senelikSatışToolStripMenuItem});
            this.mailSistemiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mailSistemiToolStripMenuItem.Image")));
            this.mailSistemiToolStripMenuItem.Name = "mailSistemiToolStripMenuItem";
            this.mailSistemiToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mailSistemiToolStripMenuItem.Text = "Mail Sistemi";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gToolStripMenuItem.Image")));
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gToolStripMenuItem.Text = "Günlük Stok";
            // 
            // aylıkStokToolStripMenuItem
            // 
            this.aylıkStokToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aylıkStokToolStripMenuItem.Image")));
            this.aylıkStokToolStripMenuItem.Name = "aylıkStokToolStripMenuItem";
            this.aylıkStokToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aylıkStokToolStripMenuItem.Text = "Aylık Stok";
            // 
            // senelikStokToolStripMenuItem
            // 
            this.senelikStokToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("senelikStokToolStripMenuItem.Image")));
            this.senelikStokToolStripMenuItem.Name = "senelikStokToolStripMenuItem";
            this.senelikStokToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.senelikStokToolStripMenuItem.Text = "Senelik Stok";
            // 
            // günlükSatışToolStripMenuItem
            // 
            this.günlükSatışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("günlükSatışToolStripMenuItem.Image")));
            this.günlükSatışToolStripMenuItem.Name = "günlükSatışToolStripMenuItem";
            this.günlükSatışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.günlükSatışToolStripMenuItem.Text = "Günlük Satış";
            // 
            // aylıkSatışToolStripMenuItem
            // 
            this.aylıkSatışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aylıkSatışToolStripMenuItem.Image")));
            this.aylıkSatışToolStripMenuItem.Name = "aylıkSatışToolStripMenuItem";
            this.aylıkSatışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aylıkSatışToolStripMenuItem.Text = "Aylık Satış";
            // 
            // senelikSatışToolStripMenuItem
            // 
            this.senelikSatışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("senelikSatışToolStripMenuItem.Image")));
            this.senelikSatışToolStripMenuItem.Name = "senelikSatışToolStripMenuItem";
            this.senelikSatışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.senelikSatışToolStripMenuItem.Text = "Senelik Satış";
            // 
            // adminPaneliToolStripMenuItem
            // 
            this.adminPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıAtaToolStripMenuItem,
            this.şifreİşlemleriToolStripMenuItem,
            this.mailİşlemleriToolStripMenuItem});
            this.adminPaneliToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminPaneliToolStripMenuItem.Image")));
            this.adminPaneliToolStripMenuItem.Name = "adminPaneliToolStripMenuItem";
            this.adminPaneliToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.adminPaneliToolStripMenuItem.Text = "Admin Paneli";
            // 
            // kullanıcıAtaToolStripMenuItem
            // 
            this.kullanıcıAtaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıAtaToolStripMenuItem.Image")));
            this.kullanıcıAtaToolStripMenuItem.Name = "kullanıcıAtaToolStripMenuItem";
            this.kullanıcıAtaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kullanıcıAtaToolStripMenuItem.Text = "Kullanıcı Ata";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreİşlemleriToolStripMenuItem.Image")));
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            // 
            // mailİşlemleriToolStripMenuItem
            // 
            this.mailİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mailİşlemleriToolStripMenuItem.Image")));
            this.mailİşlemleriToolStripMenuItem.Name = "mailİşlemleriToolStripMenuItem";
            this.mailİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mailİşlemleriToolStripMenuItem.Text = "Mail Bilgileri";
            // 
            // yedeklemeToolStripMenuItem
            // 
            this.yedeklemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yedeklemeToolStripMenuItem.Image")));
            this.yedeklemeToolStripMenuItem.Name = "yedeklemeToolStripMenuItem";
            this.yedeklemeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.yedeklemeToolStripMenuItem.Text = "Yedekleme";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripMenuItem.Image")));
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(799, 410);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGrişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokTemizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükRaporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelikRaporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailSistemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedeklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokCinsiEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelikStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelikSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailİşlemleriToolStripMenuItem;
    }
}

