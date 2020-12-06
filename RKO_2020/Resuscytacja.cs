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
        public static Form1 Okno = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public int Poziom_Życia;
        public bool wciśnięty_przycisk = false;
        TimeSpan ts = new TimeSpan();
        TimeSpan ts2 = new TimeSpan();
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();
        public Resuscytacja() {
            this.Poziom_Życia = 0;
        }
        public void Aktualizacja_Życia_Przycisk(System.Windows.Forms.Label label)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                stopwatch2.Start();
            }
            if (!wciśnięty_przycisk)
            {
                stopwatch.Stop(); //zatrzymanie stopera
                stopwatch2.Stop();

                ts = stopwatch.Elapsed;
                ts2= stopwatch2.Elapsed;

                stopwatch.Reset();
                stopwatch2.Reset();
                stopwatch.Start();
                stopwatch2.Start();
                
                double delta = ts.TotalMilliseconds; //delta czasu od poprzedniego kliknięcia spacji
                wciśnięty_przycisk = true;
                if (600 >= delta && delta >= 500 && Poziom_Życia != 100)
                {
                    label.Text = "IDEALNIE";
                    Poziom_Życia += 5;
                }
                else if(delta<500 && Poziom_Życia!=0)
                {
                    label.Text = "ZA SZYBKO";
                    Poziom_Życia -= 5;
                }
                else if (ts2.TotalMilliseconds > 600 && delta > 600) label.Text = "PRAWIE";
            }
        }
        public void Aktualizacja_Życia_Brak_Reakcji(System.Windows.Forms.Label label)
        {      
                ts2 = stopwatch2.Elapsed;
                if(ts2.TotalMilliseconds>600 && Poziom_Życia!=0)
                {
                    stopwatch2.Stop();
                    stopwatch2.Reset();
                    stopwatch2.Start();
                    label.Text = "ZA PÓŹNO";
                    Poziom_Życia -= 5;  
                }
        }
        public String Wyświetl_Życie()
        {
            return "POZIOM ŻYWOTNOŚCI "+Poziom_Życia.ToString()+"%";
        }
    }
}
