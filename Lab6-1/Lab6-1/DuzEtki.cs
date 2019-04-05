using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class DuzEtki : IEtki
    {
        
       
    
        int IEtki.Degerlendir(int[] dizi)
        {
            throw new NotImplementedException();
        }

        int IEtki.Degerlendir(int a, int b)
        {
            return a + b;

        }
    }
}
