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
    public partial class stokGiris : Form
    {
        Form1 form1 = new Form1();
        public stokGiris(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void StokGiris_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Month > 10)
            {
                label7.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
            }
            else
            {
                label7.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokCinsEkleme sce = new stokCinsEkleme();
            sce.ShowDialog();
        }

        private void stokSorgu()
        {
            string sorgu, baglanti;
            baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb";
            sorgu = "SELECT * FROM stok";
            OleDbConnection baglan = new OleDbConnection(baglanti);
            OleDbDataAdapter getir = new OleDbDataAdapter(sorgu, baglan);
            baglan.Open();
            DataSet goster = new DataSet();
            getir.Fill(goster, "stok");
            form1.dataGridView1.DataSource = goster.Tables["stok"];
            getir.Dispose();
            baglan.Close();
        }

        private void ComboBox1_MouseMove(object sender, MouseEventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM cins", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                string cins = oku["urunCins"].ToString();

                if (comboBox1.Items.Contains(cins))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(cins);
                }
            }
            baglanti.Close();
        }

        private void Urun_kaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO stok ([urunKodu], [urunAdı], [urunFiyatı], [urunCinsi], [urunAdedi], [urunTarih]) VALUES (@urunKodu, @urunAdı, @urunFiyatı, @urunCinsi, @urunAdedi, @urunTarih)", baglanti);
            komut.Parameters.AddWithValue("@urunKodu", textBox1.Text);
            komut.Parameters.AddWithValue("@urunAdı", textBox2.Text);
            if(textBox3.Text.IndexOf(' ') >= 1)
            {
                MessageBox.Show("Lütfen fiyat kısmında boşluk bırakmayınız veya birim girmeyiniz. Birim otomatik olarak eklenir!", "Hatalı fiyat girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            komut.Parameters.AddWithValue("@urunFiyatı", textBox3.Text + " TL");
            komut.Parameters.AddWithValue("@urunCinsi", comboBox1.Text);
            komut.Parameters.AddWithValue("@urunAdedi", textBox4.Text);
            komut.Parameters.AddWithValue("@urunTarih", label7.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Stok ekleme başalrılı");
            stokSorgu();
            baglanti.Close();
            this.Close();
        }
    }
}
