using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
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
        public bool etap2_nierozpoczęty;
        public int stan_postępu;
        static public int wybrany_panel;
        static public int ticks;
        public Pierwsza_pomoc()
        {
            this.stan_postępu = 1;
            this.etap2_nierozpoczęty = true;
            ticks = 0;
        }
        public void obsługa_wyboru(int nr_opcji, System.Windows.Forms.Label instancja)
        {
            switch (nr_opcji)
            {
                case 1:
                    if (wybrany_panel == 1 && stan_postępu == 1) stan_postępu = 2;
                    else interfejs.obsługa_błędu_użytkownika(instancja);
                    break;
                case 2:
                    if (wybrany_panel == 1 && stan_postępu == 4) stan_postępu = 2;
                    else interfejs.obsługa_błędu_użytkownika(instancja);
                    break;
                default:
                    if (wybrany_panel == 1 && stan_postępu == 4) stan_postępu = 2;
                    else interfejs.obsługa_błędu_użytkownika(instancja);
                    break;
            }
        }
    }
}
