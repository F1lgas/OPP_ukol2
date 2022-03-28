using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol2
{
    class Auto
    {
        private string znacka;
        private double spotreba;
        private double ujetoCelkem;
        private DateTime okamzikRozjezdu;
        private DateTime dobaJizdyCelkem;
        private bool Jede { get; set; }

        public Auto(string znacka, double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            ujetoCelkem = 0;
            Jede = false;
        }

        public double VratUjeteKm()
        {
            return ujetoCelkem = Convert.ToDouble(dobaJizdyCelkem.TimeOfDay.TotalSeconds) / 60;    //za 1min ujeto 1km
        }

        public DateTime Rozjeď()
        {
            okamzikRozjezdu = DateTime.Now;

            Jede = true;

            return okamzikRozjezdu;
        }

        public DateTime Zastav()
        {
            return dobaJizdyCelkem += (DateTime.Now.TimeOfDay - okamzikRozjezdu.TimeOfDay);
        }

        public double CelkováSpotřeba()
        {
            return ujetoCelkem * (spotreba / 100);
        }

        public override string ToString()
        {
            if (Jede == true)
            {
                return String.Format("Jedoucí auto {0} se spotřebou {1} l/100km, \nkteré vyjelo ve {2}, jelo celkem {3} a celkem najelo {4} km.", this.znacka, this.spotreba, this.okamzikRozjezdu.TimeOfDay, this.dobaJizdyCelkem.TimeOfDay, this.ujetoCelkem);
            }
            else
            {
                return String.Format("Stojící auto {0} se spotřebou {1} l/100km, \nkteré jelo celkem {2} h a celkem najelo {3} km ", this.znacka, this.spotreba, this.dobaJizdyCelkem.TimeOfDay, this.ujetoCelkem);
            }
        }
    }
}