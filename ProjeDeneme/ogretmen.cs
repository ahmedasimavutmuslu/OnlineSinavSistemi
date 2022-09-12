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
     public class ogretmen
    {
        private string adi;
        private string soyadi;
        private string tcKimlikNo;

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

        public ogretmen()
        {
            this.Adi = "";
            this.Soyadi = "";
            this.TcKimlikNo = "";
        }
        public ogretmen(string _adi, string _soyadi, string _tcKimlikNo)
        {
            this.Adi = _adi;
            this.Soyadi = _soyadi;
            this.TcKimlikNo = _tcKimlikNo;
        }
    }
}
