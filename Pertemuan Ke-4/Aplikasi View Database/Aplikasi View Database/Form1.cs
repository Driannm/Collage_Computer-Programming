using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_View_Database
{
    public partial class Form1 : Form
    {
        string database = ("server = localhost; uid = root; database = sekolah; pwd = '';");
        public MySqlConnection connect;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public Form1()
        {
            InitializeComponent();
        }

        public void Connect()
        {
            connect = new MySqlConnection(database);
            connect.Open();
        }

        public void Disconnect()
        {
            connect = new MySqlConnection(database);
            connect.Close(); 
        }

        public DataTable View()
        {
            string sql = "select * from siswa";
            DataTable dt = new DataTable();
            try
            {
                Connect();
                cmd = new MySqlCommand(sql, connect);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            Disconnect();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View();
        }
    }
}
