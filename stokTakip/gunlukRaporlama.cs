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
    public partial class gunlukRaporlama : Form
    {
        public gunlukRaporlama()
        {
            InitializeComponent();
        }

        private void GunlukRaporlama_Load(object sender, EventArgs e)
        {
            string sorgu, baglanti;
            baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb";
            sorgu = "SELECT * FROM stok";
            OleDbConnection baglan = new OleDbConnection(baglanti);
            OleDbDataAdapter getir = new OleDbDataAdapter(sorgu, baglan);
            baglan.Open();
            DataSet goster = new DataSet();
            getir.Fill(goster, "stok");
            dataGridView1.DataSource = goster.Tables["stok"];
            getir.Dispose();
            baglan.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            OleDbDataAdapter getir = new OleDbDataAdapter("SELECT * FROM stok", baglanti);
            baglanti.Open();
            getir.SelectCommand.CommandText = "SELECT * FROM stok WHERE(urunTarih LIKE'%" + maskedTextBox1.Text + "%')";
            DataSet goster = new DataSet();
            getir.Fill(goster, "stok");
            goster.Tables["stok"].Clear();
            dataGridView1.DataSource = goster.Tables["stok"];
            getir.Fill(goster, "stok");
            getir.Dispose();
            baglanti.Close();
        }
    }
}
