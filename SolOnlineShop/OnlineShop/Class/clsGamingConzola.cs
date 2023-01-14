using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsGamingConzola: clsUredjaj, iGamingKonzole
    {
        private string p_TipKonzole;
        private int p_BrojDzojstika;

        public string TipKonzole
        {
            get { return p_TipKonzole; }
            set
            {
                if(value.Length < 1 || value.Length > 255)
                {
                    throw new Exception("Tip konzole mora da sadrzi izmedju 1 i 255 karaktera");
                }
                p_TipKonzole = value;
            }
        }
        public int BrojDzojstika
        {
            get { return p_BrojDzojstika; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Broj dzojstika mora biti definisan");
                }
                p_BrojDzojstika = value;
            }
        }
    }
}
