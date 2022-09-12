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
    public partial class frmOgrenciIslemleri : Form
    {

        public frmOgrenciIslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");


        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            frmOgretmen frmOgretmen = new frmOgretmen();
            this.Hide();
            frmOgretmen.Show();
        }

        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ogrenci", baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridViewOgrenciListesi.DataSource = dataSet.Tables[0];
            baglanti.Close();

        }

        private void buttonOgrenciSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("delete from ogrenci where tckimlikno=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", dataGridViewOgrenciListesi.CurrentRow.Cells[2].Value.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla gerçekleştirildi!", "Öğrenci Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonOgrenciListele.PerformClick();
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            ogrenci yeniOgrenci = new ogrenci(textBoxAdi.Text, textBoxSoyadi.Text, textBoxTC.Text, textBoxSifre.Text);
            NpgsqlCommand komut = new NpgsqlCommand("insert into ogrenci (adi,soyadi,tckimlikno,sifre) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", yeniOgrenci.Adi);
            komut.Parameters.AddWithValue("@p2", yeniOgrenci.Soyadi);
            komut.Parameters.AddWithValue("@p3", yeniOgrenci.TcKimlikNo);
            komut.Parameters.AddWithValue("@p4", yeniOgrenci.Sifre);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Öğrenci kaydı başarıyla gerçekleştirildi", "Öğrenci Kaydı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonOgrenciListele.PerformClick();




        }
    }
}
