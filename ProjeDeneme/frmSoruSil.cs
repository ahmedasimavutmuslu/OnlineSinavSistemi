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
    public partial class frmSoruSil : Form
    {
        public frmSoruSil()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection(@"server=localHost; port=; Database=odevdeneme1; user Id=postgres; password=onigiri801");

        private void bttnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretmen frmOgretmen = new frmOgretmen();
            frmOgretmen.Show();
        }

        private void bttnSoruListele_Click(object sender, EventArgs e)
        {
            string ders;
            if(radioButtonListeleNDP.Checked)
            {
                ders = radioButtonListeleNDP.Text;
            }
            else if(radioButtonListelePDP.Checked)
            {
                ders = radioButtonListelePDP.Text;
            }
            else
            {
                ders = radioButtonListeleSayisalAnaliz.Text;
            }
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from soru where ders="+"'"+ders+"'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewSoruListe.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void bttnSoruSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("delete from soru where soruid=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", dataGridViewSoruListe.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla gerçekleştirildi!", "Soru Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bttnSoruListele.PerformClick();
        }
    }
}
