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
    public class Test
    {
        public List<string> ogrenciler;
        public List<string> sorular;
        private string adi;
        private string sure;
        private string soruSayisi;
        private string sinavTarihi;
        private string ders;

        public Test()
        {
            ogrenciler = new List<string>();
            sorular = new List<string>();
            sure = "";
            soruSayisi = "";
            ders = "";
            sinavTarihi = "";
            ogrenciler = null;
            sorular = null;
            adi = "";
        }
        public Test(List<string> _ogrenciler, List<string> _sorular,string _sure,string _soruSayisi,string _sinavTarihi,string _ders,string _adi)
        {
            ogrenciler = new List<string>();
            sorular = new List<string>();
            Sure = _sure;
            SinavTarihi = _sinavTarihi;
            Ders = _ders;
            SoruSayisi = _soruSayisi;

            for(int i=0;i<_sorular.Count();i++)
            {
                sorular.Add(_sorular[i]);
            }

            for(int i=0;i<_ogrenciler.Count();i++)
            {
                ogrenciler.Add(_ogrenciler[i]);

            }
            Adi = _adi;
        }

        public string Sure { get => sure; set => sure = value; }
        public string SoruSayisi { get => soruSayisi; set => soruSayisi = value; }
        public string SinavTarihi
        {
            get 
            {
                return sinavTarihi;
            }
            set
            {    
                sinavTarihi = value;
            }
        
        }

        public string Ders { get => ders; set => ders = value; }
        public string Adi { get => adi; set => adi = value; }
    }
}
