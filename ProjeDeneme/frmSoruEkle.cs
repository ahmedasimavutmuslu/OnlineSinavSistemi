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
    public partial class frmSoruEkle : Form
    {
        public frmSoruEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");


        private void frmSoruEkle_Load(object sender, EventArgs e)
        {

        }

        private void bttnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif ; *.bmp";
            if(open.ShowDialog()==DialogResult.OK)
            {
                pictureBoxSoruResmi.Image = new Bitmap(open.FileName);
                textBoxResimYolu.Text = open.FileName;

            }


        }

        private void bttnGeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretmen frmOgretmen = new frmOgretmen();
            frmOgretmen.Show();
        }

        private void bttnSoruTemizle_Click(object sender, EventArgs e)
        {
            textBoxSoruKoku.Clear();
            pictureBoxSoruResmi.Image = null;
            textBoxSoruPuani.Clear();
            textBoxSoruZorlukSeviyesi.Clear();
            textBoxBirinciSecenek.Clear();
            textBoxIkinciSecenek.Clear();
            textBoxUcuncuSecenek.Clear();
            textBoxDorduncuSecenek.Clear();
            textBoxBesinciSecenek.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void bttnSoruEkle_Click(object sender, EventArgs e)
        {
            string soruKoku, dogruCevap, zorlukSeviye,ders;
            string[] secenekler = new string[5];
            string resimYolu;
            double puan;
            dogruCevap = "";
            soruKoku = textBoxSoruKoku.Text;
            zorlukSeviye = textBoxSoruZorlukSeviyesi.Text;
            resimYolu = textBoxResimYolu.Text;
            puan = Convert.ToDouble(textBoxSoruPuani.Text);
            if(radioButtonDersSecimiNDP.Checked) //ders seciliyor
            {
                ders = radioButtonDersSecimiNDP.Text;
            }
            else if(radioButtonDersSecimiPDP.Checked)
            {
                ders = radioButtonDersSecimiPDP.Text;

            }
            else
            {
                ders = radioButtonDersSecimiSayisalAnaliz.Text;
            }


            if (radioButton1.Checked) //dogru cevap ataması yapılıyor
            {
                dogruCevap = textBoxBirinciSecenek.Text;
            }
            else if (radioButton2.Checked)
            {
                dogruCevap = textBoxIkinciSecenek.Text;
            }
            else if (radioButton3.Checked)
            {
                dogruCevap = textBoxUcuncuSecenek.Text;
            }
            else if (radioButton4.Checked)
            {
                dogruCevap = textBoxDorduncuSecenek.Text;
            }
            else if (radioButton5.Checked)
            {
                dogruCevap = textBoxBesinciSecenek.Text;
            }

            secenekler[0] = textBoxBirinciSecenek.Text;
            secenekler[1] = textBoxIkinciSecenek.Text;
            secenekler[2] = textBoxUcuncuSecenek.Text;
            secenekler[3] = textBoxDorduncuSecenek.Text;
            secenekler[4] = textBoxBesinciSecenek.Text;


            Soru yeniSoru = new Soru(soruKoku, secenekler,dogruCevap,puan,resimYolu,ders);

            baglanti.Open();

            NpgsqlCommand komut = new NpgsqlCommand("insert into soru (puan,sorukoku,secenekler,dogrucevap,resimyolu,ders) values (@p1,@p2, ARRAY[@p3,@p4,@p5,@p6,@p7],@p8,@p9,@p10)",baglanti);
            
            komut.Parameters.AddWithValue("@p1", yeniSoru.Puan);
            komut.Parameters.AddWithValue("@p2", yeniSoru.SoruKoku);
            komut.Parameters.AddWithValue("@p3", yeniSoru.secenekler[0]);
            komut.Parameters.AddWithValue("@p4", yeniSoru.secenekler[1]);
            komut.Parameters.AddWithValue("@p5", yeniSoru.secenekler[2]);
            komut.Parameters.AddWithValue("@p6", yeniSoru.secenekler[3]);
            komut.Parameters.AddWithValue("@p7", yeniSoru.secenekler[4]);
            komut.Parameters.AddWithValue("@p8", yeniSoru.DogruCevap);
            komut.Parameters.AddWithValue("@p9", yeniSoru.ResimYolu);
            komut.Parameters.AddWithValue("@p10", yeniSoru.Ders);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Soru kaydı başarıyla gerçekleştirildi", "Soru Kaydı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void bttnDersSec_Click(object sender, EventArgs e)
        {
            radioButtonDersSecimiNDP.Visible = false;
            radioButtonDersSecimiPDP.Visible = false;
            radioButtonDersSecimiSayisalAnaliz.Visible = false;
            label11.Visible = false;
            bttnDersSec.Visible = false;
            panel1.SendToBack();
        }
    }
}
