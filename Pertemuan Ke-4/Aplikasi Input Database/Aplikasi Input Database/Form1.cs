using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Aplikasi_Input_Database
{
    public partial class Form1 : Form
    {
        string database = ("server = localhost; uid = root; database = sekolah; pwd = '';");
        public MySqlConnection connect;
        public MySqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }
        public void Query(string query)
        {
            connect = new MySqlConnection(database);
            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Query("insert into siswa values('" +
                this.textBox1.Text + "','" +
                this.textBox2.Text + "','" +
                this.textBox3.Text + "','" +
                this.textBox4.Text + "','" +
                this.textBox5.Text + "')");
            MessageBox.Show("Inser data siswa berhasil");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
