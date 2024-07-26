using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Airline_Management_System
{
    public partial class Flight_View : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=SHAMS\MSSQLSERVER01;Initial Catalog=""USE Airline_DB"";Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

        public Flight_View()
        {

            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Flight_TB";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                FlightDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FCode.Text = "";
            FSeals.Text = "";
            From.Text = "";
            To.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flight_table flight_Table = new flight_table();
            flight_Table.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FCode.Text == "")
            {
                MessageBox.Show("Enter The Flight_Code To Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM Flight_TB WHERE FCode = @FCode;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@FCode", FCode.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Information Deleted Successfully");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = FlightDGV.Rows[e.RowIndex];
            //    FCode.Text = row.Cells[0].Value.ToString();
            //    From.Text = row.Cells[1].Value.ToString();
            //    To.Text = row.Cells[2].Value.ToString();
            //    FDate.Text = row.Cells[3].Value.ToString();
            //    FSeals.Text = row.Cells[4].Value.ToString();
            //}
           
                if (e.RowIndex >= 0 && FlightDGV.Rows[e.RowIndex] != null)
                {
                    DataGridViewRow row = FlightDGV.Rows[e.RowIndex];
                    FCode.Text = row.Cells[0]?.Value?.ToString() ?? "";
                    From.Text = row.Cells[1]?.Value?.ToString() ?? "";
                    To.Text = row.Cells[2]?.Value?.ToString() ?? "";
                    FDate.Text = row.Cells[3]?.Value?.ToString() ?? "";
                    FSeals.Text = row.Cells[4]?.Value?.ToString() ?? "";
                }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FCode.Text == "" || FSeals.Text == "" || From.SelectedItem == null || To.SelectedItem == null)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                Con.Open();
                string query = "update Flight_TB set [From] = @From, [To] = @To, FDate = @FDate, FSeals = @FSeals where FCode = @FCode;";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@FCode", FCode.Text);
                cmd.Parameters.AddWithValue("@From", From.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@To", To.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@FDate", FDate.Value);
                cmd.Parameters.AddWithValue("@FSeals", int.Parse(FSeals.Text)); // assuming FSeals is a TextBox

                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight Information Has Been Successfully Updated");
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
