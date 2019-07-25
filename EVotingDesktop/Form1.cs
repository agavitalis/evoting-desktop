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
    public partial class Evoting : Form
    {
        public Evoting()
        {
            InitializeComponent(); 
            
        }

        private void Evoting_Load(object sender, EventArgs e)
        {
            //Action to happen on page load
            String connectionString = "Data Source=DESKTOP-554GDT7;Initial Catalog = evoting; Integrated Security = True";
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

        }

      

        private void login_Click(object sender, EventArgs e)
        {
            
            String User = username.Text;
            String Pass = password.Text;

            if(User == "" || Pass == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                // MessageBox.Show(User);
                Dashboard Dashboard = new Dashboard();
                this.Hide();
                Dashboard.ShowDialog();
                this.Close();
            }
          
            //connection.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

      

       

        
    }
}
