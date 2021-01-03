using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RKO_2020
{
    public class interfejs
    {
        static public void wyświetl_obraz(Bitmap bitmap, System.Windows.Forms.PictureBox instancja)
        {
            instancja.Image = (Image)bitmap;
        }
        static public void zmień_label(System.Windows.Forms.Label instancja, String napis, Color kolor)
        {
            instancja.Text = napis;
            instancja.ForeColor = kolor;
        }
        static public String Wyswietl_czas()
        {
            Pierwsza_pomoc.ticks++;
            int sekundy = Pierwsza_pomoc.ticks - 60 * (Pierwsza_pomoc.ticks / 60); ;
            if (sekundy < 10)
            {
                return "CZAS " + (Pierwsza_pomoc.ticks / 60).ToString() + ":0" + sekundy.ToString();
            }
            return "CZAS " + (Pierwsza_pomoc.ticks / 60).ToString() + ":" + sekundy.ToString();
        }
        static public void wyświetl_panel(System.Windows.Forms.Panel instancja, int nr_panelu)
        {
            instancja.Show();
            Pierwsza_pomoc.wybrany_panel = nr_panelu;
        }
        static public void wyłącz_panel(System.Windows.Forms.Panel instancja1, System.Windows.Forms.Panel instancja2, System.Windows.Forms.Panel instancja3)
        {
            switch (Pierwsza_pomoc.wybrany_panel)
            {
                case 1:
                    instancja1.Hide();
                    break;
                case 2:
                    instancja2.Hide();
                    break;
                default:
                    instancja3.Hide();
                    break;
            }
        }
        static public void obsługa_błędu_użytkownika(System.Windows.Forms.Label instancja_tekstu, System.Windows.Forms.Label instancja_czasu)
        {
            instancja_tekstu.Text = "     Błąd    +20s";
            instancja_tekstu.ForeColor = Color.Firebrick;
            instancja_czasu.ForeColor = Color.Firebrick;
            Pierwsza_pomoc.wystapil_blad = true;
            Pierwsza_pomoc.stopwatch.Stop();
            Pierwsza_pomoc.stopwatch.Reset();
            Pierwsza_pomoc.stopwatch.Start();
        }
        static public void animacje(System.Windows.Forms.Label instancja_tekstu, System.Windows.Forms.Label instancja_czasu)
        {
            if (Pierwsza_pomoc.wystapil_blad == true)
            {
                Pierwsza_pomoc.stopwatch.Stop();

                TimeSpan ts = new TimeSpan();
                ts = Pierwsza_pomoc.stopwatch.Elapsed;

                Pierwsza_pomoc.stopwatch.Start();

                double delta = ts.TotalMilliseconds;

                if (delta > 1000)
                {
                    instancja_tekstu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    instancja_tekstu.Text = "ZBADAJ FASOLKE";
                    instancja_czasu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    Pierwsza_pomoc.wystapil_blad = false;
                }
            }
        }
    }
}
