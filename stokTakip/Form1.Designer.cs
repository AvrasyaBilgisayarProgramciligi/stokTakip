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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGrişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokTemizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailSistemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // stokMenüsüToolStripMenuItem
            // 
            this.stokMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGrişToolStripMenuItem,
            this.stokGüncellemeToolStripMenuItem,
            this.stokTemizlemeToolStripMenuItem,
            this.stokBilgileriToolStripMenuItem});
            this.stokMenüsüToolStripMenuItem.Image = global::stokTakip.Properties.Resources.iconfinder_folder_add_85072;
            this.stokMenüsüToolStripMenuItem.Name = "stokMenüsüToolStripMenuItem";
            this.stokMenüsüToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.stokMenüsüToolStripMenuItem.Text = "Stok Menüsü";
            // 
            // stokGrişToolStripMenuItem
            // 
            this.stokGrişToolStripMenuItem.Name = "stokGrişToolStripMenuItem";
            this.stokGrişToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokGrişToolStripMenuItem.Text = "Stok Giriş";
            // 
            // stokGüncellemeToolStripMenuItem
            // 
            this.stokGüncellemeToolStripMenuItem.Name = "stokGüncellemeToolStripMenuItem";
            this.stokGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokGüncellemeToolStripMenuItem.Text = "Stok Güncelleme";
            // 
            // stokTemizlemeToolStripMenuItem
            // 
            this.stokTemizlemeToolStripMenuItem.Name = "stokTemizlemeToolStripMenuItem";
            this.stokTemizlemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokTemizlemeToolStripMenuItem.Text = "Stok Temizleme";
            // 
            // stokBilgileriToolStripMenuItem
            // 
            this.stokBilgileriToolStripMenuItem.Name = "stokBilgileriToolStripMenuItem";
            this.stokBilgileriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stokBilgileriToolStripMenuItem.Text = "Stok Bilgileri";
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükRaporlamaToolStripMenuItem,
            this.aylıkRaporlamaToolStripMenuItem,
            this.senelikRaporlamaToolStripMenuItem});
            this.raporlamaToolStripMenuItem.Image = global::stokTakip.Properties.Resources.iconfinder_curvechart_85068;
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // günlükRaporlamaToolStripMenuItem
            // 
            this.günlükRaporlamaToolStripMenuItem.Name = "günlükRaporlamaToolStripMenuItem";
            this.günlükRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.günlükRaporlamaToolStripMenuItem.Text = "Günlük Raporlama";
            // 
            // aylıkRaporlamaToolStripMenuItem
            // 
            this.aylıkRaporlamaToolStripMenuItem.Name = "aylıkRaporlamaToolStripMenuItem";
            this.aylıkRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.aylıkRaporlamaToolStripMenuItem.Text = "Aylık Raporlama";
            // 
            // senelikRaporlamaToolStripMenuItem
            // 
            this.senelikRaporlamaToolStripMenuItem.Name = "senelikRaporlamaToolStripMenuItem";
            this.senelikRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.senelikRaporlamaToolStripMenuItem.Text = "Senelik Raporlama";
            // 
            // mailSistemiToolStripMenuItem
            // 
            this.mailSistemiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem});
            this.mailSistemiToolStripMenuItem.Image = global::stokTakip.Properties.Resources.iconfinder_mail_84741;
            this.mailSistemiToolStripMenuItem.Name = "mailSistemiToolStripMenuItem";
            this.mailSistemiToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mailSistemiToolStripMenuItem.Text = "Mail Sistemi";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.gToolStripMenuItem.Text = "g";
            // 
            // yedeklemeToolStripMenuItem
            // 
            this.yedeklemeToolStripMenuItem.Image = global::stokTakip.Properties.Resources.iconfinder_save_84879;
            this.yedeklemeToolStripMenuItem.Name = "yedeklemeToolStripMenuItem";
            this.yedeklemeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.yedeklemeToolStripMenuItem.Text = "Yedekleme";
            // 
            // adminPaneliToolStripMenuItem
            // 
            this.adminPaneliToolStripMenuItem.Image = global::stokTakip.Properties.Resources.iconfinder_user_blue_85093;
            this.adminPaneliToolStripMenuItem.Name = "adminPaneliToolStripMenuItem";
            this.adminPaneliToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.adminPaneliToolStripMenuItem.Text = "Admin Paneli ";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::stokTakip.Properties.Resources.iconfinder_delete_84529;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

