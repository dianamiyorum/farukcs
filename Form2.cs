using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct ogrenci
        {
            public string ad;
            public string soyad;
            public int numara;
            public string sınıf;
        }

        ogrenci ogrenciler = new ogrenci();

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(ogrenciler.ad);
            listBox1.Items.Add(ogrenciler.soyad);
            listBox1.Items.Add(ogrenciler.numara);
            listBox1.Items.Add(ogrenciler.sınıf);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciler.ad = "faruk";
            ogrenciler.soyad = "basyegit";
            ogrenciler.numara = 268;
            ogrenciler.sınıf = "11b";

        }

    }
}

