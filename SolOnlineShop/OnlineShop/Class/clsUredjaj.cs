using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    public class clsUredjaj : iUredjaji
    {
        private double p_Cena;
        private string p_Marka;
        private string p_Model;
        private double p_Procesor;
        private double p_Ram;
        private string p_OperativniSistem;
        private string p_NacinUnosa;

        public double Cena
        {
            get { return p_Cena; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Cena uredjaja ne sme biti manja od 0");
                }
                else
                {
                    p_Cena = value;
                }
            }
        }
        public string Marka
        {
            get { return p_Marka; }
            set
            {
                if(value.Length < 1 || value.Length > 100)
                {
                    throw new Exception("Naziv marke mora sadrzati od 1 do 100 karaktera");
                }
                p_Marka = value;
            }
        }
        public string Model
        {
            get { return p_Model; }
            set
            {
                if(value.Length < 1 || value.Length > 255)
                {
                    throw new Exception("Naziv modela mora sadrzati od 1 do 255 karaktera");
                }
                p_Model = value;
            }
        }
        public double Procesor
        {
            get { return p_Procesor; }
            set { p_Procesor = value; }
        }
        public double Ram
        {
            get { return p_Ram; }
            set { p_Ram = value; }
        }
        public string OperativniSistem
        {
            get { return p_OperativniSistem; }
            set { p_OperativniSistem = value; }
        }
        public string NacinUnosa
        {
            get { return p_NacinUnosa; }
            set { p_NacinUnosa = value; }
        }
    }

    
}
