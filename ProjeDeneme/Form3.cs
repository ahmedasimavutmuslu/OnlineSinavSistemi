/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE ÖDEVİ
**				ÖĞRENCİ ADI............: AHMED ASIM AVUTMUŞLU
**				ÖĞRENCİ NUMARASI.......: G211210373
**              DERSİN ALINDIĞI GRUP...: 1. ÖĞRETİM A GRUBU
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme
{
    public partial class frmOgretmen : Form
    {
        public frmOgretmen()
        {
            InitializeComponent();
        }


        private void soruEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSoruEkle frmSoruEkle = new frmSoruEkle();
            frmSoruEkle.Show();
        }

        private void soruSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSoruSil frmSoruSil = new frmSoruSil();
            frmSoruSil.Show();
        }

        private void testOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTestOlustur frmTestOlustur = new frmTestOlustur();
            frmTestOlustur.Show();
        }

        private void öğrenciSeçenekleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciIslemleri frmOgrenciIslemleri = new frmOgrenciIslemleri();
            frmOgrenciIslemleri.Show();
        }

        private void başarıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBasariGrafigi frmBasariGrafigi = new frmBasariGrafigi();
            frmBasariGrafigi.Show();
        }
    }
}
