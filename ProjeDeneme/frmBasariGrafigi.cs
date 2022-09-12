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
    public partial class frmBasariGrafigi : Form
    {
        string testid;
        public frmBasariGrafigi()
        {
            InitializeComponent();
        }

        string secilenDers;
        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");

        private void buttonDersSec_Click(object sender, EventArgs e)
        {
            if (radioButtonNDP.Checked)
            {
                secilenDers = "NDP";
            }
            else if (radioButtonPDP.Checked)
            {
                secilenDers = "PDP";
            }
            else if (radioButtonSayisalAnaliz.Checked)
            {
                secilenDers = "Sayısal Analiz";
            }
            else
            {
                MessageBox.Show("Bir ders seçimi yapmak zorundasınız!", "Ders Seçimi Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select testid, testadi, sinavtarihi from test where ders='" + secilenDers + "'", baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridViewSinavListesi.DataSource = dataSet.Tables[0];
            dataGridViewSinavListesi.Columns[0].Visible = false;
            baglanti.Close();
           
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            frmOgretmen frmOgretmen = new frmOgretmen();
            this.Hide();
            frmOgretmen.Show();
        }

        private void buttonGrafikGoster_Click(object sender, EventArgs e)
        {
            testid=dataGridViewSinavListesi.CurrentRow.Cells[0].Value.ToString();
            chartBasariGrafigi.Series[0].Name = dataGridViewSinavListesi.CurrentRow.Cells[1].Value.ToString();
            baglanti.Open();
           
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from sonuclar where testid='" + testid + "'", baglanti);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridViewSonucListesi.DataSource = dataSet.Tables[0];
            dataGridViewSonucListesi.Columns[0].Visible = false;
            baglanti.Close();

            for(int i=0;i<dataGridViewSonucListesi.Rows.Count;i++)
            {
                chartBasariGrafigi.Series[0].Points.AddXY(dataGridViewSonucListesi.Rows[i].Cells[1].Value.ToString(), dataGridViewSonucListesi.Rows[i].Cells[2].Value.ToString());
            }
            chartBasariGrafigi.Titles.Add(secilenDers + " " + dataGridViewSinavListesi.CurrentRow.Cells[1].Value.ToString() + " Başarı Grafiği ");
            chartBasariGrafigi.ChartAreas[0].AxisX.Title = "Öğrenci";
            chartBasariGrafigi.ChartAreas[0].AxisY.Title = "Puan";
            
        }

        private void dataGridViewSinavListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
