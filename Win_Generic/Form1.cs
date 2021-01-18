using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Win_Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("Ahmet");
            list.Add(123);
            list.Add(true);
            list.Add('a');

            List<string> isimler = new List<string>();
            isimler.Add("ali");
            List<int> sayilar = new List<int>();
            sayilar.Add(123);
            int sayi = sayilar[0];

            Ogrenci<string,int,decimal> o1 = new Ogrenci<string, int, decimal>();

            Ogrenci<Ders,float,bool> o2 = new Ogrenci<Ders, float, bool>();
        }
    }
}
