using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsPrinter: clsUredjaj, iPrinter
    {
        private double p_KolicinaBoje;
        private int p_BrzinaStampe;
        public double KolicinaBoje
        {
            get { return p_KolicinaBoje; }
            set
            {
                if(value <= 1)
                {
                    throw new Exception("Kolicina boje ne sme biti manja od 0");
                }
                p_KolicinaBoje = value;
            }
        }
        public int BrzinaStampe
        {
            get { return p_BrzinaStampe; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Brzina stampe stampe mora biti veca od 1");
                }
                p_BrzinaStampe = value;
            }
        }
    }
}
