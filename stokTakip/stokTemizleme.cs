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
    public partial class stokTemizleme : Form
    {
        Form1 form1 = new Form1();
        public stokTemizleme(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void StokTemizleme_Load(object sender, EventArgs e)
        {
            stokSorgu();
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

        private void Btn_silme_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("DELETE FROM stok WHERE [urunKodu]=@urunKodu", baglanti);
            sil.Parameters.AddWithValue("@urunKodu", text_urun_kodu.Text);
            sil.ExecuteNonQuery();
            sil.Dispose();
            MessageBox.Show("Kayıt Silindi");
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

        private void StokTemizleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            guncelle();
        }
    }
}
