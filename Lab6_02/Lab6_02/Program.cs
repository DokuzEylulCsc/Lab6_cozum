using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double fiyat = 100;
            Musteri x = new Musteri("Baris", "Tezel", 0.1);
            Console.WriteLine($"Fiyet {fiyat} İndirimli {x.indirimHesapla(fiyat)}");
            x.ToplamAlisveris = 1500;
            x++;
            Console.WriteLine($"Fiyet {fiyat} İndirimli {x.indirimHesapla(fiyat)}");
        }
    }
}
