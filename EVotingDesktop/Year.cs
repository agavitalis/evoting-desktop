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

namespace EVotingDesktop
{
    public partial class Year : Form
    {
        SqlConnection db_connection { get; set; }
        SqlCommand sql_command { get; set; }
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public Year()
        {
            InitializeComponent();
                        
        }

        private void Year_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evotingDataSet.years' table. You can move, or remove it, as needed.
            this.yearsTableAdapter.Fill(this.evotingDataSet.years);
            //Connect to database
            db_connection = new SqlConnection("Data Source=DESKTOP-554GDT7;Initial Catalog = evoting; Integrated Security = True");
            sql_command = new SqlCommand();
            sql_command.Connection = db_connection;

        }

        private void registerYear_Click(object sender, EventArgs e)
        {
            String ElectionYear = election_year.Text;
            
            if (ElectionYear == "")
            {
                MessageBox.Show("Election Year Cannot be Empty");
            }
            else
            {
                db_connection.Open();
                DateTime Today = DateTime.Today;
                sql_command.CommandText = " INSERT INTO years(year_name,is_current,created_at) values ('"+ElectionYear+"','0','" +Today+"')";

                sql_command.ExecuteNonQuery();
                db_connection.Close();

                //label_weather.Text = "The weather is bright, you can schedule flights! Enjoy.";
                MessageBox.Show("Year created successfully");
                DisplayData();
                ClearData();

            }
            
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            db_connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from years", db_connection);
            adapt.Fill(dt);
            yearDataGridView.DataSource = dt;
            db_connection.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            election_year.Text = "";
            ID = 0;
        }

        private void deleteYear_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                db_connection.Open();
                sql_command.CommandText = "Delete from years where id= '" + ID + "'";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Year Deleted Successfully!");
                DisplayData();

            }
            else
            {
                MessageBox.Show("Please Select Contest to Delete");
            }
        }

        private void updateYear_Click(object sender, EventArgs e)
        {
            if (election_year.Text != ""){

                //I am using another method to access the db
                SqlCommand cmd = new SqlCommand(" Update years set year_name = @ElectionYear where id = @ID", db_connection);
                db_connection.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@ElectionYear", election_year.Text);
                cmd.ExecuteNonQuery();

                db_connection.Close();

                MessageBox.Show("Record Updated Successfully");
               
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //yearDataGridView RowHeaderMouseClick Event  
        private void yearDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(yearDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            election_year.Text = yearDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

       
    }
}
