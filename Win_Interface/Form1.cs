using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = "Çağlar";
            o.Yasi = 23;
            o.YasamDegeri = 100;
            //Kanas kns = new Kanas();
            //o.Silahi = kns; => Aşağıdakiyle aynı
            o.Silahi = new Kanas();
            MessageBox.Show(o.NisanAl());
        }
    }
}
