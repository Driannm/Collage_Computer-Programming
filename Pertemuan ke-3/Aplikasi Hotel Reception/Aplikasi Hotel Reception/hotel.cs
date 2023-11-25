using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Hotel_Reception
{
    public partial class hotel : Form
    {
        public hotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, combo1, combo2;
            int harga, ppn, total, lama;

            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            combo1 = comboBox1.Text;
            combo2 = comboBox2.Text;
            lama = Convert.ToInt16(combo2);

            if (combo1.Equals("VIP"))
            {
                textBox4.Text = "Kamar Mewah, Dengan TV 32 Inc dan Wifi";
                harga = 700000;
                ppn = 20000;
                total = (harga * lama) + ppn;
                label11.Text = a;
                label12.Text = b;
                label13.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
            else if (combo1.Equals("STANDART"))
            {
                textBox4.Text = "Kamar Mewah Dan TV 15 Inc";
                harga = 500000;
                ppn = 20000;
                total = (harga * lama) + ppn;
                label11.Text = a;
                label12.Text = b;
                label13.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
            else if (combo1.Equals("HEMAT"))
            {
                textBox4.Text = "Kamar Mewah";
                harga = 300000;
                ppn = 20000;
                total = (harga * lama) + ppn;
                label11.Text = a;
                label12.Text = b;
                label13.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Close();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help tolong = new Help();
            tolong.Show();
        }
    }
}
