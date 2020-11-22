using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKO_2020
{
    class Czas
    {
        public String Wyswietl_czas(int ticks)
        {
            int sekundy = ticks;
            if (ticks > 59)
            {
                sekundy = sekundy - 60*(ticks/60);
            }
            String zegar = (ticks/60).ToString()+":"+sekundy.ToString();
            return zegar;
        }
    }
}
