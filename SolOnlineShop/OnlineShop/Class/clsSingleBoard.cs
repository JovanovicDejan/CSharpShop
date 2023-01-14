using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Class
{
    internal class clsSingleBoard: clsUredjaj, iSingleBoard
    {
        private string p_FormFactor;
        public string FormFactor
        {
            get { return p_FormFactor; }
            set
            {
                if(value.Length < 1 || value.Length > 255)
                {
                    throw new Exception("Naziv mora da sadrzi izmedju 1 i 255 karaktera");
                }
                p_FormFactor = value;
            }
        }
    }
}
