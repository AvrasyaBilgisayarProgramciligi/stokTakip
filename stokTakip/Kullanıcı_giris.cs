using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip
{
    public partial class Kullanıcı_giris : Form
    {
        public Kullanıcı_giris()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=  Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT COUNT(*) FROM giris WHERE [kAdi]= @kAdi AND [sifre]= @sifre", baglanti);
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@kAdi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            int varmi = (int)komut.ExecuteScalar();

            if (varmi > 0)
            {
                MessageBox.Show("Giriş başarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hatali kullanici adi veya sifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Clear();
                textBox2.Clear();
            }
            baglanti.Close();
        }
    }
}
