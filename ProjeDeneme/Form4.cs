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
    public partial class frmGirisBilgiOgrenci : Form
    {
        public frmGirisBilgiOgrenci()
        {
            InitializeComponent();
        }

        private void bttnSifremiUnuttumOgrenci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen gerekli birimlerle iletişime geçin! \nUygulama kapatılıyor!", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");

        private void bttnGirisYapOgrenci_Click(object sender, EventArgs e)
        {

            
            
            baglanti.Open();
            NpgsqlCommand girisKontrol = new NpgsqlCommand("select * from ogrenci where tckimlikno=@p1 and sifre=@p2", baglanti);
            girisKontrol.Parameters.AddWithValue("@p1", textBoxtcKimlikOgrenci.Text);
            girisKontrol.Parameters.AddWithValue("@p2", textBoxSifreOgrenci.Text);
            NpgsqlDataReader da = girisKontrol.ExecuteReader();

            if (da.Read())
            {
                ogrenci ogrenci1 = new ogrenci(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(),da.GetValue(3).ToString());
                MessageBox.Show("Online Sınav Sistemine Giriş Başarılı!", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOnlineSinavSistemi frmOnlineSinavSistemi = new frmOnlineSinavSistemi(ogrenci1);
                frmOnlineSinavSistemi.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("TC Kimlik numarası veya şifre hatalı!", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            baglanti.Close();

           
        }
    }
}
