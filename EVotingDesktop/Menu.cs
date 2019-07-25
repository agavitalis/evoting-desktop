using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVotingDesktop
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void yearMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
           
           // Open a new one
            Year Year = new Year();
            Year.ShowDialog();

        }

        private void homeMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            //Open a new one
            Dashboard Dashboard = new Dashboard();
            Dashboard.ShowDialog();
        }

        private void contestantsMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            //Open a new one
            Contestant Contestant = new Contestant();
            Contestant.ShowDialog();
        }

        private void officesMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            //Open a new one
            Office Office = new Office();
            Office.ShowDialog();
        }

        private void usersMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            //Open a new one
            User User = new User();
            User.ShowDialog();
        }

        private void certifiedPartiesMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            //Open a new one
            CertifiedParty CertifiedParty = new CertifiedParty();
            CertifiedParty.ShowDialog();
        }

        private void partiesMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current view
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            //Open a new one
            Party Party = new Party();
            Party.ShowDialog();
        }
    }
}
