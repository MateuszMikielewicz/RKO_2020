using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace RKO_2020
{
    public class interfejs
    {
        static public void reset(List<Panel> lista_paneli_wyboru, List<PictureBox> lista_pictureBoxow, RadioButton radioButton_nie, 
                                Form form1, Label label1, Label Poziom_Zycia_label, Timer timer_przybycia_medykow, List<Panel>lista_dymków)
        {
            Pierwsza_pomoc.przypadek = Pierwsza_pomoc.rdn.Next(1, 50) / 30 + 1;
            Console.WriteLine(Pierwsza_pomoc.przypadek);

            Pierwsza_pomoc.stan_postepu = 1;
            Resuscytacja.czy_trwa_resuscytacja = false;
            Pierwsza_pomoc.ticks = 0;
            Resuscytacja.Poziom_Zycia = 0;
            Resuscytacja.zle_uciski = 1;
            Resuscytacja.idealne_uciski = 1;
            Pierwsza_pomoc.czy_czas_minal = false;

            timer_przybycia_medykow.Enabled = false;

            radioButton_nie.Checked = true;

            foreach (Control ctrl in lista_dymków[2].Controls)
            {
                if (ctrl is Label)
                {
                    if (Pierwsza_pomoc.przypadek == 1)
                    {
                        ctrl.Text = "Nie oddycha";
                    }
                    else ctrl.Text = "Oddycha";
                }
            }

            label1.Show();
            label1.ForeColor = Color.White;
            label1.Text = "         ZBADAJ FASOLKE";

            Poziom_Zycia_label.Hide();

            lista_pictureBoxow[1].Enabled= true ;
            lista_pictureBoxow[2].Show();
            lista_pictureBoxow[3].Show();

            lista_paneli_wyboru[0].Hide();
            lista_paneli_wyboru[1].Hide();
            lista_paneli_wyboru[2].Hide();
            lista_paneli_wyboru[3].Hide();
            lista_paneli_wyboru[4].Hide();
            lista_paneli_wyboru[5].Hide();
            lista_paneli_wyboru[6].Hide();
            lista_paneli_wyboru[7].Hide();

            form1.Focus();

            String[] lista_ocen = new String[] { "ocena koncowa: ", "ocena resuscytacji: ", "ocena pierwszej pomocy: " };

            int i = 2;
            for (int y = 5; y < 8; y++)
            {
                foreach (Control ctrl in lista_paneli_wyboru[y].Controls)
                {
                    if (ctrl.TabIndex!=4)
                    {
                        if (ctrl is Label)
                        {
                            ctrl.Text = lista_ocen[i];
                            i--;
                        }
                        if (i == -1)
                        {
                            if (y == 6) i = 2;
                            else i = 0;
                        }
                    }
                }
            }

            Pierwsza_pomoc.lista_obrazow[0]=Properties.Resources.pozycja_startowa;
            Pierwsza_pomoc.lista_obrazow[1]=Properties.Resources.Przed_położeniem_głowy_zaznaczenie;
            Pierwsza_pomoc.lista_obrazow[2]=Properties.Resources.pozycja_startowa_zaznaczenie_ciała;
            Pierwsza_pomoc.lista_obrazow[3]=Properties.Resources.obserwator;
            Pierwsza_pomoc.lista_obrazow[4]=Properties.Resources.obserwator_zaznaczony;

            lista_pictureBoxow[0].Image = Pierwsza_pomoc.lista_obrazow[0];
            lista_pictureBoxow[1].Image = Pierwsza_pomoc.lista_obrazow[3];
            lista_pictureBoxow[4].Image = Properties.Resources.none_image;
            lista_pictureBoxow[5].Image = Properties.Resources.none_image;
        }
        static public void inicjalizuj_etap1(List<Panel> lista_paneli_wyboru, List<PictureBox> lista_pictureBoxow, RadioButton radioButton_nie,
                                             List<Panel> lista_dymkow)
        {
            radioButton_nie.Checked = true;
            //inicjalizacja niewidocznych przycisków(pictureboxów) na obiekcie picturebox
            lista_pictureBoxow[2].Parent = lista_pictureBoxow[0];
            lista_pictureBoxow[2].Location = new Point(78, 115);
            lista_pictureBoxow[2].Show();
            lista_pictureBoxow[3].Parent = lista_pictureBoxow[0];
            lista_pictureBoxow[3].Location = new Point(0, 76);
            lista_pictureBoxow[3].Show();
            lista_pictureBoxow[4].Image = Properties.Resources.none_image;
            lista_pictureBoxow[5].Image = Properties.Resources.none_image;

            for (int i = 3; i <= 7; i++)
            {
                lista_paneli_wyboru[i].Location = new Point(62, 13);
            }

            foreach (Control ctrl in lista_dymkow[2].Controls)
            {
                if (ctrl is Label)
                {
                    if (Pierwsza_pomoc.przypadek != 1)
                    {
                        ctrl.Text = "   Oddycha";
                    }
                }
            }
        }
        static public String Wyswietl_czas()
        {
            if (Pierwsza_pomoc.stan_postepu != 6)
            {
                Pierwsza_pomoc.ticks++;
            }

            int sekundy = Pierwsza_pomoc.ticks - 60 * (Pierwsza_pomoc.ticks / 60);

            if (sekundy < 10)
            {
                return "CZAS " + (Pierwsza_pomoc.ticks / 60).ToString() + ":0" + sekundy.ToString();
            }
            return "CZAS " + (Pierwsza_pomoc.ticks / 60).ToString() + ":" + sekundy.ToString();
        }
        static public void wyswietl_obraz(Bitmap bitmap, System.Windows.Forms.PictureBox instancja)
        {
            if (Pierwsza_pomoc.animacja == 0)
            {
                instancja.Image = (Image)bitmap;
            }
        }
        static public void zmien_label(Label instancja, String napis, Color kolor, bool zmienic_napis)
        {
            if(zmienic_napis)instancja.Text = napis;

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
        static public void wylacz_panel(List<Panel> lista_paneli_wyboru, Form Form1 )
        {
            lista_paneli_wyboru[Pierwsza_pomoc.wybrany_panel-1].Hide();
            Form1.Focus();
        }
        static public void obsluga_bledu_uzytkownika(Label instancja_tekstu, Label instancja_czasu)
        {
            Pierwsza_pomoc.ticks += 20;
            instancja_tekstu.Text = "         Błąd    +20s";
            instancja_tekstu.ForeColor = Color.Firebrick;
            instancja_czasu.ForeColor = Color.Firebrick;
            Pierwsza_pomoc.wystapil_blad = true;
            Pierwsza_pomoc.stopwatch.Stop();
            Pierwsza_pomoc.stopwatch.Reset();
            Pierwsza_pomoc.stopwatch.Start();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = "nie_nie[WAV].wav";
            player.Play();
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
               case 6:
                    Pierwsza_pomoc.animacja = 3;
                    lista_pictureBoxow[0].Image = Properties.Resources.pozycja_boczna_bezpieczna_skulony_bohater;
                    Pierwsza_pomoc.stopwatch.Stop();
                    Pierwsza_pomoc.stopwatch.Reset();
                    Pierwsza_pomoc.stopwatch.Start();
                    break;
            }

        }
        static public void animacje(Label instancja_tekstu,Label instancja_czasu,
                                    List<PictureBox> lista_pictureBoxow, List<Panel> lista_dymkow)
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
                    instancja_tekstu.Text = "         ZBADAJ FASOLKE";
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
                    lista_pictureBoxow[0].Image = Properties.Resources.pozycja_startowa;
                    Pierwsza_pomoc.animacja = 0;
                }

            }
            else if(Pierwsza_pomoc.animacja==2)
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
                    lista_pictureBoxow[0].Image = Properties.Resources.odchylona_głowa;
                }
                else if (delta > 3000)
                {
                    lista_dymkow[2].Hide();
                    Pierwsza_pomoc.animacja = 0;
                }
            }
            else if (Pierwsza_pomoc.animacja == 3)
            {
                Pierwsza_pomoc.stopwatch.Stop();

                TimeSpan ts = new TimeSpan();
                ts = Pierwsza_pomoc.stopwatch.Elapsed;

                Pierwsza_pomoc.stopwatch.Start();

                double delta = ts.TotalMilliseconds;
                if (3000 > delta && delta > 1500)
                {
                    lista_pictureBoxow[0].Image = Properties.Resources.pozycja_boczna_bezpieczna_wyprostowany_bohater;
                }
                else if (delta > 3000)
                {
                    lista_pictureBoxow[4].Image = Properties.Resources.medyk1;
                    lista_pictureBoxow[5].Image = Properties.Resources.medyk1;
                    Pierwsza_pomoc.animacja = 0;
                }
            }
        }
        static public void rozpocznij_etap2(List<PictureBox> lista_pictureBoxow, Label label1, Label Poziom_Zycia,
                                            Panel panel_konca_etapu, Timer timer_przybycia_medykow) //, List<Panel> lista_paneli_wyboru)
        {
            if (Resuscytacja.chalenge == 0)
            {
                label1.Show();
                Poziom_Zycia.Show();
            }
            else
            {
                label1.Hide();
                Poziom_Zycia.Hide();
            }
            label1.Text = "Kliknij spacje, aby ucisnac";
            timer_przybycia_medykow.Enabled = true;
            Resuscytacja.czy_trwa_resuscytacja = true;
            panel_konca_etapu.Hide();
            lista_pictureBoxow[2].Hide();
            lista_pictureBoxow[3].Hide();
            lista_pictureBoxow[0].Image = Properties.Resources.gotowy_do_ucisku;
            lista_pictureBoxow[1].Enabled = false;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = "BE_GEES_Staying_Alive.wav";
            player.Play();
        }
        static public void koniec_gry(Control panel_koncowy, Timer timer_przybycia_medykow,bool czy_medycy_przybyli,
                                      List<PictureBox> lista_pictureBox)
        {
            if(Pierwsza_pomoc.przypadek==2)
            {
                int i = 1;
                foreach (Control ctrl in panel_koncowy.Controls)
                {
                    if (ctrl.TabIndex != 4)
                    {
                        if (ctrl is Label && i >= 1)
                        {
                            ctrl.Text += wyniki_koncowe(i, Resuscytacja.zle_uciski, Resuscytacja.idealne_uciski, Resuscytacja.chalenge);
                            i--;
                        }
                    }
                }
            }
            else if (czy_medycy_przybyli || (!czy_medycy_przybyli && Resuscytacja.Poziom_Zycia == 100))
            {
                Resuscytacja.czy_trwa_resuscytacja = false;
                timer_przybycia_medykow.Enabled = false;

                int i = 3;
                foreach (Control ctrl in panel_koncowy.Controls)
                {
                    if (ctrl.TabIndex != 4)
                    {
                        if (ctrl is Label && i >= 1)
                        {
                            ctrl.Text += wyniki_koncowe(i, Resuscytacja.zle_uciski, Resuscytacja.idealne_uciski, Resuscytacja.chalenge);
                            i--;
                        }
                    }
                }
                panel_koncowy.Show();
                lista_pictureBox[4].Image = Properties.Resources.medyk1;
                lista_pictureBox[5].Image = Properties.Resources.medyk2;
                if(Resuscytacja.Poziom_Zycia == 100)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                    player.SoundLocation = "Children Yay! Sound Effect.wav";
                    player.Play();
                }
            }
        }
        static public String wyniki_koncowe(int rodzaj_wyniku, double zle, double dobre, int bonus)
        {
            int x1 = Pierwsza_pomoc.ticks / 30;
            double x2 = dobre / (zle + dobre);
            switch (rodzaj_wyniku)
            {
                case 1:
                    switch (x1)
                    {
                        case 0:
                            return "Mistrzowsko";
                        case 1:
                            return "Swietnie, dobry czas";
                        case 2:
                            return "Dobrze, ale mozesz szybciej";
                        default:
                            return "Musisz jeszcze popracowac";
                    }
                case 2:
                   if(x2 > 0.9)
                    {
                        return "Mistrzowsko";
                    }
                    else if (x2 > 0.8)
                    {
                        return "Swietnie";
                    }
                    else if (x2 > 0.6)
                    {
                        return "Dobrze";
                    }
                    else if (x2 > 0.5)
                    {
                        return "Musisz jeszcze popracowac";
                    }
                    else return "Slabo, sprobuj jeszcze raz";
                default:
                    int x3 = (int)(-x1 + 3 + 6 * (x2 - 0.5)+bonus);
                    if (x3 > 6) return "7/6 POZA SKALĄ";
                    else return Convert.ToString(x3) + "/6";            
            }
        }
        static public void challenge(RadioButton radioButton_nie)
        {
            if (radioButton_nie.Checked == true) Resuscytacja.chalenge = 0;
            else Resuscytacja.chalenge = 1;
        }
    }
}
