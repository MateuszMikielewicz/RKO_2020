using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RKO_2020
{
    public class Resuscytacja
    {
        static Form1 Okno = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public int Poziom_Życia;
        public bool wciśnięty_przycisk = false;
        Stopwatch stopwatch = new Stopwatch();
        public Resuscytacja() {
            this.Poziom_Życia = 0;
        }
        public void Wzrost_Życia()
        {
            if (!wciśnięty_przycisk)
            {
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                if (600>=ts.TotalMilliseconds && ts.TotalMilliseconds >= 500)
                {
                    Poziom_Życia = Poziom_Życia + 5;
                }
                stopwatch.Reset();
                stopwatch.Start();
                wciśnięty_przycisk = true;
            }
        }
        public String Wyświetl_Życie()
        {
            return "POZIOM ŻYWOTNOŚCI "+Poziom_Życia.ToString()+"%";
        }
    }
}
