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

namespace Aplikasi_Update_Database
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
                string update = "UPDATE siswa SET Nama='" + textBox2.Text + "'," +
                    "Jenis_Kelamin ='" + textBox3.Text + "'," +
                    "Alamat='" + textBox4.Text + "'," +
                    "Kelas='" + textBox5.Text + "'" +
                    "WHERE NO_Induk='" + textBox1.Text + "'";

                cmd = new MySqlCommand(update, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Update Berhasil!", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query();
        }
    }
}
