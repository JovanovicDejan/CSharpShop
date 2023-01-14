using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite koliko brojeva zelite: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            clsMath math = new clsMath();
            long[] rezultat = math.GenFibonacci(broj);

            for(int i = 0; i < broj; i++)
            {
                Console.WriteLine(rezultat[i]);
            }

            Console.ReadKey();
        }
    }
}
