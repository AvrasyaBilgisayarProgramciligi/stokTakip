using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            stokGiris sg = new stokGiris();
            sg.ShowDialog();
        }

        private void stokGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokGuncelleme sg = new stokGuncelleme();
            sg.ShowDialog();
        }

        private void stokTemizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokTemizleme sg = new stokTemizleme();
            sg.ShowDialog();
        }
    }
}
