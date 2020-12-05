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
        int ticks=0;
        int flaga = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            CZAS_BOX.Text = "CZAS " + Czas.Wyswietl_czas(ticks);   //Wyświetlanie czasu
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
                
           
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pictureBox1.Image = global::RKO_2020.Properties.Resources.ucisk;
            //label1.Text = "nacisnąłeś" + e.KeyChar;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (flaga == 0)
            {
                pictureBox1.Image = global::RKO_2020.Properties.Resources.ucisk;
                flaga = 1;
            }
            else
            {
                pictureBox1.Image = global::RKO_2020.Properties.Resources.gotowy_do_ucisku;
                flaga = 0;
            }
            textBox1.Text = "nacisnąłeś " + e.KeyChar;

        }
    }
}
