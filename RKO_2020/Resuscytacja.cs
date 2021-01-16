using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace RKO_2020
{
    public class Resuscytacja
    {
        static public int Poziom_Zycia;
        public bool wcisniety_przycisk;
        static public bool czy_trwa_resuscytacja;
        static public int chalenge;
        static public int idealne_uciski ;
        static public int zle_uciski;
        TimeSpan ts = new TimeSpan();
        TimeSpan ts2 = new TimeSpan();
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();
        public Resuscytacja()
        {
            Poziom_Zycia = 0;
            wcisniety_przycisk = false;
            czy_trwa_resuscytacja = false;
            chalenge = 0;
            idealne_uciski = 1;
            zle_uciski = 1;
        }
        public void Aktualizacja_Zycia(Label label_glowny, Label label_Poziom_Zycia, bool czy_kliknieto_spacje)
        {
            if (czy_trwa_resuscytacja == false) return; 
            if (!stopwatch.IsRunning) //funkcja inicjalizująca stopery
            {
                stopwatch.Start(); //stoper odpowiadający za liczenie delty pomiędzy kolejnymi wciśnięciami spacji
                stopwatch2.Start(); //stoper odpowiadający za kontrolowanie czy gracz przekroczył interwał czasu
            }
            if (!wcisniety_przycisk)
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
                wcisniety_przycisk = true;
                if (600 >= delta && delta >= 500 && Poziom_Zycia != 100) // zwiększanie życia jezeli 0.6s>delta>0.5s
                {
                    interfejs.zmien_label(label_glowny, "            IDEALNIE", Color.Chartreuse, true);
                    idealne_uciski++;
                    Poziom_Zycia += 1;
                }
                else if (delta < 500 && Poziom_Zycia != 0) //zmniejszanie życia gdy gracz wciska przycisk zbyt szybko
                {
                    interfejs.zmien_label(label_glowny, "            ZA SZYBKO", Color.Firebrick, true);
                    zle_uciski++;
                    Poziom_Zycia -= 1;
                }
                //ze wzgledu na metode sprawdzania czy gracz przekroczył czas, to interwał czasu
                //nieznacznie się wydłuża. Dlatego ten dodatkowy interwał czasu nie zabiera, ani nie dodaje graczowi 
                //poziomu żywotności. W zamian za to wyświetla feedback "PRAWIE";
                else if (ts2.TotalMilliseconds > 600 && delta > 600 && Poziom_Zycia != 0)
                {
                    interfejs.zmien_label(label_glowny, "            PRAWIE", Color.White, true);
                }
            }
            else if (!czy_kliknieto_spacje) //jeżeli funkcja jest wywoływana za pomocą timera sprawdzjącego
            {
                ts2 = stopwatch2.Elapsed;
                if (ts2.TotalMilliseconds > 600 && Poziom_Zycia != 0) //spadek zycia jeśli gracz nie wykonał akcji w zadanym czasie
                {
                    stopwatch2.Stop();
                    stopwatch2.Reset();
                    stopwatch2.Start();
                    interfejs.zmien_label(label_glowny, "            ZA POZNO", Color.Firebrick, true);
                    zle_uciski++;
                    Poziom_Zycia -= 1;
                }
            }

            interfejs.Wyswietl_Zycie(label_Poziom_Zycia);
        }
    }
}
