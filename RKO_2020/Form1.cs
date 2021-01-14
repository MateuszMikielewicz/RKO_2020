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
        Resuscytacja etap2 = new Resuscytacja();
        Pierwsza_pomoc etap1 = new Pierwsza_pomoc();
        List<Panel> lista_dymkow = new List<Panel>();
        List<Panel> lista_paneli_wyboru = new List<Panel>();
        List<PictureBox> lista_pictureBoxow = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(684,502);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CZAS_BOX.Text = Wyswietl_czas();   //Wyświetlanie czasu
        }
        private void timer_sprawdzający_Tick(object sender, EventArgs e)
        {
            etap2.Aktualizacja_Zycia(label1, Poziom_Zycia_label, false);
            Poziom_Zycia_label.Text=etap2.Wyswietl_Zycie();
            animacje(label1, CZAS_BOX, lista_pictureBoxow, lista_dymkow);
            etap1.skonczyl_sie_czas(lista_paneli_wyboru, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista_dymkow.Add(dymek_1);
            lista_dymkow.Add(dymek_2);
            lista_dymkow.Add(dymek_3);

            lista_pictureBoxow.Add(głowne_postaci_pictureBox);
            lista_pictureBoxow.Add(obserwator_pictureBox);
            lista_pictureBoxow.Add(tułow_pictureBox);
            lista_pictureBoxow.Add(glowa_pictureBox);
            lista_pictureBoxow.Add(medyk1_picture);
            lista_pictureBoxow.Add(medyk2_picture);

            lista_paneli_wyboru.Add(panel_wyboru1);
            lista_paneli_wyboru.Add(panel_wyboru2);
            lista_paneli_wyboru.Add(panel_wyboru3);
            lista_paneli_wyboru.Add(panel_czas_minal);
            lista_paneli_wyboru.Add(panel_konca_etapu);
            lista_paneli_wyboru.Add(panel_koncowy_1);
            lista_paneli_wyboru.Add(panel_koncowy_2);
            lista_paneli_wyboru.Add(panel_koncowy_3);

            inicjalizuj_etap1(lista_paneli_wyboru, lista_pictureBoxow, radioButton_nie, lista_dymkow);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  ///wciskanie przycisku spacji
        {
            if (!Resuscytacja.czy_trwa_resuscytacja) return;
            else if (e.KeyValue == 32) { 
                etap2.Aktualizacja_Zycia(label1, Poziom_Zycia_label, true); // metoda aktualizująca stan życia po kliknięciu przycisku
                                                                 //(za wczesnie -5% życia; idealnie w czas +5%)
                głowne_postaci_pictureBox.Image = global::RKO_2020.Properties.Resources.ucisk;  //Wyswietl uciskajacą faloske
                Poziom_Zycia_label.Text = etap2.Wyswietl_Zycie();  //Wyswietl poziom zycia 
                koniec_gry(panel_koncowy_1, timer_przybycia_medykow, false, lista_pictureBoxow);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)     ///pusczenie przycisku spacji
        {
            if (!Resuscytacja.czy_trwa_resuscytacja) return;
            else {
                głowne_postaci_pictureBox.Image = global::RKO_2020.Properties.Resources.gotowy_do_ucisku;
                etap2.wcisniety_przycisk = false;
            }
        }

        private void tułow_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            wyswietl_obraz(Pierwsza_pomoc.lista_obrazow[2], głowne_postaci_pictureBox);
        }

        private void tułow_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            wyswietl_obraz(Pierwsza_pomoc.lista_obrazow[0], głowne_postaci_pictureBox);
        }
        
        private void tułow_pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            wylacz_panel(lista_paneli_wyboru, this);
            wyswietl_panel(panel_wyboru1,1);
        }

        private void glowa_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            wyswietl_obraz(Pierwsza_pomoc.lista_obrazow[1], głowne_postaci_pictureBox);
        }

        private void glowa_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            wyswietl_obraz(Pierwsza_pomoc.lista_obrazow[0], głowne_postaci_pictureBox);
        }
        private void glowa_pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            wylacz_panel(lista_paneli_wyboru, this);
            wyswietl_panel(panel_wyboru2, 2);
        }
        private void obserwator_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            wyswietl_obraz(Pierwsza_pomoc.lista_obrazow[4], obserwator_pictureBox);
        }

        private void obserwator_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            wyswietl_obraz(Pierwsza_pomoc.lista_obrazow[3], obserwator_pictureBox);
        }
        private void obserwator_pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            wylacz_panel(lista_paneli_wyboru, this);
            wyswietl_panel(panel_wyboru3, 3);
        }
        private void opcja2_Click(object sender, EventArgs e)
        {
            wylacz_panel(lista_paneli_wyboru, this);
            etap1.obsługa_wyboru(2, label1, CZAS_BOX, lista_dymkow, lista_pictureBoxow, lista_paneli_wyboru);
        }

        private void opcja1_Click(object sender, EventArgs e)
        {
            wylacz_panel(lista_paneli_wyboru, this);
            etap1.obsługa_wyboru(1, label1, CZAS_BOX, lista_dymkow, lista_pictureBoxow, lista_paneli_wyboru);
        }

        private void opcja3_Click(object sender, EventArgs e)
        {
            wylacz_panel(lista_paneli_wyboru, this);
            etap1.obsługa_wyboru(3, label1, CZAS_BOX, lista_dymkow, lista_pictureBoxow, lista_paneli_wyboru);
        }
        private void panel_głowny_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.Text = e.X + ", " + e.Y;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            reset(lista_paneli_wyboru, lista_pictureBoxow, radioButton_nie, this, label1, Poziom_Zycia_label, timer_przybycia_medykow, lista_dymkow);
        }

        private void ZAKONCZ_GRE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DALEJ_Click(object sender, EventArgs e)
        {
            rozpocznij_etap2(lista_pictureBoxow, label1, Poziom_Zycia_label, panel_konca_etapu, timer_przybycia_medykow);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void timer_przybycia_medykow_Tick(object sender, EventArgs e)
        {
            koniec_gry(panel_koncowy_2, timer_przybycia_medykow, true, lista_pictureBoxow);
        }

        private void radioButton_nie_CheckedChanged(object sender, EventArgs e)
        {
            challenge(radioButton_nie);
        }
    }
}
