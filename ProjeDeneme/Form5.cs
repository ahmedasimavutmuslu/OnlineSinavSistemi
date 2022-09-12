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
    public partial class frmOnlineSinavSistemi : Form
    {
        ogrenci yeniOgrenci = new ogrenci();
        string secilenDers=null;
        public frmOnlineSinavSistemi(ogrenci ogrenci)
        {
            InitializeComponent();
            yeniOgrenci = ogrenci;
            buttonSinavBaslat.Hide();
            buttonGeriDon.Hide();
            dataGridViewSinavListesi.Hide();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void soruEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmOnlineSinavSistemi_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonDersSec_Click(object sender, EventArgs e)
        {
            //ders secimi yapılıyor
            if(radioButtonNDP.Checked)
            {
                secilenDers = "NDP";
            }
            else if(radioButtonPDP.Checked)
            {
                secilenDers = "PDP";
            }
            else if(radioButtonSayisalAnaliz.Checked)
            {
                secilenDers = "Sayısal Analiz";
            }
            else
            {
                MessageBox.Show("Bir ders seçimi yapmak zorundasınız!", "Ders Seçimi Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            groupBoxDersSecimi.Hide();
            buttonGeriDon.Show();
            buttonSinavBaslat.Show();
            dataGridViewSinavListesi.Show();

            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select testid, testadi, sinavtarihi from test where '"+yeniOgrenci.TcKimlikNo+"' = ANY(ogrenciler) AND ders='"+secilenDers+"'",baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridViewSinavListesi.DataSource = dataSet.Tables[0];
            dataGridViewSinavListesi.Columns[0].Visible = false; //testid gozukmesin diye yapiyoruz  // cell sayısı bununla etklenmiyor 0=testid, 1=testadi, 2=sinavtarihi
            //MessageBox.Show(dataGridViewSinavListesi.Rows[0].Cells[0].Value.ToString());


            baglanti.Close();

        }

        private void groupBoxDersSecimi_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewSinavListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            groupBoxDersSecimi.Show();
            buttonGeriDon.Hide();
            buttonSinavBaslat.Hide();
        }

        private void buttonSinavBaslat_Click(object sender, EventArgs e)
        {
            DateTime sinavTarihi = DateTime.Parse(dataGridViewSinavListesi.CurrentRow.Cells[2].Value.ToString());
            string testid = dataGridViewSinavListesi.CurrentRow.Cells[0].Value.ToString();


            if (sinavTarihi<DateTime.Today.Date)
            {
                MessageBox.Show("Sınava son giriş tarihini kaçırdınız!", "Sınava Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Sınava giriş başarılı", "Sınava Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOgrenciSinav frmOgrenciSinav = new frmOgrenciSinav(yeniOgrenci,testid);
                this.Hide();
                frmOgrenciSinav.Show();

            }
        }
    }
}
