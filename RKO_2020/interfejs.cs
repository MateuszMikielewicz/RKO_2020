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
        static public String Wyswietl_czas()
        {
            Pierwsza_pomoc.ticks++;

            int sekundy = Pierwsza_pomoc.ticks - 60 * (Pierwsza_pomoc.ticks / 60);

            if (sekundy < 10)
            {
                return "CZAS " + (Pierwsza_pomoc.ticks / 60).ToString() + ":0" + sekundy.ToString();
            }
            return "CZAS " + (Pierwsza_pomoc.ticks / 60).ToString() + ":" + sekundy.ToString();
        }
        static public void wyświetl_obraz(Bitmap bitmap, System.Windows.Forms.PictureBox instancja)
        {
            if (Pierwsza_pomoc.animacja == 0)
            {
                instancja.Image = (Image)bitmap;
            }
        }
        static public void zmień_label(System.Windows.Forms.Label instancja, String napis, Color kolor)
        {
            instancja.Text = napis;
            instancja.ForeColor = kolor;
        }
        static public void wyswietl_panel(System.Windows.Forms.Panel instancja, int nr_panelu)
        {
            if (Pierwsza_pomoc.animacja == 0)
            {
                instancja.Enabled = true;
                instancja.Show();
                Pierwsza_pomoc.wybrany_panel = nr_panelu;
            }
        }
        static public void wyłącz_panel(System.Windows.Forms.Panel instancja1, System.Windows.Forms.Panel instancja2, System.Windows.Forms.Panel instancja3, System.Windows.Forms.Form Form1 )
        {
            switch (Pierwsza_pomoc.wybrany_panel)
            {
                case 1:
                    instancja1.Hide();
                    Form1.Focus();
                    instancja1.Enabled = false;
                    break;
                case 2:
                    instancja2.Hide();
                    Form1.Focus();   
                    instancja2.Enabled = false;
                    break;
                default:
                    instancja3.Hide();
                    Form1.Focus();
                    instancja3.Enabled = false;
                    break;
            }
        }
        static public void obsługa_błędu_użytkownika(System.Windows.Forms.Label instancja_tekstu, System.Windows.Forms.Label instancja_czasu)
        {
            Pierwsza_pomoc.ticks += 20;
            instancja_tekstu.Text = "     Błąd    +20s";
            instancja_tekstu.ForeColor = Color.Firebrick;
            instancja_czasu.ForeColor = Color.Firebrick;
            Pierwsza_pomoc.wystapil_blad = true;
            Pierwsza_pomoc.stopwatch.Stop();
            Pierwsza_pomoc.stopwatch.Reset();
            Pierwsza_pomoc.stopwatch.Start();
        }
        static public void inicjalizacja_animacji(List<Panel> lista_dymkow, List<PictureBox> lista_pictureBoxow)
        {
            switch (Pierwsza_pomoc.stan_postepu)
            {
                case 2:
                    Pierwsza_pomoc.animacja = 1;
                    lista_pictureBoxow[0].Image = Properties.Resources.skulony_bohater_pozycja_startowa;
                    lista_dymkow[1].Location = new Point(271, 127);
                    Pierwsza_pomoc.stopwatch.Stop();
                    Pierwsza_pomoc.stopwatch.Reset();
                    Pierwsza_pomoc.stopwatch.Start();
                    break;
                case 4:
                    Pierwsza_pomoc.animacja = 2;
                    lista_pictureBoxow[0].Image = Properties.Resources.skulony_bohater_odchylona_glowa;
                    Pierwsza_pomoc.stopwatch.Stop();
                    Pierwsza_pomoc.stopwatch.Reset();
                    Pierwsza_pomoc.stopwatch.Start();
                    break;
                default:
                    
                    break;
            }

        }
        static public void animacje(System.Windows.Forms.Label instancja_tekstu, System.Windows.Forms.Label instancja_czasu, System.Windows.Forms.PictureBox instancja_pictureBox, List<Panel> lista_dymkow)
        {
            if (Pierwsza_pomoc.wystapil_blad == true)
            {
                Pierwsza_pomoc.stopwatch.Stop();

                TimeSpan ts = new TimeSpan();
                ts = Pierwsza_pomoc.stopwatch.Elapsed;

                Pierwsza_pomoc.stopwatch.Start();

                double delta = ts.TotalMilliseconds;

                if (delta > 1500)
                {
                    instancja_tekstu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    instancja_tekstu.Text = "ZBADAJ FASOLKE";
                    instancja_czasu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    Pierwsza_pomoc.wystapil_blad = false;
                }
            }
            if (Pierwsza_pomoc.animacja == 1)
            {
                Pierwsza_pomoc.stopwatch.Stop();

                TimeSpan ts = new TimeSpan();
                ts = Pierwsza_pomoc.stopwatch.Elapsed;

                Pierwsza_pomoc.stopwatch.Start();

                double delta = ts.TotalMilliseconds;
                if (3000 > delta && delta > 1500)
                {
                    lista_dymkow[1].Hide();
                    lista_dymkow[0].Location= new Point(154,263);
                }
                else if (delta > 3000)
                {
                    lista_dymkow[0].Hide();
                    instancja_pictureBox.Image = Properties.Resources.pozycja_startowa;
                    Pierwsza_pomoc.animacja = 0;
                }

            }
            if(Pierwsza_pomoc.animacja==2)
            {
                Pierwsza_pomoc.stopwatch.Stop();

                TimeSpan ts = new TimeSpan();
                ts = Pierwsza_pomoc.stopwatch.Elapsed;

                Pierwsza_pomoc.stopwatch.Start();

                double delta = ts.TotalMilliseconds;
                if (3000 > delta && delta > 1500)
                {
                    lista_dymkow[2].Location = new Point(271, 127);
                    instancja_pictureBox.Image = Properties.Resources.odchylona_głowa;
                }
                else if (delta > 3000)
                {
                    lista_dymkow[2].Hide();
                    Pierwsza_pomoc.animacja = 0;
                }
            }
        }
        static public void rozpocznij_etap2(System.Windows.Forms.PictureBox instancja_pictureBox1,
        System.Windows.Forms.PictureBox instancja_pictureBox2, List<PictureBox> lista_pictureBoxow,
        System.Windows.Forms.Label label1, System.Windows.Forms.Label Poziom_Zycia) //, List<Panel> lista_paneli_wyboru)
        {
            if (Pierwsza_pomoc.etap2_nierozpoczety == false && Resuscytacja.koniec_inicjalizacji == false)
            {
                instancja_pictureBox1.Hide();
                instancja_pictureBox2.Hide();
                lista_pictureBoxow[0].Image = Properties.Resources.gotowy_do_ucisku;
                lista_pictureBoxow[1].Enabled = false;
                label1.Text="Kliknij spacje, aby ucisnac";
                Poziom_Zycia.Visible = true;
                Resuscytacja.koniec_inicjalizacji = true;
            }
        }
    }
}
