namespace stokTakip
{
    partial class stokGuncelleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokGuncelleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_urun_cinsi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_urun_adedi = new System.Windows.Forms.TextBox();
            this.text_urun_fiyat = new System.Windows.Forms.TextBox();
            this.text_urun_adi = new System.Windows.Forms.TextBox();
            this.text_urun_kodu = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.datagrid_veriler = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_veriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagrid_veriler);
            this.groupBox1.Controls.Add(this.txt_urun_cinsi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_urun_adedi);
            this.groupBox1.Controls.Add(this.text_urun_fiyat);
            this.groupBox1.Controls.Add(this.text_urun_adi);
            this.groupBox1.Controls.Add(this.text_urun_kodu);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Güncelleme Alanı";
            // 
            // txt_urun_cinsi
            // 
            this.txt_urun_cinsi.FormattingEnabled = true;
            this.txt_urun_cinsi.Location = new System.Drawing.Point(462, 58);
            this.txt_urun_cinsi.Name = "txt_urun_cinsi";
            this.txt_urun_cinsi.Size = new System.Drawing.Size(139, 27);
            this.txt_urun_cinsi.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(327, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(329, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Cinsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Kodu";
            // 
            // text_urun_adedi
            // 
            this.text_urun_adedi.Location = new System.Drawing.Point(462, 113);
            this.text_urun_adedi.Name = "text_urun_adedi";
            this.text_urun_adedi.Size = new System.Drawing.Size(139, 27);
            this.text_urun_adedi.TabIndex = 5;
            // 
            // text_urun_fiyat
            // 
            this.text_urun_fiyat.Location = new System.Drawing.Point(143, 178);
            this.text_urun_fiyat.Name = "text_urun_fiyat";
            this.text_urun_fiyat.Size = new System.Drawing.Size(139, 27);
            this.text_urun_fiyat.TabIndex = 3;
            // 
            // text_urun_adi
            // 
            this.text_urun_adi.Location = new System.Drawing.Point(143, 114);
            this.text_urun_adi.Name = "text_urun_adi";
            this.text_urun_adi.Size = new System.Drawing.Size(139, 27);
            this.text_urun_adi.TabIndex = 2;
            // 
            // text_urun_kodu
            // 
            this.text_urun_kodu.Location = new System.Drawing.Point(143, 50);
            this.text_urun_kodu.Name = "text_urun_kodu";
            this.text_urun_kodu.Size = new System.Drawing.Size(139, 27);
            this.text_urun_kodu.TabIndex = 1;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(462, 178);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(139, 44);
            this.btn_guncelle.TabIndex = 0;
            this.btn_guncelle.Text = "Güncelle";
            this.toolTip1.SetToolTip(this.btn_guncelle, "Lütfen Güncellemek İçin Tıklayınız");
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // datagrid_veriler
            // 
            this.datagrid_veriler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid_veriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_veriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_veriler.Location = new System.Drawing.Point(12, 242);
            this.datagrid_veriler.Name = "datagrid_veriler";
            this.datagrid_veriler.RowTemplate.Height = 24;
            this.datagrid_veriler.Size = new System.Drawing.Size(589, 203);
            this.datagrid_veriler.TabIndex = 13;
            // 
            // stokGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 435);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stokGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Güncelleme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_veriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_urun_cinsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_urun_adedi;
        private System.Windows.Forms.TextBox text_urun_fiyat;
        private System.Windows.Forms.TextBox text_urun_adi;
        private System.Windows.Forms.TextBox text_urun_kodu;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.DataGridView datagrid_veriler;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}