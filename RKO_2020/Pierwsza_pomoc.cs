using System;
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
        public Bitmap obraz_bazowy = Properties.Resources.pozycja_startowa;
        public Bitmap obraz_zaznaczonej_głowy = Properties.Resources.Przed_położeniem_głowy_zaznaczenie;
        public Bitmap obraz_zaznaczonego_tułowia = Properties.Resources.pozycja_startowa_zaznaczenie_ciała;
        public Bitmap obraz_bazowy_obserwatora = Properties.Resources.obserwator;
        public Bitmap obraz_zaznaczonego_obserwatora = Properties.Resources.obserwator_zaznaczony;
        static public List<Bitmap> lista_obrazow = new List<Bitmap>();
        static public Stopwatch stopwatch = new Stopwatch();
        static public bool wystapil_blad = false;
        static public bool etap2_nierozpoczety;
        static public bool fasolka_oddycha = false;
        static public int stan_postepu;
        static public int wybrany_panel;
        static public int ticks;
        static public int animacja = 0;

        public Pierwsza_pomoc()
        {
            stan_postepu = 1;
            etap2_nierozpoczety = true;
            ticks = 0;
            lista_obrazow.Add(obraz_bazowy);
            lista_obrazow.Add(obraz_zaznaczonej_głowy);
            lista_obrazow.Add(obraz_zaznaczonego_tułowia);
            lista_obrazow.Add(obraz_bazowy_obserwatora);
            lista_obrazow.Add(obraz_zaznaczonego_obserwatora);
        }
        public void obsługa_wyboru(int nr_opcji, Label instancja_tekstu, Label instancja_czasu, List<Panel> lista_dymkow, List<PictureBox> lista_pictureBoxow, Panel panel_koncowy_etapu)
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
                        interfejs.wyświetl_obraz(Properties.Resources.odchylona_głowa, lista_pictureBoxow[0]);
                        lista_obrazow[0] = Properties.Resources.odchylona_głowa;
                        lista_obrazow[1] = Properties.Resources.odchylona_glowa_zanaczenie_glowy;
                        lista_obrazow[2] = Properties.Resources.odchylona_glowa_zanaczenie_tulowia;
                    }
                    else if (wybrany_panel == 3 && stan_postepu == 4 && fasolka_oddycha == true) stan_postepu = 5;
                    else interfejs.obsługa_błędu_użytkownika(instancja_tekstu, instancja_czasu);
                    break;
                case 2:
                    if (wybrany_panel == 2 && stan_postepu == 3)
                    {
                        stan_postepu = 4;
                        interfejs.inicjalizacja_animacji(lista_dymkow, lista_pictureBoxow);
                    }
                    else if (wybrany_panel == 3 && stan_postepu == 4 && fasolka_oddycha == false)
                    {
                        stan_postepu = 5;
                        interfejs.wyświetl_obraz(Properties.Resources.obserwator_z_telefonem, lista_pictureBoxow[1]);
                        lista_obrazow[3] = Properties.Resources.obserwator_z_telefonem;
                    }
                    else if (wybrany_panel == 1 && stan_postepu == 5 && fasolka_oddycha == true) stan_postepu = 6;
                    else interfejs.obsługa_błędu_użytkownika(instancja_tekstu, instancja_czasu);
                    break;
                default:
                    if (wybrany_panel == 1 && stan_postepu == 5 && fasolka_oddycha == false)
                    {
                        stan_postepu = 6;
                        interfejs.wyswietl_panel(panel_koncowy_etapu,5);
                    }
                    else interfejs.obsługa_błędu_użytkownika(instancja_tekstu, instancja_czasu);
                    break;
            }
        }
        public void skonczyl_sie_czas(Panel panel_czas_minal)
        {
            if(ticks > 120)
            {
                interfejs.wyswietl_panel(panel_czas_minal, 4);
            }
        }
    }
}
