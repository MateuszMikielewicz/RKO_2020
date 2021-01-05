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
        public int Poziom_Życia;
        public bool wciśnięty_przycisk = false;
        TimeSpan ts = new TimeSpan();
        TimeSpan ts2 = new TimeSpan();
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();
        public Resuscytacja() {
            this.Poziom_Życia = 0;
        }
        public void Aktualizacja_Życia_Przycisk(System.Windows.Forms.Label label, bool czy_kliknięto_spacje)
        {
            if (!stopwatch.IsRunning) //funkcja inicjalizująca stopery
            {
                stopwatch.Start(); //stoper odpowiadający za liczenie delty pomiędzy kolejnymi wciśnięciami spacji
                stopwatch2.Start(); //stoper odpowiadający za kontrolowanie czy gracz przekroczył interwał czasu
            }
            if (!wciśnięty_przycisk)
            {
                stopwatch.Stop(); //zatrzymanie stoperów
                stopwatch2.Stop();

                ts = stopwatch.Elapsed; //zapisanie delty czasów
                ts2= stopwatch2.Elapsed;

                stopwatch.Reset();     //reset stoperow
                stopwatch2.Reset();
                stopwatch.Start();
                stopwatch2.Start();
                
                double delta = ts.TotalMilliseconds; //delta czasu od poprzedniego kliknięcia spacji
                wciśnięty_przycisk = true;
                if (600 >= delta && delta >= 500 && Poziom_Życia != 100) // zwiększanie życia jezeli 0.6s>delta>0.5s
                {
                    label.Text = "IDEALNIE";
                    Poziom_Życia += 5;
                }
                else if(delta<500 && Poziom_Życia!=0) //zmniejszanie życia gdy gracz wciska przycisk zbyt szybko
                {
                    label.Text = "ZA SZYBKO";
                    Poziom_Życia -= 5;
                }
                //ze wzgledu na metode sprawdzania czy gracz przekroczył czas, to interwał czasu
                //nieznacznie się wydłuża. Dlatego ten dodatkowy interwał czasu nie zabiera, ani nie dodaje graczowi 
                //poziomu żywotności. W zamian za to wyświetla feedback "PRAWIE";
                else if (ts2.TotalMilliseconds > 600 && delta > 600 && Poziom_Życia!=0) label.Text = "PRAWIE"; 
            }
            else if (!czy_kliknięto_spacje) //jeżeli funkcja jest wywoływana za pomocą timera sprawdzjącego
            {
                ts2 = stopwatch2.Elapsed;
                if (ts2.TotalMilliseconds > 600 && Poziom_Życia != 0) //spadek zycia jeśli gracz nie wykonał akcji w zadanym czasie
                {
                    stopwatch2.Stop();
                    stopwatch2.Reset();
                    stopwatch2.Start();
                    label.Text = "ZA PÓŹNO";
                    Poziom_Życia -= 5;
                }
            }
        }
        public String Wyświetl_Życie()
        {
            return "POZIOM ŻYWOTNOŚCI "+Poziom_Życia.ToString()+"%";
        }
    }
}
