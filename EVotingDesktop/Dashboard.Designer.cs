namespace EVotingDesktop
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Offices = new System.Windows.Forms.Button();
            this.Years = new System.Windows.Forms.Button();
            this.Parties = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Contestants = new System.Windows.Forms.Button();
            this.CertifiedParties = new System.Windows.Forms.Button();
            this.VoteSummary = new System.Windows.Forms.Button();
            this.dashboardGroupBox = new System.Windows.Forms.GroupBox();
            this.menu = new EVotingDesktop.Menu();
            this.dashboardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Offices
            // 
            this.Offices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Offices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Offices.FlatAppearance.BorderSize = 3;
            this.Offices.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Offices.Location = new System.Drawing.Point(392, 28);
            this.Offices.Name = "Offices";
            this.Offices.Size = new System.Drawing.Size(200, 60);
            this.Offices.TabIndex = 2;
            this.Offices.Text = "Offices";
            this.Offices.UseVisualStyleBackColor = true;
            this.Offices.Click += new System.EventHandler(this.Offices_Click);
            // 
            // Years
            // 
            this.Years.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Years.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Years.FlatAppearance.BorderSize = 3;
            this.Years.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Years.Location = new System.Drawing.Point(62, 28);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(200, 60);
            this.Years.TabIndex = 0;
            this.Years.Text = "Years";
            this.Years.UseVisualStyleBackColor = true;
            this.Years.Click += new System.EventHandler(this.Years_Click);
            // 
            // Parties
            // 
            this.Parties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Parties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Parties.FlatAppearance.BorderSize = 3;
            this.Parties.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parties.Location = new System.Drawing.Point(62, 149);
            this.Parties.Name = "Parties";
            this.Parties.Size = new System.Drawing.Size(200, 60);
            this.Parties.TabIndex = 3;
            this.Parties.Text = "Parties";
            this.Parties.UseVisualStyleBackColor = true;
            this.Parties.Click += new System.EventHandler(this.Parties_Click);
            // 
            // Users
            // 
            this.Users.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Users.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Users.FlatAppearance.BorderSize = 3;
            this.Users.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(392, 149);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(200, 60);
            this.Users.TabIndex = 4;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Contestants
            // 
            this.Contestants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Contestants.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Contestants.FlatAppearance.BorderSize = 3;
            this.Contestants.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contestants.Location = new System.Drawing.Point(716, 28);
            this.Contestants.Name = "Contestants";
            this.Contestants.Size = new System.Drawing.Size(200, 60);
            this.Contestants.TabIndex = 5;
            this.Contestants.Text = "Contestants";
            this.Contestants.UseVisualStyleBackColor = true;
            this.Contestants.Click += new System.EventHandler(this.Contestants_Click);
            // 
            // CertifiedParties
            // 
            this.CertifiedParties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CertifiedParties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CertifiedParties.FlatAppearance.BorderSize = 3;
            this.CertifiedParties.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertifiedParties.Location = new System.Drawing.Point(716, 149);
            this.CertifiedParties.Name = "CertifiedParties";
            this.CertifiedParties.Size = new System.Drawing.Size(200, 60);
            this.CertifiedParties.TabIndex = 6;
            this.CertifiedParties.Text = "Certified Parties";
            this.CertifiedParties.UseVisualStyleBackColor = true;
            this.CertifiedParties.Click += new System.EventHandler(this.CertifiedParties_Click);
            // 
            // VoteSummary
            // 
            this.VoteSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VoteSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.VoteSummary.FlatAppearance.BorderSize = 3;
            this.VoteSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoteSummary.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoteSummary.ForeColor = System.Drawing.Color.PaleGreen;
            this.VoteSummary.Location = new System.Drawing.Point(247, 297);
            this.VoteSummary.Name = "VoteSummary";
            this.VoteSummary.Size = new System.Drawing.Size(484, 60);
            this.VoteSummary.TabIndex = 7;
            this.VoteSummary.Text = "Vote Summary";
            this.VoteSummary.UseVisualStyleBackColor = true;
            // 
            // dashboardGroupBox
            // 
            this.dashboardGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.dashboardGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardGroupBox.Controls.Add(this.VoteSummary);
            this.dashboardGroupBox.Controls.Add(this.CertifiedParties);
            this.dashboardGroupBox.Controls.Add(this.Contestants);
            this.dashboardGroupBox.Controls.Add(this.Users);
            this.dashboardGroupBox.Controls.Add(this.Parties);
            this.dashboardGroupBox.Controls.Add(this.Offices);
            this.dashboardGroupBox.Controls.Add(this.Years);
            this.dashboardGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardGroupBox.ForeColor = System.Drawing.Color.Green;
            this.dashboardGroupBox.Location = new System.Drawing.Point(184, 159);
            this.dashboardGroupBox.Name = "dashboardGroupBox";
            this.dashboardGroupBox.Size = new System.Drawing.Size(988, 379);
            this.dashboardGroupBox.TabIndex = 9;
            this.dashboardGroupBox.TabStop = false;
            this.dashboardGroupBox.Text = "Setup";
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(83, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1136, 41);
            this.menu.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 501);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dashboardGroupBox);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dashboardGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Offices;
        private System.Windows.Forms.Button Years;
        private System.Windows.Forms.Button Parties;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Contestants;
        private System.Windows.Forms.Button CertifiedParties;
        private System.Windows.Forms.Button VoteSummary;
        private System.Windows.Forms.GroupBox dashboardGroupBox;
        private Menu menu;
    }
}