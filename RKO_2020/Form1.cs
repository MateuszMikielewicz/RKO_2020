using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RKO_2020
{
    public partial class Form1 : Form
    {
        int ticks=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            Czas_box.Text = Wyswietl_czas(ticks);   //Wyświetlanie czasu
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public String Wyswietl_czas(int ticks)
        {
            int sekundy = ticks - 60 * (ticks / 60); ;
            if (sekundy < 10)
            {
                return (ticks / 60).ToString() + ":0" + sekundy.ToString();
            }
            return (ticks / 60).ToString() + ":" + sekundy.ToString();
        }
    }
}
