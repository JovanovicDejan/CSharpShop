using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsDesktop : clsUredjaj, iDesktop
    {
        private int p_Napajanje;
        private string p_Kuciste;

        public int Napajanje
        {
            get { return p_Napajanje; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Broj napajanja ne moze biti manji od 1");
                }
                p_Napajanje = value;
            }
        }
        public string Kuciste
        {
            get { return p_Kuciste; }
            set
            {
                if (value.Length < 1 || value.Length > 255)
                {
                    throw new Exception("Naziv kucista mora sadrzati izmedju 1 i 255 karaktera");
                }
                p_Kuciste = value;
            }
        }
    }
}
