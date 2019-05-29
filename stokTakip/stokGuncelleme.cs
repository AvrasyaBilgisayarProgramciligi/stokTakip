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
    public partial class stokGuncelleme : Form
    {
        Form1 form1 = new Form1();
        public stokGuncelleme(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void StokGuncelleme_Load(object sender, EventArgs e)
        {
            stokSorgu();
        }

        private void Txt_urun_cinsi_MouseMove(object sender, MouseEventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM cins", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                string cins = oku["urunCins"].ToString();

                if (txt_urun_cinsi.Items.Contains(cins))
                {
                    continue;
                }
                else
                {
                    txt_urun_cinsi.Items.Add(cins);
                }
            }
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
            datagrid_veriler.DataSource = goster.Tables["stok"];
            getir.Dispose();
            baglan.Close();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand("UPDATE stok SET [urunKodu]=@urunKodu, [urunAdı]=@urunAdı, [urunFiyatı]=@urunFiyatı, [urunCinsi]=@urunCinsi, [urunAdedi]=@urunAdedi WHERE [urunKodu]=@urunKodu", baglanti);
            guncelle.Parameters.AddWithValue("@urunKodu", text_urun_kodu.Text);
            guncelle.Parameters.AddWithValue("@urunAdı", text_urun_adi.Text);
            guncelle.Parameters.AddWithValue("@urunFiyatı", text_urun_fiyat.Text);
            guncelle.Parameters.AddWithValue("@urunCinsi", txt_urun_cinsi.Text);
            guncelle.Parameters.AddWithValue("@urunAdedi", text_urun_adedi.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            baglanti.Close();
            stokSorgu();
        }

        private void Datagrid_veriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = datagrid_veriler.SelectedCells[0].RowIndex;
            text_urun_kodu.Text = datagrid_veriler.Rows[secili].Cells[1].Value.ToString();
            text_urun_adi.Text = datagrid_veriler.Rows[secili].Cells[2].Value.ToString();
            text_urun_fiyat.Text = datagrid_veriler.Rows[secili].Cells[3].Value.ToString();
            txt_urun_cinsi.Text = datagrid_veriler.Rows[secili].Cells[4].Value.ToString();
            text_urun_adedi.Text = datagrid_veriler.Rows[secili].Cells[5].Value.ToString();
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

        private void StokGuncelleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            guncelle();
        }
    }
}
