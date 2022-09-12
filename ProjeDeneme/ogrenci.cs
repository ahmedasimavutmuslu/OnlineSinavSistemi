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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme
{
    public class ogrenci
    {
        private string adi;
        private string soyadi;
        private string tcKimlikNo;
        private string sifre;

        public string Adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi = value;
            }
        }
        public string Soyadi
        {
            get
            {
                return soyadi;
            }
            set
            {
                soyadi = value;
            }
        }
        public string TcKimlikNo
        {
            get
            {
                return tcKimlikNo;
            }
            set
            {
                if (value.Length < 11 && value.Length > 11)
                {
                    MessageBox.Show("TC Kimlik 11 haneden küçük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tcKimlikNo = value;
                }
            }
        }

        public string Sifre { get => sifre; set => sifre = value; }

        public ogrenci()
        {
            this.Adi = "";
            this.Soyadi = "";
            this.TcKimlikNo = "";
            this.Sifre = "";
        }
        public ogrenci(string _adi, string _soyadi, string _tcKimlikNo,string _sifre)
        {
            this.Adi = _adi;
            this.Soyadi = _soyadi;
            this.TcKimlikNo = _tcKimlikNo;
            this.Sifre = _sifre;
        }
    }
}
