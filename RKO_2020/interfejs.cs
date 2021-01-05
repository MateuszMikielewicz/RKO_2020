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
        static public void reset(List<Panel> lista_paneli_wyboru, List<PictureBox> lista_pictureBoxow, RadioButton radioButton_nie)
        {
            Pierwsza_pomoc.stan_postepu = 1;
            Pierwsza_pomoc.etap2_nierozpoczety = true;
            Pierwsza_pomoc.ticks = 0;


            radioButton_nie.Checked = true;

            lista_pictureBoxow[1].Enabled= true ;
            lista_pictureBoxow[2].Show();
            lista_pictureBoxow[3].Show();

            lista_paneli_wyboru[3].Hide();
            lista_paneli_wyboru[4].Hide();
            lista_paneli_wyboru[5].Hide();

            Pierwsza_pomoc.lista_obrazow[0]=Properties.Resources.pozycja_startowa;
            Pierwsza_pomoc.lista_obrazow[1]=Properties.Resources.Przed_położeniem_głowy_zaznaczenie;
            Pierwsza_pomoc.lista_obrazow[2]=Properties.Resources.pozycja_startowa_zaznaczenie_ciała;
            Pierwsza_pomoc.lista_obrazow[3]=Properties.Resources.obserwator;
            Pierwsza_pomoc.lista_obrazow[4]=Properties.Resources.obserwator_zaznaczony;

            lista_pictureBoxow[0].Image = Pierwsza_pomoc.lista_obrazow[0];
            lista_pictureBoxow[1].Image = Pierwsza_pomoc.lista_obrazow[3];
        }
        static public void inicjalizuj_etap1(List<Panel> lista_paneli_wyboru, List<PictureBox> lista_pictureBoxow, RadioButton radioButton_nie)
        {
            radioButton_nie.Checked = true;
            //inicjalizacja niewidocznych przycisków(pictureboxów) na obiekcie picturebox
            lista_pictureBoxow[2].Parent = lista_pictureBoxow[0];
            lista_pictureBoxow[2].Location = new Point(78, 115);
            lista_pictureBoxow[2].Show();
            lista_pictureBoxow[3].Parent = lista_pictureBoxow[0];
            lista_pictureBoxow[3].Location = new Point(0, 76);
            lista_pictureBoxow[3].Show();

            lista_paneli_wyboru[3].Location = new Point(62, 13);
            lista_paneli_wyboru[4].Location = new Point(62, 13);
            lista_paneli_wyboru[5].Location = new Point(62, 13);

        }
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
                    break;
                case 2:
                    instancja2.Hide();
                    Form1.Focus();   
                    break;
                default:
                    instancja3.Hide();
                    Form1.Focus();
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
                    lista_dymkow[1].Show();
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
                    lista_dymkow[0].Show();
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
                    lista_dymkow[2].Show();
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
        static public void rozpocznij_etap2(List<PictureBox> lista_pictureBoxow,
        System.Windows.Forms.Label label1, System.Windows.Forms.Label Poziom_Zycia, Panel panel_konca_etapu) //, List<Panel> lista_paneli_wyboru)
        {
            {
                Pierwsza_pomoc.etap2_nierozpoczety = false;
                panel_konca_etapu.Hide();
                lista_pictureBoxow[2].Hide();
                lista_pictureBoxow[3].Hide();
                lista_pictureBoxow[0].Image = Properties.Resources.gotowy_do_ucisku;
                lista_pictureBoxow[1].Enabled = false;
                label1.Text="Kliknij spacje, aby ucisnac";
                Poziom_Zycia.Visible = true;
            }
        }
    }
}
