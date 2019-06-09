namespace stokTakip
{
    partial class UrunSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSatis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_urun_cins = new System.Windows.Forms.TextBox();
            this.tutar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_urun_fiyat = new System.Windows.Forms.TextBox();
            this.text_urun_adi = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adetTakip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datagrid_veriler = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_satis_adedi = new System.Windows.Forms.TextBox();
            this.btn_sat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_veriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.text_urun_cins);
            this.groupBox1.Controls.Add(this.tutar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_urun_fiyat);
            this.groupBox1.Controls.Add(this.text_urun_adi);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adetTakip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.datagrid_veriler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_satis_adedi);
            this.groupBox1.Controls.Add(this.btn_sat);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(621, 417);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Alanı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(321, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ürün cinsi";
            // 
            // text_urun_cins
            // 
            this.text_urun_cins.Enabled = false;
            this.text_urun_cins.Font = new System.Drawing.Font("Arial", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.text_urun_cins.Location = new System.Drawing.Point(444, 97);
            this.text_urun_cins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_urun_cins.Name = "text_urun_cins";
            this.text_urun_cins.Size = new System.Drawing.Size(160, 29);
            this.text_urun_cins.TabIndex = 26;
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.tutar.Location = new System.Drawing.Point(456, 146);
            this.tutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(45, 20);
            this.tutar.TabIndex = 25;
            this.tutar.Text = "0 TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(311, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Toplam Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-4, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ürün Adı";
            // 
            // text_urun_fiyat
            // 
            this.text_urun_fiyat.Enabled = false;
            this.text_urun_fiyat.Font = new System.Drawing.Font("Arial", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.text_urun_fiyat.Location = new System.Drawing.Point(135, 137);
            this.text_urun_fiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_urun_fiyat.Name = "text_urun_fiyat";
            this.text_urun_fiyat.Size = new System.Drawing.Size(160, 29);
            this.text_urun_fiyat.TabIndex = 20;
            // 
            // text_urun_adi
            // 
            this.text_urun_adi.Enabled = false;
            this.text_urun_adi.Font = new System.Drawing.Font("Arial", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.text_urun_adi.Location = new System.Drawing.Point(135, 92);
            this.text_urun_adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_urun_adi.Name = "text_urun_adi";
            this.text_urun_adi.Size = new System.Drawing.Size(160, 29);
            this.text_urun_adi.TabIndex = 19;
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.tarih.Location = new System.Drawing.Point(131, 223);
            this.tarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(45, 20);
            this.tarih.TabIndex = 18;
            this.tarih.Text = "Hata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(60, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tarih";
            // 
            // adetTakip
            // 
            this.adetTakip.AutoSize = true;
            this.adetTakip.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.adetTakip.Location = new System.Drawing.Point(131, 187);
            this.adetTakip.Name = "adetTakip";
            this.adetTakip.Size = new System.Drawing.Size(54, 20);
            this.adetTakip.TabIndex = 16;
            this.adetTakip.Text = "Bitti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-3, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Güncel adet";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 27);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // datagrid_veriler
            // 
            this.datagrid_veriler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid_veriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_veriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_veriler.Location = new System.Drawing.Point(0, 262);
            this.datagrid_veriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid_veriler.Name = "datagrid_veriler";
            this.datagrid_veriler.RowHeadersWidth = 51;
            this.datagrid_veriler.RowTemplate.Height = 24;
            this.datagrid_veriler.Size = new System.Drawing.Size(621, 150);
            this.datagrid_veriler.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(311, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Satış adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Kodu";
            // 
            // text_satis_adedi
            // 
            this.text_satis_adedi.Font = new System.Drawing.Font("Arial", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.text_satis_adedi.Location = new System.Drawing.Point(444, 46);
            this.text_satis_adedi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_satis_adedi.Name = "text_satis_adedi";
            this.text_satis_adedi.Size = new System.Drawing.Size(160, 29);
            this.text_satis_adedi.TabIndex = 5;
            this.text_satis_adedi.TextChanged += new System.EventHandler(this.Text_satis_adedi_TextChanged);
            // 
            // btn_sat
            // 
            this.btn_sat.Location = new System.Drawing.Point(467, 199);
            this.btn_sat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.Size = new System.Drawing.Size(139, 44);
            this.btn_sat.TabIndex = 0;
            this.btn_sat.Text = "Sat";
            this.btn_sat.UseVisualStyleBackColor = true;
            this.btn_sat.Click += new System.EventHandler(this.Btn_sat_Click);
            // 
            // UrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 436);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UrunSatis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunSatis_FormClosed);
            this.Load += new System.EventHandler(this.UrunSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_veriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagrid_veriler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_satis_adedi;
        private System.Windows.Forms.Button btn_sat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label adetTakip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_urun_fiyat;
        private System.Windows.Forms.TextBox text_urun_adi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_urun_cins;
    }
}