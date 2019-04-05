using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6_02
{
    class Musteri
    {
        private double indirim;
        private double toplamAlisveris;

        private string ad;
        private string soyad;

        protected string Ad { get { return ad; } set { ad = value; } }

        protected string Soyad { get { return soyad; } set { soyad = value; } }

        public double ToplamAlisveris { get { return toplamAlisveris; } set { toplamAlisveris = value; } }

        public double Indirim { get { return indirim; } set { indirim = value; } }

        public Musteri(String ad, String soyad,double indirim)
        {
            Ad = ad;
            Soyad = soyad;
            this.Indirim = indirim;
        }

        public virtual double indirimHesapla(double fiyat)
        {
            return (1-Indirim) * fiyat;
        }

        public static Musteri operator ++(Musteri x) 
        {
            if (x.toplamAlisveris > 1000)
            {
                OzelMusteri m = new OzelMusteri(x.ad, x.soyad, x.indirim);
                return m;
            }
            else return x;

        }


    }
}
