using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EVotingDesktop
{
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
            System.Windows.Controls.Button btn = new System.Windows.Controls.Button();
            btn.Content = "Dynamic Button";
        }

        private void CreateDynamicWrapPanel()
        {
            // Create a WrapPanel and set its properties      
            WrapPanel dynamicWrapPanel = new WrapPanel();
            dynamicWrapPanel.Background = new SolidColorBrush(Colors.LightBlue);
            dynamicWrapPanel.Orientation = System.Windows.Controls.Orientation.Horizontal;

            // Create Ellipses and add to StackPanel      
            Ellipse redCircle = new Ellipse();
            redCircle.Width = 100;
            redCircle.Height = 100;
            redCircle.Fill = new SolidColorBrush(Colors.Red);
            dynamicWrapPanel.Children.Add(redCircle);

            Ellipse orangeCircle = new Ellipse();
            orangeCircle.Width = 80;
            orangeCircle.Height = 80;
            orangeCircle.Fill = new SolidColorBrush(Colors.Orange);
            dynamicWrapPanel.Children.Add(orangeCircle);

            Ellipse yellowCircle = new Ellipse();
            yellowCircle.Width = 60;
            yellowCircle.Height = 60;
            yellowCircle.Fill = new SolidColorBrush(Colors.Yellow);
            dynamicWrapPanel.Children.Add(yellowCircle);

            Ellipse greenCircle = new Ellipse();
            greenCircle.Width = 40;
            greenCircle.Height = 40;
            greenCircle.Fill = new SolidColorBrush(Colors.Green);
            dynamicWrapPanel.Children.Add(greenCircle);

            Ellipse blueCircle = new Ellipse();
            blueCircle.Width = 20;
            blueCircle.Height = 20;
            blueCircle.Fill = new SolidColorBrush(Colors.Blue);
            dynamicWrapPanel.Children.Add(blueCircle);

            // Display Panel into a Window      
           // Vote.Content = dynamicWrapPanel;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

   
}
