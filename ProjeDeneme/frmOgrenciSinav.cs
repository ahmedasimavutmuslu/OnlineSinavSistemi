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
    public partial class frmOgrenciSinav : Form
    {
        ogrenci sinavOgrencisi = new ogrenci();
        Test suankiTest = new Test();
        Soru suankiSoru = new Soru();
        string suankiSinavId;
        int bulunulanSoru= 0;
        List<string> soruListesi = new List<string>();
        List<string> cevapListesi = new List<string>(20);
        List<string> dogruCevapListesi = new List<string>();
        int soruSayi=0;
        string testid, sure, sorusayisi, sinavtarihi, ders, testadi;
        int saniye, dakika;

        private void buttonSinaviBitir_Click(object sender, EventArgs e)
        {
            double toplamPuan = 0;
            if (cevapListesi.Count > bulunulanSoru - 1)//son sorunun cevabını kaydediyoruz
            {
                if (radioButtonCevapBir.Checked)
                {
                    cevapListesi[bulunulanSoru - 1] = (radioButtonCevapBir.Text);

                }
                else if (radioButtonCevapIki.Checked)
                {
                    cevapListesi[bulunulanSoru - 1] = (radioButtonCevapIki.Text);
                }
                else if (radioButtonCevapUc.Checked)
                {
                    cevapListesi[bulunulanSoru - 1] = (radioButtonCevapUc.Text);
                }
                else if (radioButtonCevapDort.Checked)
                {
                    cevapListesi[bulunulanSoru - 1] = (radioButtonCevapDort.Text);
                }
                else if (radioButtonCevapBes.Checked)
                {
                    cevapListesi[bulunulanSoru - 1] = (radioButtonCevapBes.Text);
                }
                else
                {
                    cevapListesi[bulunulanSoru - 1] = ("boş");
                }
            }
            else
            {
                if (radioButtonCevapBir.Checked)
                {
                    cevapListesi.Add(radioButtonCevapBir.Text);

                }
                else if (radioButtonCevapIki.Checked)
                {
                    cevapListesi.Add(radioButtonCevapIki.Text);
                }
                else if (radioButtonCevapUc.Checked)
                {
                    cevapListesi.Add(radioButtonCevapUc.Text);
                }
                else if (radioButtonCevapDort.Checked)
                {
                    cevapListesi.Add(radioButtonCevapDort.Text);
                }
                else if (radioButtonCevapBes.Checked)
                {
                    cevapListesi.Add(radioButtonCevapBes.Text);
                }
                else
                {
                    cevapListesi.Add("boş");
                }
            }
            
            baglanti.Open();
            
            
            for (int i=0;i<cevapListesi.Count;i++)               
            {           
                if(dogruCevapListesi[i]==cevapListesi[i])               
                {               
                    NpgsqlCommand komut = new NpgsqlCommand("select puan from soru where soruid='" + soruListesi[i] + "'", baglanti);                   
                    NpgsqlDataReader dr = komut.ExecuteReader();                
                    if(dr.Read())                 
                    {                  
                        toplamPuan = toplamPuan + dr.GetDouble(0);    
                    }
                    dr.Close();
                }
                
            }
                
            baglanti.Close();
            baglanti.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("insert into sonuclar(testid,tckimlikno,toplampuan) values (@p1,@p2,@p3)", baglanti);
            komut2.Parameters.AddWithValue("@p1", testid);
            komut2.Parameters.AddWithValue("@p2", sinavOgrencisi.TcKimlikNo);
            komut2.Parameters.AddWithValue("@p3", Convert.ToString(toplamPuan));

            komut2.ExecuteNonQuery();

            baglanti.Close();

            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update test set ogrenciler = array_remove(ogrenciler,'"+sinavOgrencisi.TcKimlikNo+"') where testid='"+testid+"'", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Sınavınız tamamlanmıştır!", "Geçmiş Olsun", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmOnlineSinavSistemi frmOnlineSinavSistemi = new frmOnlineSinavSistemi(sinavOgrencisi);
            this.Close();
            frmOnlineSinavSistemi.Show();




        }

        private void timerSinavSuresi_Tick(object sender, EventArgs e)
        {
            if(saniye==0&&dakika==0)
            {
                buttonSinaviBitir.PerformClick();
            }
            if(saniye==0)
            {
                dakika--;
                saniye = 59;
            }
            textBoxGeriSayim.Text = Convert.ToString(dakika) + ":" + Convert.ToString(saniye--);

        }

        public frmOgrenciSinav(ogrenci o1, string testid)
        {
            InitializeComponent();
            sinavOgrencisi = o1;
            suankiSinavId = testid;
            groupBoxSinav.Hide();
            

        }
        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            bulunulanSoru = bulunulanSoru - 1;
            

            

            if (bulunulanSoru>=1)
            {
                if (cevapListesi.Count >= bulunulanSoru ) // yoksa cevabı kaydediyoruz
                {
                    if (radioButtonCevapBir.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapBir.Text);

                    }
                    else if (radioButtonCevapIki.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapIki.Text);
                    }
                    else if (radioButtonCevapUc.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapUc.Text);
                    }
                    else if (radioButtonCevapDort.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapDort.Text);
                    }
                    else if (radioButtonCevapBes.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapBes.Text);
                    }
                    else
                    {
                        cevapListesi.Add("boş");
                    }
                }

                if (cevapListesi.Count > bulunulanSoru)//kaydedilmiş bir cevap var mı diye bakıyoruz varsa onu gösteriyoruz
                {


                    if (cevapListesi[bulunulanSoru - 1] == radioButtonCevapBir.Text)
                    {
                        radioButtonCevapBir.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru - 1] == radioButtonCevapIki.Text)
                    {
                        radioButtonCevapIki.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru - 1] == radioButtonCevapUc.Text)
                    {
                        radioButtonCevapUc.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru - 1] == radioButtonCevapDort.Text)
                    {
                        radioButtonCevapDort.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru - 1] == radioButtonCevapBes.Text)
                    {
                        radioButtonCevapBes.Checked = true;
                    }
                    else
                    {
                        radioButtonCevapBir.Checked = false;
                        radioButtonCevapIki.Checked = false;
                        radioButtonCevapUc.Checked = false;
                        radioButtonCevapDort.Checked = false;
                        radioButtonCevapBes.Checked = false;
                    }
                
                
                }

                baglanti.Open();

                NpgsqlCommand komut2 = new NpgsqlCommand("select * from soru where soruid='" + soruListesi[bulunulanSoru-1] + "'", baglanti);
                NpgsqlDataReader dr2 = komut2.ExecuteReader();

                if (dr2.Read())
                {
                    Soru yeniSoru = new Soru(dr2.GetValue(1).ToString(), dr2.GetFieldValue<string[]>(2), dr2.GetValue(3).ToString(), (double)dr2.GetValue(4), dr2.GetValue(5).ToString(), dr2.GetValue(6).ToString());
                    suankiSoru = yeniSoru;
                    if(dogruCevapListesi[bulunulanSoru] == (suankiSoru.DogruCevap))
                    {

                    }
                    else
                    {
                        dogruCevapListesi[bulunulanSoru] = (suankiSoru.DogruCevap);
                    }
                    //bulunulanSoru++;
                }

                baglanti.Close();

                pictureBoxSoruGorsel.Image = Image.FromFile(suankiSoru.ResimYolu);
                richTextBoxSoruKoku.Text = suankiSoru.SoruKoku;
                radioButtonCevapBir.Text = suankiSoru.secenekler[0];
                radioButtonCevapIki.Text = suankiSoru.secenekler[1];
                radioButtonCevapUc.Text = suankiSoru.secenekler[2];
                radioButtonCevapDort.Text = suankiSoru.secenekler[3];
                radioButtonCevapBes.Text = suankiSoru.secenekler[4];
                labelBulunanSoru.Text = Convert.ToString(bulunulanSoru);
                labelToplamSoru.Text = Convert.ToString(sorusayisi);
            }
            else
            {
                MessageBox.Show("Önceki soru bulunmuyor!", "Önceki Soru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //bulunulanSoru++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
            

            if(bulunulanSoru+1<=Convert.ToInt32(sorusayisi))
            {
                if(cevapListesi.Count>bulunulanSoru)
                {
                    if (radioButtonCevapBir.Checked)
                    {
                        cevapListesi[bulunulanSoru-1]=(radioButtonCevapBir.Text);

                    }
                    else if (radioButtonCevapIki.Checked)
                    {
                        cevapListesi[bulunulanSoru - 1]=(radioButtonCevapIki.Text);
                    }
                    else if (radioButtonCevapUc.Checked)
                    {
                        cevapListesi[bulunulanSoru - 1] = (radioButtonCevapUc.Text);
                    }
                    else if (radioButtonCevapDort.Checked)
                    {
                        cevapListesi[bulunulanSoru - 1] = (radioButtonCevapDort.Text);
                    }
                    else if (radioButtonCevapBes.Checked)
                    {
                        cevapListesi[bulunulanSoru - 1] = (radioButtonCevapBes.Text);
                    }
                    else
                    {
                        cevapListesi[bulunulanSoru - 1] = ("boş");
                    }
                }

                if (cevapListesi.Count > bulunulanSoru)//kaydedilmiş bir cevap var mı diye bakıyoruz varsa onu gösteriyoruz
                {
                    if (cevapListesi[bulunulanSoru] == radioButtonCevapBir.Text)
                    {
                        radioButtonCevapBir.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru] == radioButtonCevapIki.Text)
                    {
                        radioButtonCevapIki.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru] == radioButtonCevapUc.Text)
                    {
                        radioButtonCevapUc.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru] == radioButtonCevapDort.Text)
                    {
                        radioButtonCevapDort.Checked = true;
                    }
                    else if (cevapListesi[bulunulanSoru] == radioButtonCevapBes.Text)
                    {
                        radioButtonCevapBes.Checked = true;
                    }
                    else
                    {
                        radioButtonCevapBir.Checked = false;
                        radioButtonCevapIki.Checked = false;
                        radioButtonCevapUc.Checked = false;
                        radioButtonCevapDort.Checked = false;
                        radioButtonCevapBes.Checked = false;
                    }
                }
                else // yoksa cevabı kaydediyoruz
                {
                    if (radioButtonCevapBir.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapBir.Text);

                    }
                    else if (radioButtonCevapIki.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapIki.Text);
                    }
                    else if (radioButtonCevapUc.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapUc.Text);
                    }
                    else if (radioButtonCevapDort.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapDort.Text);
                    }
                    else if (radioButtonCevapBes.Checked)
                    {
                        cevapListesi.Add(radioButtonCevapBes.Text);
                    }
                    else
                    {
                        cevapListesi.Add("boş");
                    }
                }



                //radioButtonCevapBir.Checked = false;
                //radioButtonCevapIki.Checked = false;
                baglanti.Open();

                NpgsqlCommand komut2 = new NpgsqlCommand("select * from soru where soruid='" + soruListesi[bulunulanSoru] + "'", baglanti);
                int kacıncısoru = bulunulanSoru + 1;
                NpgsqlDataReader dr2 = komut2.ExecuteReader();

                if (dr2.Read())
                {
                    Soru yeniSoru = new Soru(dr2.GetValue(1).ToString(), dr2.GetFieldValue<string[]>(2), dr2.GetValue(3).ToString(), (double)dr2.GetValue(4), dr2.GetValue(5).ToString(), dr2.GetValue(6).ToString());
                    suankiSoru = yeniSoru;
                    if (dogruCevapListesi[bulunulanSoru]==(suankiSoru.DogruCevap))
                    {
                        
                    }
                    else
                    {
                        dogruCevapListesi[bulunulanSoru]=(suankiSoru.DogruCevap);
                    }

                    bulunulanSoru++;
                }

                baglanti.Close();

                pictureBoxSoruGorsel.Image = Image.FromFile(suankiSoru.ResimYolu);
                richTextBoxSoruKoku.Text = suankiSoru.SoruKoku;
                radioButtonCevapBir.Text = suankiSoru.secenekler[0];
                radioButtonCevapIki.Text = suankiSoru.secenekler[1];
                radioButtonCevapUc.Text = suankiSoru.secenekler[2];
                radioButtonCevapDort.Text = suankiSoru.secenekler[3];
                radioButtonCevapBes.Text = suankiSoru.secenekler[4];
                labelBulunanSoru.Text = Convert.ToString(bulunulanSoru);
                labelToplamSoru.Text = Convert.ToString(sorusayisi);
            }
            else
            {
                MessageBox.Show("Başka soru bulunmuyor!", "Sonraki Soru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxSinavKurallari.Hide();
            groupBoxSinav.Show();

            
            
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from test where testid='"+suankiSinavId+"'", baglanti);
            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                testid = dr.GetValue(0).ToString();
                soruListesi.AddRange(dr.GetFieldValue<string[]>(1));
                sure = dr.GetValue(2).ToString();
                sorusayisi = dr.GetValue(3).ToString();
                sinavtarihi = dr.GetValue(5).ToString();
                ders = dr.GetValue(6).ToString();
                testadi = dr.GetValue(7).ToString();
            }

            dakika = Convert.ToInt32(sure);
            saniye = 0;
            timerSinavSuresi.Start();

            baglanti.Close();

            for (int i = 0; i < soruListesi.Count; i++)
            {
                dogruCevapListesi.Add("");

            }


            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("select * from soru where soruid='" + soruListesi[bulunulanSoru] + "'", baglanti);
            NpgsqlDataReader dr2 = komut2.ExecuteReader();

            if(dr2.Read())
            {
                Soru yeniSoru = new Soru(dr2.GetValue(1).ToString(), dr2.GetFieldValue<string[]>(2), dr2.GetValue(3).ToString(),(double)dr2.GetValue(4), dr2.GetValue(5).ToString(), dr2.GetValue(6).ToString());
                suankiSoru = yeniSoru;
                dogruCevapListesi[bulunulanSoru]=(suankiSoru.DogruCevap);
                bulunulanSoru++;
                soruSayi++;

            }
            
            baglanti.Close();

            pictureBoxSoruGorsel.Image = Image.FromFile(suankiSoru.ResimYolu);
            richTextBoxSoruKoku.Text = suankiSoru.SoruKoku;
            radioButtonCevapBir.Text = suankiSoru.secenekler[0];
            radioButtonCevapIki.Text = suankiSoru.secenekler[1];
            radioButtonCevapUc.Text = suankiSoru.secenekler[2];
            radioButtonCevapDort.Text = suankiSoru.secenekler[3];
            radioButtonCevapBes.Text = suankiSoru.secenekler[4];
            labelBulunanSoru.Text = Convert.ToString(bulunulanSoru);
            labelToplamSoru.Text = Convert.ToString(sorusayisi);


        }
    }
}
