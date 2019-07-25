namespace EVotingDesktop
{
    partial class Menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contestantsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certifiedPartiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeVitalisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.yearMenuItem,
            this.officesMenuItem,
            this.contestantsMenuItem,
            this.partiesMenuItem,
            this.usersMenuItem,
            this.certifiedPartiesMenuItem,
            this.welcomeVitalisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 17);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(53, 20);
            this.homeMenuItem.Text = "Home";
            this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_Click);
            // 
            // yearMenuItem
            // 
            this.yearMenuItem.Name = "yearMenuItem";
            this.yearMenuItem.Size = new System.Drawing.Size(44, 20);
            this.yearMenuItem.Text = "Year";
            this.yearMenuItem.Click += new System.EventHandler(this.yearMenuItem_Click);
            // 
            // officesMenuItem
            // 
            this.officesMenuItem.Name = "officesMenuItem";
            this.officesMenuItem.Size = new System.Drawing.Size(57, 20);
            this.officesMenuItem.Text = "Offices";
            this.officesMenuItem.Click += new System.EventHandler(this.officesMenuItem_Click);
            // 
            // contestantsMenuItem
            // 
            this.contestantsMenuItem.Name = "contestantsMenuItem";
            this.contestantsMenuItem.Size = new System.Drawing.Size(85, 20);
            this.contestantsMenuItem.Text = "Contestants";
            this.contestantsMenuItem.Click += new System.EventHandler(this.contestantsMenuItem_Click);
            // 
            // partiesMenuItem
            // 
            this.partiesMenuItem.Name = "partiesMenuItem";
            this.partiesMenuItem.Size = new System.Drawing.Size(57, 20);
            this.partiesMenuItem.Text = "Parties";
            this.partiesMenuItem.Click += new System.EventHandler(this.partiesMenuItem_Click);
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.Name = "usersMenuItem";
            this.usersMenuItem.Size = new System.Drawing.Size(50, 20);
            this.usersMenuItem.Text = "Users";
            this.usersMenuItem.Click += new System.EventHandler(this.usersMenuItem_Click);
            // 
            // certifiedPartiesMenuItem
            // 
            this.certifiedPartiesMenuItem.Name = "certifiedPartiesMenuItem";
            this.certifiedPartiesMenuItem.Size = new System.Drawing.Size(109, 20);
            this.certifiedPartiesMenuItem.Text = "Certified Parties";
            this.certifiedPartiesMenuItem.Click += new System.EventHandler(this.certifiedPartiesMenuItem_Click);
            // 
            // welcomeVitalisToolStripMenuItem
            // 
            this.welcomeVitalisToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.welcomeVitalisToolStripMenuItem.Name = "welcomeVitalisToolStripMenuItem";
            this.welcomeVitalisToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.welcomeVitalisToolStripMenuItem.Text = "Welcome Vitalis!";
            this.welcomeVitalisToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1276, 41);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contestantsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certifiedPartiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeVitalisToolStripMenuItem;
    }
}
