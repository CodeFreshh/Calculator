using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDziałania = ' ';

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            RodzajDziałania = '/';
            tbWynik.Text = "";
        }

        private void bMnożenie_Click(object sender, EventArgs e)
        {
            RodzajDziałania = '*';
            tbWynik.Text = "";
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            RodzajDziałania = '-';
            tbWynik.Text = "";
        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            RodzajDziałania = '+';
            tbWynik.Text = "";
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            try
            {

                switch (RodzajDziałania)
                {
                    case ('+'):
                        tbWynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                        break;
                    case ('-'):
                        tbWynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                        break;
                    case ('*'):
                        tbWynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                        break;
                    case ('/'):
                        tbWynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                        break;


                }





                LiczbaPierwsza = "";
                LiczbaDruga = "";
                RodzajDziałania = ' ';
            }
            catch (SystemException ex)
            {
                Console.WriteLine("error"); 
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Działanie(0);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Działanie(9);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Działanie(8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Działanie(7);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Działanie(6);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Działanie(5);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Działanie(4);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Działanie(3);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Działanie(2);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Działanie(1);
        }

        private void Działanie(int liczba)
        {
            if (RodzajDziałania == ' ')
            {
                LiczbaPierwsza += liczba;
                tbWynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                tbWynik.Text = LiczbaDruga;
            }

        }
    }
}
