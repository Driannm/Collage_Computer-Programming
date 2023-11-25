using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Dan_RadioButton_Di_Csharp
{
    public partial class Form1 : Form
    {
        string musik, film;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                musik = "Jazz";
            }
            else if(checkBox2.Checked)
            {
                musik = "Lo-Fi";
            }
            else
            {
                musik = "Jazz, Lo-Fi";
            }

            if(radioButton1.Checked)
            {
                film = "Action";
            }
            else
            {
                film = "Comdey";
            }
            MessageBox.Show("Anda menyukai musik jenis "+ musik+" dan film bergenre "+film+"");
        }
    }
}
