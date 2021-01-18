using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Takim tkm = new Takim();

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = textBox1.Text;
            o.DogumTarihi = DateTime.Now;
            o.FormaNo = 10;
            o.Mevkisi = "Ön Libero";
            o.Soyadi = "Sırkıntı";
            o.Uyrugu = "Papua Yeni Gine";

            tkm.Oyuncular.Add(o);
            listBox1.Items.Add(o.Adi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkm.Adi = "B404 Spor";
            tkm.KurulusYili = Convert.ToDateTime("25.09.2015");
            tkm.StadIsmi = "B Sınıfı";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (Oyuncu o  in tkm.Oyuncular)
            {
                listBox2.Items.Add(o.Adi);
            }
        }
    }
}
