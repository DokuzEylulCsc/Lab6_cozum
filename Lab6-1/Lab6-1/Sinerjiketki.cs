using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Sinerjiketki : IEtki
    {
        private int sonuc = 1;
        public int Degerlendir(int[] dizi)
        {

                for(int i=0;i<dizi.Length;i++)
                {
                sonuc *= dizi[i];

                    
                }
            return sonuc;

            
        }

        public int Degerlendir(int a, int b)
        {
            return a * b;
        }
    }
}
