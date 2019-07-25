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
    public partial class Office : Form
    {
        SqlConnection db_connection { get; set; }
        SqlCommand sql_command { get; set; }
        SqlDataAdapter adapt;
        int ID = 0;

        public Office()
        {
            InitializeComponent();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evotingDataSet.offices' table. You can move, or remove it, as needed.
            this.officesTableAdapter.Fill(this.evotingDataSet.offices);
            //Connect to database
            db_connection = new SqlConnection("Data Source=DESKTOP-554GDT7;Initial Catalog = evoting; Integrated Security = True");
            sql_command = new SqlCommand();
            sql_command.Connection = db_connection;
        }

        private void registerOffice_Click(object sender, EventArgs e)
        {
            if (office_name.Text == "" || description.Text == "" )
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                db_connection.Open();
                DateTime Today = DateTime.Today;
                sql_command.CommandText = " INSERT INTO offices(office_name,office_description,office_image,created_at)" +
                    " values ('"+office_name.Text + "','" + description.Text + "','xxx','" + Today + "')";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Office created successfully");
                DisplayData();
                ClearData();

            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            db_connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from offices", db_connection);
            adapt.Fill(dt);
            officeGridView.DataSource = dt;
            db_connection.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            ID = 0;
            office_name.Text = "";
            description.Text = "";
        }

        //yearDataGridView RowHeaderMouseClick Event  
        private void officeGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(officeGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            office_name.Text = officeGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            description.Text = officeGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void updateOffice_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !(office_name.Text == "" || description.Text == ""))
            {
                db_connection.Open();
                sql_command.CommandText = "Update offices SET office_name='" + office_name.Text + "',office_description='" + description.Text + "' where id=" + ID + "";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Office successfully updated");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Office to Edit");
            }

        }

        private void deleteOffice_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                db_connection.Open();
                sql_command.CommandText = "Delete from offices where id= '" + ID + "'";
                sql_command.ExecuteNonQuery();
                db_connection.Close();

                MessageBox.Show("Office Deleted Successfully!");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Select Office to Delete");
            }
        }

        
    }
}
