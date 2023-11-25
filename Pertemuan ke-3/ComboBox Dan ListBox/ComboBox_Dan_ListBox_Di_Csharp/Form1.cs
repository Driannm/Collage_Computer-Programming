using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Dan_ListBox_Di_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void isikombo()
        {
            comboBox1.Items.Add("TEBAL");
            comboBox1.Items.Add("MIRING");
        }
        public void koreksi_huruf()
        {
            if (comboBox1.Text == "TEBAL")
            {
                listBox1.Font = new Font(listBox1.Font, FontStyle.Bold);
            }
            else
            {
                listBox1.Font = new Font(listBox1.Font, FontStyle.Italic);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isikombo();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            koreksi_huruf();
        }
    }
}
