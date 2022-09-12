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
using Npgsql;
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
   




    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");
        }

        public static void TestConnection()
        {
            using (NpgsqlConnection baglanti = GetConnection())
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarılı!", "Veritabanı Bağlantısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Veritabanı Bağlantısı Başarısız!", "Veritabanı Bağlantısı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                baglanti.Close();
            }
        }


        private void FrmGiris_Load(object sender, EventArgs e)
        {
            // NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");
            TestConnection();

        }

        private void bttnOgretmenGiris_Click(object sender, EventArgs e)
        {
            frmGirisBilgiOgretmen frmgirisbilgi = new frmGirisBilgiOgretmen();
            frmgirisbilgi.Show();
            this.Hide();
        }

        private void bttnOgrenciGiris_Click(object sender, EventArgs e)
        {
            frmGirisBilgiOgrenci frmGirisBilgiOgrenci = new frmGirisBilgiOgrenci();
            frmGirisBilgiOgrenci.Show();
            this.Hide();
        }
    }
}
