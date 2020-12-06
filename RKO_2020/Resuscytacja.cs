using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RKO_2020
{
    public class Resuscytacja : Form
    {
        static Form1 Okno = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public int Poziom_Życia;
        public bool wciśnięty_przycisk = false;
        TimeSpan ts = new TimeSpan();
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();
        public Resuscytacja() {
            this.Poziom_Życia = 0;
        }
        public void Aktualizacja_Życia_Przycisk()
        {
            if (!wciśnięty_przycisk)
            {
                stopwatch.Stop();
                ts = stopwatch.Elapsed;
                double delta = ts.TotalMilliseconds;
                stopwatch.Reset();
                stopwatch.Start();
                stopwatch2.Stop();
                stopwatch2.Reset();
                stopwatch2.Start();
                wciśnięty_przycisk = true;
                if (600 >= delta && delta >= 500 && Poziom_Życia != 100)
                {
                    Poziom_Życia += 5;
                }
                else if(delta<500 && Poziom_Życia!=0)
                {
                    Poziom_Życia -= 5;
                }
                else
                {
                    for (int i=0; i < Convert.ToInt32(delta) / 500; i++)
                    {
                        if (Poziom_Życia != 0)
                        {
                            Poziom_Życia -= 5;
                        }
                        else break;
                    }
                }
            }
        }
        /*public void Aktualizacja_Życia_Brak_Reakcji()
        {
            
                stopwatch2.Stop();
                TimeSpan ts1 = stopwatch2.Elapsed;
                stopwatch2.Restart();

                
                if(ts1.TotalMilliseconds>600 && Poziom_Życia!=0)
                {
                    stopwatch2.Stop();
                    stopwatch2.Reset();
                    stopwatch2.Start();
                    Poziom_Życia -= 5;  
                }
        }*/
        public String Wyświetl_Życie()
        {
            return "POZIOM ŻYWOTNOŚCI "+Poziom_Życia.ToString()+"%";
        }
    }
}
