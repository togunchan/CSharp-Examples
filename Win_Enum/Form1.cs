using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Ahmet";
            ogr.Alani = Alan.EsitAgirlik;

            Ogrenci o2 = new Ogrenci();
            o2.Alani = Alan.Sayisal;
            o2.Cinsiyet = Cinsiyet.Erkek;
            o2.Alani = (Alan)20;
            int sys = (int)Alan.Sayisal;
            MessageBox.Show(Enum.GetName(typeof(Alan), o2.Alani));

            string[] alanlar = Enum.GetNames(typeof(Alan));
            
        }
    }
}
