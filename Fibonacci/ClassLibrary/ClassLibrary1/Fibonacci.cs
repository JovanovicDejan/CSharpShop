using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMath
    {
        public long[] GenFibonacci(int BrojClanova)
        {
            if(BrojClanova <= 0) return null;

            long[] rezultat = new long[BrojClanova];
            
            if(BrojClanova == 1)
            {
                rezultat[0] = 0;
            }

            int a = 0;
            int b = 1;

            rezultat[0] = a;
            rezultat[1] = b;

            for(int i = 2; i < BrojClanova; i++)
            {
                int trenunto = a + b;
                rezultat[i] = trenunto;
                a = b;
                b = trenunto;
            }

            return rezultat;
        }
    }
}
