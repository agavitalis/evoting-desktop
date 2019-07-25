namespace EVotingDesktop
{
    partial class Party
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Party));
            this.partyPanel = new System.Windows.Forms.Panel();
            this.party_mission_label = new System.Windows.Forms.Label();
            this.party_vision_label = new System.Windows.Forms.Label();
            this.party_slogan_label = new System.Windows.Forms.Label();
            this.party_name_label = new System.Windows.Forms.Label();
            this.party_mission = new System.Windows.Forms.TextBox();
            this.party_vision = new System.Windows.Forms.TextBox();
            this.party_slogan = new System.Windows.Forms.TextBox();
            this.register_year_heading = new System.Windows.Forms.TextBox();
            this.party_name = new System.Windows.Forms.TextBox();
            this.registerParty = new System.Windows.Forms.Button();
            this.partyGridView = new System.Windows.Forms.DataGridView();
            this.evotingDataSet = new EVotingDesktop.evotingDataSet();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.partyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partysloganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyvisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partymissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteParty = new System.Windows.Forms.Button();
            this.updateParty = new System.Windows.Forms.Button();
            this.menu = new EVotingDesktop.Menu();
            this.partyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partyPanel
            // 
            this.partyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partyPanel.BackColor = System.Drawing.Color.Transparent;
            this.partyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partyPanel.Controls.Add(this.updateParty);
            this.partyPanel.Controls.Add(this.deleteParty);
            this.partyPanel.Controls.Add(this.party_mission_label);
            this.partyPanel.Controls.Add(this.party_vision_label);
            this.partyPanel.Controls.Add(this.party_slogan_label);
            this.partyPanel.Controls.Add(this.party_name_label);
            this.partyPanel.Controls.Add(this.party_mission);
            this.partyPanel.Controls.Add(this.party_vision);
            this.partyPanel.Controls.Add(this.party_slogan);
            this.partyPanel.Controls.Add(this.register_year_heading);
            this.partyPanel.Controls.Add(this.party_name);
            this.partyPanel.Controls.Add(this.registerParty);
            this.partyPanel.Location = new System.Drawing.Point(140, 120);
            this.partyPanel.Name = "partyPanel";
            this.partyPanel.Size = new System.Drawing.Size(380, 423);
            this.partyPanel.TabIndex = 3;
            // 
            // party_mission_label
            // 
            this.party_mission_label.AutoSize = true;
            this.party_mission_label.Location = new System.Drawing.Point(24, 231);
            this.party_mission_label.Name = "party_mission_label";
            this.party_mission_label.Size = new System.Drawing.Size(75, 13);
            this.party_mission_label.TabIndex = 9;
            this.party_mission_label.Text = "Party Mission :";
            // 
            // party_vision_label
            // 
            this.party_vision_label.AutoSize = true;
            this.party_vision_label.Location = new System.Drawing.Point(24, 163);
            this.party_vision_label.Name = "party_vision_label";
            this.party_vision_label.Size = new System.Drawing.Size(68, 13);
            this.party_vision_label.TabIndex = 8;
            this.party_vision_label.Text = "Party Vision :";
            // 
            // party_slogan_label
            // 
            this.party_slogan_label.AutoSize = true;
            this.party_slogan_label.Location = new System.Drawing.Point(24, 102);
            this.party_slogan_label.Name = "party_slogan_label";
            this.party_slogan_label.Size = new System.Drawing.Size(73, 13);
            this.party_slogan_label.TabIndex = 7;
            this.party_slogan_label.Text = "Party Slogan :";
            // 
            // party_name_label
            // 
            this.party_name_label.AutoSize = true;
            this.party_name_label.Location = new System.Drawing.Point(21, 38);
            this.party_name_label.Name = "party_name_label";
            this.party_name_label.Size = new System.Drawing.Size(68, 13);
            this.party_name_label.TabIndex = 6;
            this.party_name_label.Text = "Party Name :";
            // 
            // party_mission
            // 
            this.party_mission.AllowDrop = true;
            this.party_mission.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_mission.Location = new System.Drawing.Point(24, 250);
            this.party_mission.Multiline = true;
            this.party_mission.Name = "party_mission";
            this.party_mission.Size = new System.Drawing.Size(316, 43);
            this.party_mission.TabIndex = 5;
            // 
            // party_vision
            // 
            this.party_vision.AllowDrop = true;
            this.party_vision.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_vision.Location = new System.Drawing.Point(24, 179);
            this.party_vision.Multiline = true;
            this.party_vision.Name = "party_vision";
            this.party_vision.Size = new System.Drawing.Size(316, 42);
            this.party_vision.TabIndex = 4;
            // 
            // party_slogan
            // 
            this.party_slogan.AllowDrop = true;
            this.party_slogan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_slogan.Location = new System.Drawing.Point(24, 119);
            this.party_slogan.Multiline = true;
            this.party_slogan.Name = "party_slogan";
            this.party_slogan.Size = new System.Drawing.Size(316, 35);
            this.party_slogan.TabIndex = 3;
            // 
            // register_year_heading
            // 
            this.register_year_heading.BackColor = System.Drawing.Color.Green;
            this.register_year_heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.register_year_heading.Cursor = System.Windows.Forms.Cursors.Default;
            this.register_year_heading.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_year_heading.Location = new System.Drawing.Point(-2, 3);
            this.register_year_heading.Multiline = true;
            this.register_year_heading.Name = "register_year_heading";
            this.register_year_heading.ReadOnly = true;
            this.register_year_heading.Size = new System.Drawing.Size(375, 32);
            this.register_year_heading.TabIndex = 2;
            this.register_year_heading.Text = "Register a new Party";
            this.register_year_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // party_name
            // 
            this.party_name.AllowDrop = true;
            this.party_name.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_name.Location = new System.Drawing.Point(24, 55);
            this.party_name.Multiline = true;
            this.party_name.Name = "party_name";
            this.party_name.Size = new System.Drawing.Size(316, 35);
            this.party_name.TabIndex = 1;
            // 
            // registerParty
            // 
            this.registerParty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registerParty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerParty.BackColor = System.Drawing.Color.LimeGreen;
            this.registerParty.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.registerParty.FlatAppearance.BorderSize = 2;
            this.registerParty.Location = new System.Drawing.Point(24, 306);
            this.registerParty.Name = "registerParty";
            this.registerParty.Size = new System.Drawing.Size(319, 40);
            this.registerParty.TabIndex = 0;
            this.registerParty.Text = "Register Party";
            this.registerParty.UseVisualStyleBackColor = false;
            this.registerParty.Click += new System.EventHandler(this.registerParty_Click);
            // 
            // partyGridView
            // 
            this.partyGridView.AllowUserToAddRows = false;
            this.partyGridView.AllowUserToDeleteRows = false;
            this.partyGridView.AllowUserToOrderColumns = true;
            this.partyGridView.AutoGenerateColumns = false;
            this.partyGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.partyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.partynameDataGridViewTextBoxColumn,
            this.partysloganDataGridViewTextBoxColumn,
            this.partyvisionDataGridViewTextBoxColumn,
            this.partymissionDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.partyGridView.DataSource = this.partyBindingSource;
            this.partyGridView.GridColor = System.Drawing.Color.Honeydew;
            this.partyGridView.Location = new System.Drawing.Point(575, 120);
            this.partyGridView.Name = "partyGridView";
            this.partyGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partyGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partyGridView.Size = new System.Drawing.Size(653, 380);
            this.partyGridView.TabIndex = 10;
            this.partyGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.partyGridView_RowHeaderMouseClick);
            // 
            // evotingDataSet
            // 
            this.evotingDataSet.DataSetName = "evotingDataSet";
            this.evotingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "party";
            this.partyBindingSource.DataSource = this.evotingDataSet;
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partynameDataGridViewTextBoxColumn
            // 
            this.partynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partynameDataGridViewTextBoxColumn.DataPropertyName = "party_name";
            this.partynameDataGridViewTextBoxColumn.HeaderText = "Party Name";
            this.partynameDataGridViewTextBoxColumn.Name = "partynameDataGridViewTextBoxColumn";
            this.partynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partysloganDataGridViewTextBoxColumn
            // 
            this.partysloganDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partysloganDataGridViewTextBoxColumn.DataPropertyName = "party_slogan";
            this.partysloganDataGridViewTextBoxColumn.HeaderText = "Slogan";
            this.partysloganDataGridViewTextBoxColumn.Name = "partysloganDataGridViewTextBoxColumn";
            this.partysloganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyvisionDataGridViewTextBoxColumn
            // 
            this.partyvisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partyvisionDataGridViewTextBoxColumn.DataPropertyName = "party_vision";
            this.partyvisionDataGridViewTextBoxColumn.HeaderText = "Vision";
            this.partyvisionDataGridViewTextBoxColumn.Name = "partyvisionDataGridViewTextBoxColumn";
            this.partyvisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partymissionDataGridViewTextBoxColumn
            // 
            this.partymissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partymissionDataGridViewTextBoxColumn.DataPropertyName = "party_mission";
            this.partymissionDataGridViewTextBoxColumn.HeaderText = "Mission";
            this.partymissionDataGridViewTextBoxColumn.Name = "partymissionDataGridViewTextBoxColumn";
            this.partymissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteParty
            // 
            this.deleteParty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteParty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteParty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteParty.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.deleteParty.FlatAppearance.BorderSize = 2;
            this.deleteParty.Location = new System.Drawing.Point(24, 363);
            this.deleteParty.Name = "deleteParty";
            this.deleteParty.Size = new System.Drawing.Size(95, 47);
            this.deleteParty.TabIndex = 13;
            this.deleteParty.Text = "Delete Party";
            this.deleteParty.UseVisualStyleBackColor = false;
            this.deleteParty.Click += new System.EventHandler(this.deleteParty_Click);
            // 
            // updateParty
            // 
            this.updateParty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.updateParty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateParty.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateParty.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.updateParty.FlatAppearance.BorderSize = 2;
            this.updateParty.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateParty.Location = new System.Drawing.Point(153, 362);
            this.updateParty.Name = "updateParty";
            this.updateParty.Size = new System.Drawing.Size(190, 48);
            this.updateParty.TabIndex = 14;
            this.updateParty.Text = "Update Party";
            this.updateParty.UseVisualStyleBackColor = false;
            this.updateParty.Click += new System.EventHandler(this.updateParty_Click);
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(92, -3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1136, 41);
            this.menu.TabIndex = 13;
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 501);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.partyGridView);
            this.Controls.Add(this.partyPanel);
            this.Name = "Party";
            this.Text = "Party";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Party_Load);
            this.partyPanel.ResumeLayout(false);
            this.partyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel partyPanel;
        private System.Windows.Forms.Label party_name_label;
        private System.Windows.Forms.TextBox party_mission;
        private System.Windows.Forms.TextBox party_vision;
        private System.Windows.Forms.TextBox party_slogan;
        private System.Windows.Forms.TextBox register_year_heading;
        private System.Windows.Forms.TextBox party_name;
        private System.Windows.Forms.Button registerParty;
        private System.Windows.Forms.Label party_slogan_label;
        private System.Windows.Forms.Label party_vision_label;
        private System.Windows.Forms.Label party_mission_label;
        private System.Windows.Forms.DataGridView partyGridView;
        private evotingDataSet evotingDataSet;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private evotingDataSetTableAdapters.partyTableAdapter partyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partysloganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyvisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partymissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteParty;
        private System.Windows.Forms.Button updateParty;
        private Menu menu;
    }
}