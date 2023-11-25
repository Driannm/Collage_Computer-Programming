using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Konversi_Suhu
{
    public partial class Form1 : Form
    {
        string a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = comboBox1.Text;
            c = comboBox2.Text;
            g = Convert.ToDouble(a);
            if ((b.Equals("celcius")) && (c.Equals("reamur")))
            {
                hitung = g / 5 * 4;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("celcius")) && (c.Equals("fahrenheit")))
            {
                hitung = g / 5 * 9 + 32;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("celcius")) && (c.Equals("kelvin")))
            {
                hitung = g / +273.15;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("reamur")) && (c.Equals("celcius")))
            {
                hitung = g / 4 * 5;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("reamur")) && (c.Equals("fahrenheit")))
            {
                hitung = g / 4 * 9 + 32;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("reamur")) && (c.Equals("kelvin")))
            {
                hitung = g / 4 * 9 + 32;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("fahrenheit")) && (c.Equals("celcius")))
            {
                hitung = (g - 32) / 9 * 5;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("fahrenheit")) && (c.Equals("reamur")))
            {
                hitung = (g - 32) / 9 * 4;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("fahrenheit")) && (c.Equals("kelvin")))
            {
                hitung = (g - 32) / 9 * 5 + 273.15;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("kelvin")) && (c.Equals("celcius")))
            {
                hitung = g - 273.15;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("kelvin")) && (c.Equals("fahrenheit")))
            {
                hitung = (g - 273.15) / 5 * 9 + 32;
                textBox2.Text = hitung.ToString();
            }
            else
            {
                hitung = (g - 273.15) / 5 * 4;
                textBox2.Text = hitung.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        double g, hitung;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
