using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Polimorfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            //MessageBox.Show(ey.SunumSekli());
            YemekSunumSekliGoster(ey);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sy = new SebzeYemekleri();
            //MessageBox.Show(sy.SunumSekli());
            YemekSunumSekliGoster(sy);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AraSıcaklar araSıcak = new AraSıcaklar();
            //MessageBox.Show(araSıcak.SunumSekli());
            YemekSunumSekliGoster(araSıcak);
        }

        void YemekSunumSekliGoster(Yemek ymk)
        {
            MessageBox.Show(ymk.SunumSekli());
        }
    }
}
