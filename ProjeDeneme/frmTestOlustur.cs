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
    public partial class frmTestOlustur : Form
    {
        public string testDers = "";
        
        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");

        public frmTestOlustur()
        {
            InitializeComponent();
            
            textBoxTestSinavSuresi.Hide();
            textBoxTestSinavTarihi.Hide();
            textBoxTestSoruSayisi.Hide();
            buttonTestOlustur.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            dataGridViewOgrenciListesi.Hide();
            dataGridViewSorular.Hide();
            buttonOgrenciEkle.Hide();
            buttonTestOlustur.Hide();
            buttonSoruEkle.Hide();
            label5.Hide();
            textBoxTestAdi.Hide();
            

        }

        private void buttonTestDersSecimi_Click(object sender, EventArgs e)
        {
            if (radioButtonTestNDP.Checked)
            {
                testDers = "NDP";
            }
            else if (radioButtonTestPDP.Checked)
            {
                testDers = "PDP";
            }
            else if (radioButtonTestSayisalAnaliz.Checked)
            {
                testDers = "Sayısal Analiz";
            }
            else
            {
                MessageBox.Show("Bir ders seçmek zorundasınız!", "Hatalı Seçim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelTestOlusturDersSec.Hide();
            radioButtonTestNDP.Hide();
            radioButtonTestPDP.Hide();
            radioButtonTestSayisalAnaliz.Hide();
            buttonTestDersSecimi.Hide();
            label1.Hide();


            textBoxTestSinavSuresi.Show();
            textBoxTestSinavTarihi.Show();
            textBoxTestSoruSayisi.Show();
            textBoxTestAdi.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            dataGridViewOgrenciListesi.Show();
            dataGridViewSorular.Show();
            buttonTestOlustur.Show();
            buttonOgrenciEkle.Show();
            buttonSoruEkle.Show();
            buttonTestOlustur.BringToFront();
            buttonOgrenciEkle.BringToFront();
            buttonSoruEkle.BringToFront();

            

            

            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from soru where ders=" + "'" + testDers + "'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewSorular.DataSource = ds.Tables[0];
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from ogrenci", baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridViewOgrenciListesi.DataSource = ds2.Tables[0];
            baglanti.Close();


        }

        private void panelTestOlusturDersSec_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public List<int> SelectedIndexsOgrenciler = new List<int> { };
        public List<int> SelectedIndexsSorular = new List<int> { };

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //ogrenci datagridview i ile soru datagridviewini ayır!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if(SelectedIndexsOgrenciler.Contains(e.RowIndex))
            {
                SelectedIndexsOgrenciler.Remove(e.RowIndex);
            }
            else
            {
                SelectedIndexsOgrenciler.Add(e.RowIndex);
            }

            

            

            

           


            /*
            if(dataGridViewOgrenciListesi.SelectedRows.Count>0)
            {
                string id = Convert.ToString(dataGridViewOgrenciListesi.CurrentRow.Cells[2].Value);
                MessageBox.Show(id);
            }

            */
        }

        private void frmTestOlustur_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonTestOlustur_Click(object sender, EventArgs e)
        {
            string sure, soruSayisi, ders, sinavTarihi,adi;
            ders = testDers;
            sinavTarihi = textBoxTestSinavTarihi.Text;
            sure = textBoxTestSinavSuresi.Text;
            soruSayisi = textBoxTestSoruSayisi.Text;
            adi = textBoxTestAdi.Text;

            Test yeniTest = new Test(ogrenciler, sorular, sure, soruSayisi, sinavTarihi, ders,adi);
            //MessageBox.Show("Test Ekleme Başarılı", "Test Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglanti.Open();

            int denemeSayisi=4;
            int ogrenciSayisiBaslangic = 4;
            int ogrenciSayisiBitis;
            int soruSayisiBitis;
            int sureParametreSayisi;
            

            string ogrencikomut="ARRAY[";
            string sorularkomut = "ARRAY[";

            foreach (string ogrenci in ogrenciler)
            {
                ogrencikomut = ogrencikomut + "@p" + denemeSayisi + ",";
                denemeSayisi++;
            }
            ogrencikomut = ogrencikomut.Remove(ogrencikomut.Length - 1);
            ogrencikomut = ogrencikomut + "]";
            ogrenciSayisiBitis = denemeSayisi - 1;
            int soruSayisiBaslangic = denemeSayisi;

            foreach (string soru in sorular)
            {
                sorularkomut = sorularkomut + "@p" + denemeSayisi + ",";
                denemeSayisi++;
            }
            sorularkomut = sorularkomut.Remove(sorularkomut.Length - 1);
            sorularkomut = sorularkomut + "]";
            soruSayisiBitis = denemeSayisi-1;
            sureParametreSayisi = denemeSayisi;


            NpgsqlCommand komut = new NpgsqlCommand("insert into test (sorusayisi,sinavtarihi,ders,ogrenciler,sorular,sure,testadi) values (@p1,@p2,@p3,"+ogrencikomut+","+sorularkomut+",@p"+denemeSayisi+",@p"+(denemeSayisi+1)+")", baglanti);

            komut.Parameters.AddWithValue("@p1", yeniTest.SoruSayisi);
            komut.Parameters.AddWithValue("@p2", yeniTest.SinavTarihi);
            komut.Parameters.AddWithValue("@p3", yeniTest.Ders);
            for (int i = 0; ogrenciSayisiBaslangic <= ogrenciSayisiBitis; ogrenciSayisiBaslangic++,i++)
            {
                komut.Parameters.AddWithValue("@p" + ogrenciSayisiBaslangic, yeniTest.ogrenciler[i]);
            }
            for(int i=0;soruSayisiBaslangic<=soruSayisiBitis;soruSayisiBaslangic++,i++)
            {
                komut.Parameters.AddWithValue("@p" + soruSayisiBaslangic, yeniTest.sorular[i]);
            }
            komut.Parameters.AddWithValue("@p" + sureParametreSayisi, yeniTest.Sure);
            sureParametreSayisi = sureParametreSayisi + 1;
            komut.Parameters.AddWithValue("@p" + sureParametreSayisi, yeniTest.Adi);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Test kaydı başarıyla gerçekleştirildi", "Test Kaydı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmOgretmen frmOgretmen = new frmOgretmen();
            this.Close();
            frmOgretmen.Show();

        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewOgrenciListesi.Rows)
            {
                if (row.Selected = SelectedIndexsOgrenciler.Contains(row.Index))
                {
                    if(ogrenciler.Contains(Convert.ToString(dataGridViewOgrenciListesi.Rows[row.Index].Cells[2].Value)))
                    {
                        MessageBox.Show("Eklemek istediğiniz öğrenci zaten var. Lütfen farklı bir öğrenci ekleyin!", "Öğrenci Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ogrenciler.Add(Convert.ToString(dataGridViewOgrenciListesi.Rows[row.Index].Cells[2].Value));
                        MessageBox.Show("Öğrenci Ekleme Başarılı", "Öğrenci Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);//dogru calismiyo kontrol et

                    }

                }
            }

            
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedIndexsSorular.Contains(e.RowIndex))
            {
                SelectedIndexsSorular.Remove(e.RowIndex);
            }
            else
            {
                SelectedIndexsSorular.Add(e.RowIndex);
            }
 

        }

        public List<string> sorular = new List<string>();
        public List<string> ogrenciler = new List<string>();
        

        private void buttonSoruEkle_Click(object sender, EventArgs e)
        {
            
            
            if(sorular.Count <= Convert.ToInt32(textBoxTestSoruSayisi.Text))
            {
                foreach (DataGridViewRow row in this.dataGridViewSorular.Rows)
                {
                    if (row.Selected = SelectedIndexsSorular.Contains(row.Index))
                    {
                        
                        if (sorular.Contains(Convert.ToString(dataGridViewSorular.Rows[row.Index].Cells[0].Value)))
                        {
                            MessageBox.Show("Eklemek istediğiniz soru zaten var. Lütfen farklı bir soru ekleyin!", "Soru Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                        }
                        else                            
                        {       
                            sorular.Add(Convert.ToString(dataGridViewSorular.Rows[row.Index].Cells[0].Value));

                        }

                    }
                }

                MessageBox.Show("Soru Ekleme Başarılı", "Soru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);//dogru calismiyo kontrol et

            }

            else
            {
                MessageBox.Show("Lütfen belirttiğiniz kadar soru ekleyin!", "Soru Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
