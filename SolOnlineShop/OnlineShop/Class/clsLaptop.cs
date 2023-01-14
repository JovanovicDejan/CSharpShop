using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsLaptop :clsUredjaj, iLaptop
    {
        private int p_Baterija;
        private double p_Tezina;
        
        public int Baterija
        {
            get { return p_Baterija; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Uredjaj mora da sadrzi bateriju");
                }
                p_Baterija = value;
            }
        }
        public double Tezina
        {
            get { return p_Tezina; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Tezina mora biti definisana");
                }
                p_Tezina = value;
            }
        }
    }
}
