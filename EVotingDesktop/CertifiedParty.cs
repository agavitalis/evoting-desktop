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
    public partial class CertifiedParty : Form
    {
        SqlConnection db_connection { get; set; }
        SqlCommand sql_command { get; set; }

        public CertifiedParty()
        {
            InitializeComponent();
        }

        private void CertifiedParty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'evotingDataSet.party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.evotingDataSet.party);
            //Connect to database
            db_connection = new SqlConnection("Data Source=DESKTOP-554GDT7;Initial Catalog = evoting; Integrated Security = True");
            sql_command = new SqlCommand();
            sql_command.Connection = db_connection;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partyTableAdapter.FillBy(this.evotingDataSet.party);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
