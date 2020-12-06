using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RKO_2020
{
    public partial class Form1 : Form
    {
        
        
        public static Czas czas = new Czas();
        Resuscytacja etap2 = new Resuscytacja();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CZAS_BOX.Text = czas.Wyswietl_czas();   //Wyświetlanie czasu
        }
        /*private void timer_sprawdzający_Tick(object sender, EventArgs e)
        {
            etap2.Aktualizacja_Życia_Brak_Reakcji();
            Poziom_Życia.Text=etap2.Wyświetl_Życie();
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  ///wciskanie przycisku spacji
        {
            if(e.KeyValue == 32) { 
                etap2.Aktualizacja_Życia_Przycisk(); // metoda aktualizująca stan życia po kliknięciu przycisku
                                                    //(za wczesnie -5% życia; idealnie w czas +5%)
                pictureBox1.Image = global::RKO_2020.Properties.Resources.ucisk;  //Wyswietl uciskajacą faloske
                Poziom_Życia.Text = etap2.Wyświetl_Życie();  //Wyswietl poziom zycia
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)     ///pusczenie przycisku spacji
        {
            pictureBox1.Image = global::RKO_2020.Properties.Resources.gotowy_do_ucisku;
            etap2.wciśnięty_przycisk = false;
        }
    }
}
