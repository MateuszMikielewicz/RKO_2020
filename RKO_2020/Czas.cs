using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKO_2020
{
    public class Czas
    {
        public int ticks;

        public Czas() {
            this.ticks = 0;
        }

        public String Wyswietl_czas()
        {
            ticks++;
            int sekundy = ticks - 60 * (ticks / 60); ;
            if (sekundy < 10)
            {
                return "CZAS "+(ticks / 60).ToString() + ":0" + sekundy.ToString();
            }
            return "CZAS "+(ticks / 60).ToString() + ":" + sekundy.ToString();
        }
    }
}
