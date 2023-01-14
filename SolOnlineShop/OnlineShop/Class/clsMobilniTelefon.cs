using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsMobilniTelefon:clsLaptop, iMobilniTelefon
    {
        private int p_BrojKartice;
        private int p_BrojKamera;
        public int BrojKartica
        {
            get { return p_BrojKartice; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Uredaj mora sadrzati bar 1 karticu");
                }
                p_BrojKartice = value;
            }
        }
        public int BrojKamera
        {
            get { return p_BrojKamera; }
            set
            {
                p_BrojKamera = value;
            }
        }
    }
}
