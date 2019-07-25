using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVotingDesktop
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Years_Click(object sender, EventArgs e)
        {
            //Load this view
            Year Year = new Year();
            this.Hide();
            Year.ShowDialog();
            this.Close();
        }

        private void Offices_Click(object sender, EventArgs e)
        {
            //Load this view
            Office Office = new Office();
            this.Hide();
            Office.ShowDialog();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load this view
            User User = new User();
            this.Hide();
            User.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load this view
            Dashboard Dashboard = new Dashboard();
            this.Hide();
            Dashboard.ShowDialog();
            this.Close();
        }

        private void Parties_Click(object sender, EventArgs e)
        {
            //Load this view
            Party Party = new Party();
            this.Hide();
            Party.ShowDialog();
            this.Close();
        }

        private void Contestants_Click(object sender, EventArgs e)
        {
            //Load this view
            Contestant Contestant = new Contestant();
            this.Hide();
            Contestant.ShowDialog();
            this.Close();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            //Load this view
            User User = new User();
            this.Hide();
            User.ShowDialog();
            this.Close();
        }

        private void CertifiedParties_Click(object sender, EventArgs e)
        {
            //Load this view
            CertifiedParty CertifiedParty = new CertifiedParty();
            this.Hide();
            CertifiedParty.ShowDialog();
            this.Close();
        }
    }
}
