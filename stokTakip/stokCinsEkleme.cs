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
    public partial class stokCinsEkleme : Form
    {
        public stokCinsEkleme()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stokTakip.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO cins ([urunCins]) VALUES (@urunCins)", baglanti);
            komut.Parameters.AddWithValue("@urunCins", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Urun cinsi ekleme başarılı");
            baglanti.Close();
            this.Close();
        }
    }
}
