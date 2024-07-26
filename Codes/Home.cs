using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Airline_Management_System
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flight_table flight_Table = new flight_table();
            flight_Table.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flight_Passenger flight_Passenger = new Flight_Passenger();
            flight_Passenger.Show();
            this.Hide();
        }
    }
}
