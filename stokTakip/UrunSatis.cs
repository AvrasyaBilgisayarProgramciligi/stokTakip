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
    public partial class UrunSatis : Form
    {
        Form1 form1;
        public UrunSatis(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            stokSorgu();
            urunKoduGetir();
            tarihFonk();
            comboBox1.SelectedIndex = 0;
        }

        private void stokSorgu()
        {
            string sorgu, baglanti;
            baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb";
            sorgu = "SELECT * FROM satis";
            OleDbConnection baglan = new OleDbConnection(baglanti);
            OleDbDataAdapter getir = new OleDbDataAdapter(sorgu, baglan);
            baglan.Open();
            DataSet goster = new DataSet();
            getir.Fill(goster, "satis");
            datagrid_veriler.DataSource = goster.Tables["satis"];
            getir.Dispose();
            baglan.Close();
        }

        private void urunKoduGetir()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT urunKodu FROM stok", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string kontrol = oku["urunKodu"].ToString();
                if (comboBox1.Items.Contains(kontrol))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(oku["urunKodu"].ToString());
                }
            }
            baglanti.Close();
        }

        private void tarihFonk()
        {
            if (DateTime.Now.Month > 10)
            {
                tarih.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
            }
            else
            {
                tarih.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
            }

        }

        private void Btn_sat_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt16(adetTakip.Text) < Convert.ToInt16(text_satis_adedi.Text))
            {
                MessageBox.Show("Stok da bu kadar mal bulunmamakta");
                return;
            }

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand sat = new OleDbCommand("INSERT INTO satis ([urunKodu], [urunAdı], [toplamFiyat], [urunCinsi], [satisAdedi], [satisTarih]) VALUES (@urunKodu, @urunAdı, @toplamFiyat, @urunCinsi, @satisAdedi, @satisTarih)", baglanti);
            sat.Parameters.AddWithValue("@urunKodu", comboBox1.Text);
            sat.Parameters.AddWithValue("@urunAdı", text_urun_adi.Text);
            sat.Parameters.AddWithValue("@toplamFiyat", tutar.Text);
            sat.Parameters.AddWithValue("@urunCinsi", text_urun_cins.Text);
            sat.Parameters.AddWithValue("@satisAdedi", text_satis_adedi.Text);
            sat.Parameters.AddWithValue("@satisTarih", tarih.Text);
            sat.ExecuteNonQuery();
            MessageBox.Show("Satış Başarılı");
            baglanti.Close();

            int result = 0;
            int adetTakips = 0;
            int satilan = 0;
            string str = null;

            if (int.TryParse(adetTakip.Text, out result) && int.TryParse(text_satis_adedi.Text, out result))
            {
                adetTakips = int.Parse(adetTakip.Text);
                satilan = int.Parse(text_satis_adedi.Text);
                str = string.Concat(adetTakips - satilan);
            }

            OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti2.Open();
            OleDbCommand guncelle = new OleDbCommand("UPDATE stok SET [urunKodu]=@urunKodu, [urunAdedi]=@urunAdedi WHERE [urunKodu]=@urunKodu", baglanti2);
            guncelle.Parameters.AddWithValue("@urunKodu", comboBox1.Text);
            guncelle.Parameters.AddWithValue("urunAdedi", str);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayitlar Guncellendi");
            stokSorgu();
            adetTakip.Text = str;
            baglanti2.Close();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM stok WHERE [urunKodu]=@urunKodu", baglanti);
            komut.Parameters.AddWithValue("@urunKodu", comboBox1.GetItemText(comboBox1.SelectedItem));
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                text_urun_adi.Text = oku["urunAdı"].ToString();
                text_urun_fiyat.Text = oku["urunFiyatı"].ToString();
                adetTakip.Text = oku["urunAdedi"].ToString();
                text_urun_cins.Text = oku["urunCinsi"].ToString();

            }
            baglanti.Close();
        }

        private void Text_satis_adedi_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            int fiyat = 0;
            int adet = 0;
            if (int.TryParse(text_urun_fiyat.Text.Substring(0, text_urun_fiyat.Text.IndexOf(' ')), out result) && int.TryParse(text_satis_adedi.Text, out result))
            {
                fiyat = int.Parse(text_urun_fiyat.Text.Substring(0, text_urun_fiyat.Text.IndexOf(' ')));
                adet = int.Parse(text_satis_adedi.Text);
            }
            tutar.Text = string.Concat(fiyat * adet + " TL");
        }

        private void guncelle()
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

        private void UrunSatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            guncelle();
        }
    }
}
