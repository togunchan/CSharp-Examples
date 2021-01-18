﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_InterfaceUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fernandao f = new Fernandao();
            MessageBox.Show(SutCek(f,20.15f,45));
            ServetCetin sc = new ServetCetin();
            MessageBox.Show(SutCek(sc, 15, 30));
        }

        private string SutCek(ISutCekebilir sut,float hiz, float mesafe)
        {
            return sut.SutCek(hiz, mesafe);
        }
    }
}
