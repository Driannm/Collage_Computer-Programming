using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Delete_Database
{
    public partial class Form1 : Form
    {
        string database = "server = localhost; database=sekolah; uid=root; pwd=''";
        public MySqlConnection connect;
        public MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        public void Query()
        {
            try
            {
                connect = new MySqlConnection(database);
                connect.Open();
                string del = "delete from siswa WHERE NO_Induk='" +textBox1.Text+"'";
                cmd = new MySqlCommand(del, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Delete Berhasil!", "informasi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Query();
        }
    }
}
