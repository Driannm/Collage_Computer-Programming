namespace Timer_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime jam = DateTime.Now;
            label5.Text = jam.Hour.ToString();
            label6.Text = jam.Minute.ToString();
            label7.Text = jam.Second.ToString();
        }
    }
}
