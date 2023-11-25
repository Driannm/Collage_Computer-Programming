namespace Aplikasi_Hotel_Reception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = pss.Text;

            if (a.Equals("Hotel"))
            {
                MessageBox.Show("Selamat, Login Berhasil");
                hotel h = new hotel();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, Password salah!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            pss.Text = "";
        }
    }
}
