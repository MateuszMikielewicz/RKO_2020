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
            czas.ticks++;
            CZAS_BOX.Text = czas.Wyswietl_czas();   //Wyświetlanie czasu
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  ///wciskanie przycisku spacji
        {
            if(e.KeyValue == 32) {
                etap2.Wzrost_Życia();
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
