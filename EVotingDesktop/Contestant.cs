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
    public partial class Contestant : Form
    {
        SqlConnection db_connection { get; set; }
        SqlCommand sql_command { get; set; }
        SqlDataAdapter adapt;
        int ID = 0;

        public Contestant()
        {
            InitializeComponent();
        }

        private void Contestant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evotingDataSet.contestants' table. You can move, or remove it, as needed.
            this.contestantsTableAdapter.Fill(this.evotingDataSet.contestants);

            // TODO: This line of code loads data into the 'evotingDataSet.party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.evotingDataSet.party);
            // TODO: This line of code loads data into the 'evotingDataSet.offices' table. You can move, or remove it, as needed.
            this.officesTableAdapter.Fill(this.evotingDataSet.offices);
            // TODO: This line of code loads data into the 'evotingDataSet1.party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.evotingDataSet.party);
            // TODO: This line of code loads data into the 'evotingDataSet1.offices' table. You can move, or remove it, as needed.
            this.officesTableAdapter.Fill(this.evotingDataSet.offices);
            // TODO: This line of code loads data into the 'evotingDataSet.years' table. You can move, or remove it, as needed.
            this.yearsTableAdapter.Fill(this.evotingDataSet.years);

      

            //Connect to database
            db_connection = new SqlConnection("Data Source=DESKTOP-554GDT7;Initial Catalog = evoting; Integrated Security = True");
            sql_command = new SqlCommand();
            sql_command.Connection = db_connection;


        }

        private void registerContestant_Click(object sender, EventArgs e)
        {
            

            if ((user.Text == "" || party.Text =="") ||(office.Text == ""))
            {
                MessageBox.Show("All fiels must be filled");
            }
            else
            {

                db_connection.Open();
                DateTime Today = DateTime.Today;
                sql_command.CommandText = " INSERT INTO contestants([user],party,office,year,created_at) values ('" + user.Text + "','" + party.Text + "','" + office.Text + "','" + year.Text + "','" + Today + "')";

                sql_command.ExecuteNonQuery();
                db_connection.Close();
                        
                MessageBox.Show("Contestnt successfully registered");
                DisplayData();
                ClearData();

            }
        }


        //Display Data in DataGridView  
        private void DisplayData()
        {
            db_connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from contestants", db_connection);
            adapt.Fill(dt);
            contestantGridView.DataSource = dt;
            db_connection.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            ID = 0;
        }

        //yearDataGridView RowHeaderMouseClick Event  
        private void contestantGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(contestantGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            user.Text = contestantGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            party.Text = contestantGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            office.Text = contestantGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            year.Text = contestantGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void updateContestant_Click(object sender, EventArgs e)
        {
            db_connection.Open();
            sql_command.CommandText  =  "Update contestants SET [user]='" + user.Text + "',party='" + party.Text + "' ,office='" + office.Text + "' ,year='" + year.Text + "' where id=" + ID + "";
            sql_command.ExecuteNonQuery();
            db_connection.Close();

            MessageBox.Show("Contestant successfully updated");

            DisplayData();
            ClearData();

        }

        private void deleteContestant_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                db_connection.Open();
                sql_command.CommandText = "Delete from contestants where id= '" + ID + "'";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Contestant Deleted Successfully!");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Select Contestant to Delete");
            }
        }

        private void homeMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
