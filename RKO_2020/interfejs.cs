using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RKO_2020
{
    public class interfejs : Pierwsza_pomoc
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
            switch (wybrany_panel)
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
        static public void obsługa_błędu_użytkownika(System.Windows.Forms.Label instancja)
        {
            instancja.Text = "     Błąd    +20s";
        }
    }
}
