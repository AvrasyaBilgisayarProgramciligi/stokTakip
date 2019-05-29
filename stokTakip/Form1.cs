using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stokGrişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokGiris sg = new stokGiris(this);
            sg.ShowDialog();
        }

        private void stokGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokGuncelleme sg = new stokGuncelleme(this);
            sg.ShowDialog();
        }

        private void stokTemizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokTemizleme sg = new stokTemizleme(this);
            sg.ShowDialog();
        }
        private void RaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gunlukRaporlama ar = new gunlukRaporlama();
            ar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = goster.Tables["stok"];
            getir.Dispose();
            baglan.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SatışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSatis urun = new UrunSatis(this);
            urun.ShowDialog();
        }

        private void YazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int columnPosition = 0;
            int rowPosition = 25;

            DrawHeader(new Font(this.Font, FontStyle.Bold), e.Graphics, ref columnPosition, ref rowPosition);

            rowPosition += 35;

            DrawGridBody(e.Graphics, ref columnPosition, ref rowPosition);
        }

        private int DrawHeader(Font boldFont, Graphics g, ref int columnPosition, ref int rowPosition)
        {
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {

                g.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)rowPosition);
                columnPosition += dc.Width + 5;
            }

            return columnPosition;
        }

        private void DrawGridBody(Graphics g, ref int columnPosition, ref int rowPosition)
        {
            foreach (DataRow dr in ((DataTable)dataGridView1.DataSource).Rows)
            {
                columnPosition = 0;
                g.DrawLine(Pens.Black, new Point(0, rowPosition), new Point(this.Width, rowPosition));

                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    string text = dr[dc.DataPropertyName].ToString();
                    g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 10f);

                    columnPosition += dc.Width + 5;
                }

                rowPosition = rowPosition + 35; 
            }
        }

    }
}
