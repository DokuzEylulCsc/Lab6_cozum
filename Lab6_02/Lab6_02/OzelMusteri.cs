using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6_02
{
    class OzelMusteri : Musteri
    {
        

        public OzelMusteri(String ad,String soyad,double indirim) : base(ad,soyad,indirim)
        {
           
        }

     

        public override double indirimHesapla(double fiyat)
        {
            return base.indirimHesapla(fiyat)*(0.8); 
        }

        /* 
         * 
         * 
         * The return type for ++ or -- operator must match the parameter type or be derived from the parameter type	


        public static Musteri operator --(OzelMusteri x)
        {
            if (x.ToplamAlisveris < 1000)
            {
               Musteri m = new Musteri(x.Ad, x.Soyad, x.Indirim);
               return m;
            }
            else return x;

        }
        */



    }
}
