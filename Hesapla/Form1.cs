using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapla
{
    public partial class Form1 : Form
    {
        public double toplam=0.0;
        public string islem;
        public int degistir = 0;

        public Form1()
        { 
            InitializeComponent();
           
        }

        private void Sifirla_Click(object sender, EventArgs e)
        {
            toplam = 0.0;
            islem =" ";
            sayi1.Clear();


        }

        private void Esittir_Click(object sender, EventArgs e)
        {

            if(islem == "+")
            {
                toplam = toplam + Convert.ToDouble(sayi1.Text);
                sayi1.Text = Convert.ToString(toplam);
                toplam = 0.0;
            }
            if (islem == "-")
            {
                toplam = toplam - Convert.ToDouble(sayi1.Text);
                sayi1.Text = Convert.ToString(toplam);
                toplam = 0.0;
            }
            if (islem == "*")
            {
             
                toplam = toplam * Convert.ToDouble(sayi1.Text);
                sayi1.Text = Convert.ToString(toplam);
                toplam = 0.0;
            }
            if (islem == "/")
            {
                if (Convert.ToDouble(sayi1.Text) == 0)
                {
                    sayi1.Text = "Tanımsız";
                }
                else
                {
                    toplam = toplam / Convert.ToDouble(sayi1.Text);
                    sayi1.Text = Convert.ToString(toplam);
                    toplam = 0.0;

                }

            }
        }

        private void Topla_Click(object sender, EventArgs e)
        {
           
           if (sayi1.Text.Trim() != "" )
            {
                toplam = toplam + Convert.ToDouble(sayi1.Text);
                islem = "+";
                sayi1.Clear();
            }

        }

        private void Cikar_Click(object sender, EventArgs e)
        {
            if (sayi1.Text.Trim() != "")
            {
                toplam = Convert.ToDouble(sayi1.Text) - toplam;
                islem = "-";
                sayi1.Clear();
            }
        }

        private void Carp_Click(object sender, EventArgs e)
        {
            if (sayi1.Text.Trim() != "")
            {
                toplam = 1;
                toplam = toplam * Convert.ToDouble(sayi1.Text);
                islem = "*";
                sayi1.Clear();
            }
        }

        private void Bol_Click(object sender, EventArgs e)
        {
            if (sayi1.Text.Trim() != "")
            {
                toplam = 1;
                toplam = Convert.ToDouble(sayi1.Text) / toplam;
                islem = "/";
                sayi1.Clear();
            }
        }

        private void Eksi_koy_Click(object sender, EventArgs e)
        {

            if (degistir == 0)
            {
                sayi1.Text = "-";
                degistir = 1;
            }
            else if (degistir == 1)
            {
                sayi1.Text = "+";
                degistir = 0;
            }
                
        }

        private void Yuzde_Click(object sender, EventArgs e)
        {
            if(sayi1.Text.Trim() != "")
            {
                toplam = Convert.ToDouble(sayi1.Text) / 100;
                sayi1.Text = toplam.ToString();
                toplam = 0;
            }

        }
    }
}
