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
            this.satışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokMenüsüToolStripMenuItem,
            this.satışlarToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(745, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokMenüsüToolStripMenuItem
            // 
            this.stokMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGrişToolStripMenuItem,
            this.stokGüncellemeToolStripMenuItem,
            this.stokTemizlemeToolStripMenuItem});
            this.stokMenüsüToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokMenüsüToolStripMenuItem.Image")));
            this.stokMenüsüToolStripMenuItem.Name = "stokMenüsüToolStripMenuItem";
            this.stokMenüsüToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.stokMenüsüToolStripMenuItem.Text = "Stok Menüsü";
            // 
            // stokGrişToolStripMenuItem
            // 
            this.stokGrişToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokGrişToolStripMenuItem.Image")));
            this.stokGrişToolStripMenuItem.Name = "stokGrişToolStripMenuItem";
            this.stokGrişToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.stokGrişToolStripMenuItem.Text = "Stok Giriş";
            this.stokGrişToolStripMenuItem.Click += new System.EventHandler(this.stokGrişToolStripMenuItem_Click);
            // 
            // stokGüncellemeToolStripMenuItem
            // 
            this.stokGüncellemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokGüncellemeToolStripMenuItem.Image")));
            this.stokGüncellemeToolStripMenuItem.Name = "stokGüncellemeToolStripMenuItem";
            this.stokGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.stokGüncellemeToolStripMenuItem.Text = "Stok Güncelleme";
            this.stokGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.stokGüncellemeToolStripMenuItem_Click);
            // 
            // stokTemizlemeToolStripMenuItem
            // 
            this.stokTemizlemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokTemizlemeToolStripMenuItem.Image")));
            this.stokTemizlemeToolStripMenuItem.Name = "stokTemizlemeToolStripMenuItem";
            this.stokTemizlemeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.stokTemizlemeToolStripMenuItem.Text = "Stok Temizleme";
            this.stokTemizlemeToolStripMenuItem.Click += new System.EventHandler(this.stokTemizlemeToolStripMenuItem_Click);
            // 
            // satışlarToolStripMenuItem
            // 
            this.satışlarToolStripMenuItem.Image = global::stokTakip.Properties.Resources.money_exchange;
            this.satışlarToolStripMenuItem.Name = "satışlarToolStripMenuItem";
            this.satışlarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.satışlarToolStripMenuItem.Text = "Satışlar";
            this.satışlarToolStripMenuItem.Click += new System.EventHandler(this.SatışlarToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporlamaToolStripMenuItem.Image")));
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.RaporlamaToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripMenuItem.Image")));
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.YazdırToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGrişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokTemizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem satışlarToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

