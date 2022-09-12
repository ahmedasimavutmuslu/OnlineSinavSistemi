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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme
{
    public class Soru
    {
        private string soruKoku;
        public string[] secenekler = new string[5];
        private string dogruCevap;
        private double puan;
        private string zorlukSeviye;
        private string resimYolu;
        private string ders;
        private Image resim;

        public Soru()
        {
            this.SoruKoku = "";
            for (int i = 0; i <= 4; i++)
            {
                this.secenekler[i] = "";
            }
            this.DogruCevap = "";
            this.Puan = 0;
            this.ZorlukSeviye = "";
            this.ResimYolu = "";
            this.ders = "";
        }
        public Soru(string soruKoku, string[] secenekler, string dogruCevap, double puan, string resimYolu, string ders)
        {
            this.SoruKoku = soruKoku;
            for (int i = 0; i <= 4; i++)
            {
                this.secenekler[i] = secenekler[i];
            }
            this.DogruCevap = dogruCevap;
            this.Puan = puan;
            this.ResimYolu = resimYolu;
            this.resim = Image.FromFile(resimYolu);
            this.Ders = ders;

        }

        public string SoruKoku { get => soruKoku; set => soruKoku = value; }
        public string DogruCevap { get => dogruCevap; set => dogruCevap = value; }
        public double Puan { get => puan; set => puan = value; }
        public string ZorlukSeviye { get => zorlukSeviye; set => zorlukSeviye = value; }
        public string ResimYolu { get => resimYolu; set => resimYolu = value; }
        public Image Resim { get => resim; set => resim = value; }
        public string Ders { get => ders; set => ders = value; }
    }
}
