namespace acente_talep
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = sayac + 1;
            if (sayac == 3)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}