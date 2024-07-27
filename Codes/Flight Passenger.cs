using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient; 


namespace Project_Airline_Management_System
{
    public partial class Flight_Passenger : Form
    {
        public Flight_Passenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SHAMS\MSSQLSERVER01;Initial Catalog=""USE Airline_DB"";Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passPhone.Text = " ";
            passPort.Text = " ";
            passAd.Text = " ";
            passId.Text = " ";
            passName.Text = " ";
            passNat.Text = " ";
            passGend.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (passPhone.Text == "" || passPort.Text == "" || passAd.Text == "" || passId.Text == "" || passName.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTb1 values(" + passId.Text + ",'" + passPhone.Text + "','" + passNat.SelectedItem.ToString() + "','" + passGend.SelectedItem.ToString() + "','" + passName.Text + "','" + passAd.Text + "','" + passPort.Text + ",')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Passenger view_Passenger = new View_Passenger();
            view_Passenger.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
