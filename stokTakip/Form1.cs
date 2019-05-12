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

        private void günlükRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gunlukRaporlama ar = new gunlukRaporlama();
            ar.ShowDialog();
        }

        private void aylıkRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aylıkRaporlama ar = new aylıkRaporlama();
            ar.ShowDialog();
        }

        private void senelikRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            senelikRaporlama ar = new senelikRaporlama();
            ar.ShowDialog();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukStokMail gsm = new GunlukStokMail();
            gsm.ShowDialog();
        }

        private void günlükSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            günlükSatısMail gm = new günlükSatısMail();
            gm.ShowDialog();
        }

        private void aylıkSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aylıkSatısMail gm = new aylıkSatısMail();
            gm.ShowDialog();
        }

        private void senelikSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            senelikSatısMail gm = new senelikSatısMail();
            gm.ShowDialog();
        }

        private void aylıkStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AylıkStokMail asm = new AylıkStokMail();
            asm.ShowDialog();
        }

        private void senelikStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SenelikStokMail ssm = new SenelikStokMail();
            ssm.ShowDialog();
        }

        private void adminŞifreAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Sifre asi = new Admin_Sifre();
            asi.ShowDialog();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreİslemleri si = new sifreİslemleri();
            si.ShowDialog();
        }

        private void mailİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailBilgileri mb = new mailBilgileri();
            mb.ShowDialog();
        }
    }
}
