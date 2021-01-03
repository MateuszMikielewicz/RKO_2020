using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static RKO_2020.interfejs;

namespace RKO_2020
{
    public partial class Form1 : Form
    {
        public static Czas czas = new Czas();
        Resuscytacja etap2 = new Resuscytacja();
        Pierwsza_pomoc etap1 = new Pierwsza_pomoc();

       
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CZAS_BOX.Text = Wyswietl_czas();   //Wyświetlanie czasu
        }
        private void timer_sprawdzający_Tick(object sender, EventArgs e)
        {
            etap2.Aktualizacja_Życia_Przycisk(label1, false);
            Poziom_Życia.Text=etap2.Wyświetl_Życie();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           //inicjalizacja niewidocznych przycisków(pictureboxów) na obiekcie picturebox
            tułow_pictureBox.Parent = głowne_postaci_pictureBox;
            tułow_pictureBox.Location = new Point(78, 115);
            glowa_pictureBox.Parent = głowne_postaci_pictureBox;
            glowa_pictureBox.Location = new Point(0, 76);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  ///wciskanie przycisku spacji
        {
            if (etap1.etap2_nierozpoczęty) return;
            else if (e.KeyValue == 32) { 
                etap2.Aktualizacja_Życia_Przycisk(label1, true); // metoda aktualizująca stan życia po kliknięciu przycisku
                                                                 //(za wczesnie -5% życia; idealnie w czas +5%)
                głowne_postaci_pictureBox.BackgroundImage = global::RKO_2020.Properties.Resources.ucisk;  //Wyswietl uciskajacą faloske
                Poziom_Życia.Text = etap2.Wyświetl_Życie();  //Wyswietl poziom zycia
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)     ///pusczenie przycisku spacji
        {
            if (etap1.etap2_nierozpoczęty) return;
            else {
                głowne_postaci_pictureBox.BackgroundImage = global::RKO_2020.Properties.Resources.gotowy_do_ucisku;
                etap2.wciśnięty_przycisk = false;
            }
        }

        private void tułow_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            wyświetl_obraz(etap1.obraz_zaznaczonego_tułowia, głowne_postaci_pictureBox);
        }

        private void tułow_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            wyświetl_obraz(etap1.obraz_bazowy, głowne_postaci_pictureBox);
        }
        
        private void tułow_pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            wyświetl_panel(panel_wyboru1,1);
        }

        private void glowa_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            wyświetl_obraz(etap1.obraz_zaznaczonej_głowy, głowne_postaci_pictureBox);
        }

        private void glowa_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            wyświetl_obraz(etap1.obraz_bazowy, głowne_postaci_pictureBox);
        }

        private void obserwator_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            wyświetl_obraz(Properties.Resources.obserwator_zaznaczony, obserwator_pictureBox);
        }

        private void obserwator_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            wyświetl_obraz(Properties.Resources.obserwator, obserwator_pictureBox);
        }

        private void opcja2_Click(object sender, EventArgs e)
        {
            etap1.obsługa_wyboru(2, label1);
            wyłącz_panel(panel_wyboru1, panel_wyboru2, panel_wyboru3);
        }

        private void opcja1_Click(object sender, EventArgs e)
        {
            etap1.obsługa_wyboru(1, label1);
            wyłącz_panel(panel_wyboru1,panel_wyboru2,panel_wyboru3);
        }

        private void opcja3_Click(object sender, EventArgs e)
        {
            etap1.obsługa_wyboru(3, label1);
            wyłącz_panel(panel_wyboru1, panel_wyboru2, panel_wyboru3);
        }
    }
}
