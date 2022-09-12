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
using Npgsql;

namespace ProjeDeneme
{
    public partial class frmGirisBilgiOgretmen : Form
    {
        public frmGirisBilgiOgretmen()
        {
            InitializeComponent();
        }

        private void frmgirisbilgi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=5432; Database=odevdeneme1; user Id=postgres; password=onigiri801");

        private void bttnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand girisKontrol = new NpgsqlCommand("select * from ogretmen where tckimlikno=@p1 and sifre=@p2", baglanti);
            girisKontrol.Parameters.AddWithValue("@p1", textBoxtcKimlikOgretmen.Text);
            girisKontrol.Parameters.AddWithValue("@p2", textBoxSifreOgretmen.Text);
            NpgsqlDataReader da = girisKontrol.ExecuteReader();
            if(da.Read())
            {
                MessageBox.Show("Soru Ekleme Sistemine Giriş Başarılı!", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOgretmen frmOgretmen = new frmOgretmen();
                frmOgretmen.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("TC Kimlik numarası veya şifre hatalı!", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            baglanti.Close();


        }
            

        private void frmGirisBilgiOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void bttnSifremiUnuttumOgretmen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen gerekli birimlerle iletişime geçin! \nUygulama kapatılıyor!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
