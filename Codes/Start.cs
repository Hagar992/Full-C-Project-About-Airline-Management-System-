namespace Project_Airline_Management_System
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            progressBar1.Value = time;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                login login = new login();  
                login.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
