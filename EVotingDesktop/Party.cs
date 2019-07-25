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
    public partial class Party : Form
    {
        SqlConnection db_connection { get; set; }
        SqlCommand sql_command { get; set; }
        SqlDataAdapter adapt;
        int ID = 0;

        public Party()
        {
            InitializeComponent();
        }


        private void Party_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evotingDataSet.party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.evotingDataSet.party);
            //Connect to database
            db_connection = new SqlConnection("Data Source=DESKTOP-554GDT7;Initial Catalog = evoting; Integrated Security = True");
            sql_command = new SqlCommand();
            sql_command.Connection = db_connection;

        }

        private void registerParty_Click(object sender, EventArgs e)
        {
            

            if (party_name.Text == "" || party_slogan.Text == "" || party_vision.Text == "" || party_mission.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                db_connection.Open();
                DateTime Today = DateTime.Today;
                sql_command.CommandText = " INSERT INTO party(party_name,party_logo,party_slogan,party_vision,party_mission,created_at)" +
                    " values ('" + party_name.Text + "','xxx','" + party_slogan.Text + "','" + party_vision.Text + "','" + party_mission.Text + "','" + Today + "')";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                
                MessageBox.Show("Party created successfully");
                DisplayData();
                ClearData();

            }

        }

        //yearDataGridView RowHeaderMouseClick Event  
        private void partyGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(partyGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            party_name.Text = partyGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            party_slogan.Text = partyGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            party_vision.Text = partyGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            party_mission.Text = partyGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            db_connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from party", db_connection);
            adapt.Fill(dt);
            partyGridView.DataSource = dt;
            db_connection.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            ID = 0;
            party_name.Text = "";
            party_slogan.Text = "";
            party_vision.Text = "";
            party_mission.Text = "";
        }

        
        private void updateParty_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !(party_name.Text == "" || party_slogan.Text == "") && !(party_vision.Text == "" || party_mission.Text == ""))
            {
                db_connection.Open();
                sql_command.CommandText = "Update party SET party_name='" + party_name.Text + "',party_slogan='" + party_slogan.Text + "',party_vision='" + party_vision.Text + "',party_mission='" + party_mission.Text + "' where id=" + ID + "";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Party successfully updated");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Party to Edit");
            }

        }


        private void deleteParty_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                db_connection.Open();
                sql_command.CommandText = "Delete from party where id= '" + ID + "'";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Party Deleted Successfully!");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Select Party to Delete");
            }
        }
    }
}
