﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RKO_2020
{
    public class Pierwsza_pomoc
    {
        static public List<Bitmap> lista_obrazow = new List<Bitmap>();
        static public Stopwatch stopwatch = new Stopwatch();
        static public  Random rdn = new Random();
        static public bool wystapil_blad = false;
        static public bool etap2_nierozpoczety;
        static public int przypadek;
        static public int stan_postepu;
        static public int wybrany_panel;
        static public int ticks;
        static public int animacja;
        static public bool czy_czas_minal = false;

        public Pierwsza_pomoc()
        {
            stan_postepu = 1;
            etap2_nierozpoczety = true;
            ticks = 0;
            wybrany_panel = 1;
            animacja = 0;

            lista_obrazow.Add(Properties.Resources.pozycja_startowa);
            lista_obrazow.Add(Properties.Resources.Przed_położeniem_głowy_zaznaczenie);
            lista_obrazow.Add(Properties.Resources.pozycja_startowa_zaznaczenie_ciała);
            lista_obrazow.Add(Properties.Resources.obserwator);
            lista_obrazow.Add(Properties.Resources.obserwator_zaznaczony);

            przypadek = ((int)rdn.Next(1, 50))/30 + 1;
        }
        public void obsługa_wyboru(int nr_opcji, Label instancja_tekstu, Label instancja_czasu, List<Panel> lista_dymkow, List<PictureBox> lista_pictureBoxow, List<Panel> panel_koncowy_etapu)
        {
            switch (nr_opcji)
            {
                case 1:
                    if (wybrany_panel == 1 && stan_postepu == 1)
                    {
                        stan_postepu = 2;
                        interfejs.inicjalizacja_animacji(lista_dymkow, lista_pictureBoxow);
                    }
                    else if (wybrany_panel == 2 && stan_postepu == 2)
                    {
                        stan_postepu = 3;
                        interfejs.wyswietl_obraz(Properties.Resources.odchylona_głowa, lista_pictureBoxow[0]);
                        lista_obrazow[0] = Properties.Resources.odchylona_głowa;
                        lista_obrazow[1] = Properties.Resources.odchylona_glowa_zanaczenie_glowy;
                        lista_obrazow[2] = Properties.Resources.odchylona_glowa_zanaczenie_tulowia;
                    }
                    else if (wybrany_panel == 3 && stan_postepu == 4 && przypadek == 2)
                    {
                        stan_postepu = 5;
                        interfejs.wyswietl_obraz(Properties.Resources.obserwator_z_telefonem, lista_pictureBoxow[1]);
                        lista_obrazow[3] = Properties.Resources.obserwator_z_telefonem;
                    }
                    else interfejs.obsluga_bledu_uzytkownika(instancja_tekstu, instancja_czasu);
                    break;
                case 2:
                    if (wybrany_panel == 2 && stan_postepu == 3)
                    {
                        stan_postepu = 4;
                        interfejs.inicjalizacja_animacji(lista_dymkow, lista_pictureBoxow);
                    }
                    else if (wybrany_panel == 3 && stan_postepu == 4 && przypadek == 1)
                    {
                        stan_postepu = 5;
                        interfejs.wyswietl_obraz(Properties.Resources.obserwator_z_telefonem, lista_pictureBoxow[1]);
                        lista_obrazow[3] = Properties.Resources.obserwator_z_telefonem;
                    }
                    else if (wybrany_panel == 1 && stan_postepu == 5 && przypadek == 2)
                    {
                        stan_postepu = 6;

                        lista_obrazow[0]= Properties.Resources.pozycja_boczna_bezpieczna_wyprostowany_bohater;
                        lista_obrazow[1] = Properties.Resources.pozycja_boczna_bezpieczna_wyprostowany_bohater;
                        lista_obrazow[2] = Properties.Resources.pozycja_boczna_bezpieczna_wyprostowany_bohater;

                        interfejs.koniec_gry(panel_koncowy_etapu[7], new Timer(), true, lista_pictureBoxow);
                        interfejs.wyswietl_panel(panel_koncowy_etapu[7], 5);
                        interfejs.inicjalizacja_animacji(lista_dymkow, lista_pictureBoxow);
                    }
                    else interfejs.obsluga_bledu_uzytkownika(instancja_tekstu, instancja_czasu);
                    break;
                default:
                    if (wybrany_panel == 1 && stan_postepu == 5 && przypadek == 1)
                    {
                        stan_postepu = 6;
                        interfejs.wyswietl_panel(panel_koncowy_etapu[4],5);
                    }
                    else interfejs.obsluga_bledu_uzytkownika(instancja_tekstu, instancja_czasu);
                    break;
            }
        }
        public void skonczyl_sie_czas(List<Panel> lista_paneli, Form Form1, List<PictureBox> lista_PictureBoxow)
        {
            if(ticks > 180 && !czy_czas_minal)
            {
                interfejs.zablokuj_wybieranie_paneli(lista_PictureBoxow);
                czy_czas_minal = true;
                interfejs.wylacz_panel(lista_paneli, Form1);
                interfejs.wyswietl_panel(lista_paneli[3], 4);
            }
        }
    }
}
