using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Properties
{
    internal class Urun
    {
        public string urunAdi;
        private double urunFiyati;

        public double UrunFiyati
        {
            get { return urunFiyati; }
            set
            {
                if(value < 0)
                {
                    urunFiyati = 1;
                }
                else
                {
                    urunFiyati = value;
                }
            }
        }
    }
}
