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
    public partial class View_Passenger : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=SHAMS\MSSQLSERVER01;Initial Catalog=""USE Airline_DB"";Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
        private void Populate()
        {
            Con.Open();
            string query = "select * from PassengerTb1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PassDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        public View_Passenger()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Passenger_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flight_Passenger flight_Passenger = new Flight_Passenger();
            flight_Passenger.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (passId.Text == "")
            {
                MessageBox.Show("Enter The Passenger_ID To Delate");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM PassengerTb1 WHERE passId = @passId;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@passId", passId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void PassDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PassDGV.Rows[e.RowIndex];
                passId.Text = row.Cells[0].Value.ToString();
                passPhone.Text = row.Cells[1].Value.ToString();
                passNat.Text = row.Cells[2].Value.ToString();
                passGend.Text = row.Cells[3].Value.ToString();
                passName.Text = row.Cells[4].Value.ToString();
                passAd.Text = row.Cells[5].Value.ToString();
                passPort.Text = row.Cells[6].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
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
            if(passId.Text==""||passName.Text==""||passPort.Text==""||passAd.Text=="")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTb1 set passName = @passName, passPort = @passPort, passAd = @passAd, passNat = @passNat, passGend = @passGend, passPhone = @passPhone where passId = @passId;";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@passId", passId.Text);
                    cmd.Parameters.AddWithValue("@passName", passName.Text);
                    cmd.Parameters.AddWithValue("@passPort", passPort.Text);
                    cmd.Parameters.AddWithValue("@passAd", passAd.Text);
                    cmd.Parameters.AddWithValue("@passNat", passNat.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@passGend", passGend.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@passPhone", passPhone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                    Populate();
                }

            }
        }
    }
}
