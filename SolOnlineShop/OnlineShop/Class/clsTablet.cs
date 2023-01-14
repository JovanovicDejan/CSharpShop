using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsTablet: clsLaptop, iTablet
    {
        private string p_Platforma;
        private double p_Kamera;
        private string p_TipKonekcije;

        public string Platforma
        {
            get { return p_Platforma; }
            set
            {
                if(value.Length < 1 || value.Length > 255)
                {
                    throw new Exception("Naziv platforme mora sadrzati izmedju 1 i 255 karaktera");
                }
                p_Platforma = value;
            }
        }
        public double Kamera
        {
            get { return p_Kamera; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Broj kamera ne sme biti manji od 0");
                }
                p_Kamera = value;
            }
        }
        public string TipKonekcije
        {
            get { return p_TipKonekcije; }
            set
            {
                if(value.Length < 1 || value.Length > 255)
                {
                    throw new Exception("Tip konekcije mora sadrzati izmedju 1 i 255 karaktera");
                }
                p_TipKonekcije = value;
            }

        }
    }
}
