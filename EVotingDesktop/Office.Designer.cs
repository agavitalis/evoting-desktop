namespace EVotingDesktop
{
    partial class Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Office));
            this.partyPanel = new System.Windows.Forms.Panel();
            this.updateOffice = new System.Windows.Forms.Button();
            this.deleteOffice = new System.Windows.Forms.Button();
            this.party_vision_label = new System.Windows.Forms.Label();
            this.party_name_label = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.register_year_heading = new System.Windows.Forms.TextBox();
            this.office_name = new System.Windows.Forms.TextBox();
            this.registerOffice = new System.Windows.Forms.Button();
            this.officeGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evotingDataSet = new EVotingDesktop.evotingDataSet();
            this.officesTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.officesTableAdapter();
            this.menu = new EVotingDesktop.Menu();
            this.partyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // partyPanel
            // 
            this.partyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partyPanel.BackColor = System.Drawing.Color.Transparent;
            this.partyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partyPanel.Controls.Add(this.updateOffice);
            this.partyPanel.Controls.Add(this.deleteOffice);
            this.partyPanel.Controls.Add(this.party_vision_label);
            this.partyPanel.Controls.Add(this.party_name_label);
            this.partyPanel.Controls.Add(this.description);
            this.partyPanel.Controls.Add(this.register_year_heading);
            this.partyPanel.Controls.Add(this.office_name);
            this.partyPanel.Controls.Add(this.registerOffice);
            this.partyPanel.Location = new System.Drawing.Point(146, 105);
            this.partyPanel.Name = "partyPanel";
            this.partyPanel.Size = new System.Drawing.Size(380, 394);
            this.partyPanel.TabIndex = 4;
            // 
            // updateOffice
            // 
            this.updateOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.updateOffice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateOffice.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateOffice.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.updateOffice.FlatAppearance.BorderSize = 2;
            this.updateOffice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateOffice.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOffice.Location = new System.Drawing.Point(150, 322);
            this.updateOffice.Name = "updateOffice";
            this.updateOffice.Size = new System.Drawing.Size(190, 39);
            this.updateOffice.TabIndex = 13;
            this.updateOffice.Text = "Update Office";
            this.updateOffice.UseVisualStyleBackColor = false;
            this.updateOffice.Click += new System.EventHandler(this.updateOffice_Click);
            // 
            // deleteOffice
            // 
            this.deleteOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteOffice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteOffice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteOffice.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.deleteOffice.FlatAppearance.BorderSize = 2;
            this.deleteOffice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOffice.Location = new System.Drawing.Point(25, 322);
            this.deleteOffice.Name = "deleteOffice";
            this.deleteOffice.Size = new System.Drawing.Size(95, 39);
            this.deleteOffice.TabIndex = 12;
            this.deleteOffice.Text = "Delete Office";
            this.deleteOffice.UseVisualStyleBackColor = false;
            this.deleteOffice.Click += new System.EventHandler(this.deleteOffice_Click);
            // 
            // party_vision_label
            // 
            this.party_vision_label.AutoSize = true;
            this.party_vision_label.Location = new System.Drawing.Point(22, 137);
            this.party_vision_label.Name = "party_vision_label";
            this.party_vision_label.Size = new System.Drawing.Size(66, 13);
            this.party_vision_label.TabIndex = 8;
            this.party_vision_label.Text = "Description :";
            // 
            // party_name_label
            // 
            this.party_name_label.AutoSize = true;
            this.party_name_label.Location = new System.Drawing.Point(21, 64);
            this.party_name_label.Name = "party_name_label";
            this.party_name_label.Size = new System.Drawing.Size(72, 13);
            this.party_name_label.TabIndex = 6;
            this.party_name_label.Text = "Office Name :";
            // 
            // description
            // 
            this.description.AllowDrop = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(24, 155);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(316, 65);
            this.description.TabIndex = 4;
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
            this.register_year_heading.Size = new System.Drawing.Size(380, 36);
            this.register_year_heading.TabIndex = 2;
            this.register_year_heading.Text = "Register a new Office";
            this.register_year_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // office_name
            // 
            this.office_name.AllowDrop = true;
            this.office_name.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office_name.Location = new System.Drawing.Point(24, 83);
            this.office_name.Multiline = true;
            this.office_name.Name = "office_name";
            this.office_name.Size = new System.Drawing.Size(316, 35);
            this.office_name.TabIndex = 1;
            // 
            // registerOffice
            // 
            this.registerOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registerOffice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerOffice.BackColor = System.Drawing.Color.LimeGreen;
            this.registerOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerOffice.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.registerOffice.FlatAppearance.BorderSize = 2;
            this.registerOffice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerOffice.Location = new System.Drawing.Point(24, 262);
            this.registerOffice.Name = "registerOffice";
            this.registerOffice.Size = new System.Drawing.Size(316, 38);
            this.registerOffice.TabIndex = 0;
            this.registerOffice.Text = "Create Office";
            this.registerOffice.UseVisualStyleBackColor = false;
            this.registerOffice.Click += new System.EventHandler(this.registerOffice_Click);
            // 
            // officeGridView
            // 
            this.officeGridView.AllowUserToAddRows = false;
            this.officeGridView.AllowUserToDeleteRows = false;
            this.officeGridView.AutoGenerateColumns = false;
            this.officeGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.officeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.officenameDataGridViewTextBoxColumn,
            this.officedescriptionDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.officeGridView.DataSource = this.officesBindingSource;
            this.officeGridView.Location = new System.Drawing.Point(617, 105);
            this.officeGridView.Name = "officeGridView";
            this.officeGridView.ReadOnly = true;
            this.officeGridView.Size = new System.Drawing.Size(575, 394);
            this.officeGridView.TabIndex = 10;
            this.officeGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.officeGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officenameDataGridViewTextBoxColumn
            // 
            this.officenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officenameDataGridViewTextBoxColumn.DataPropertyName = "office_name";
            this.officenameDataGridViewTextBoxColumn.HeaderText = "Office Name";
            this.officenameDataGridViewTextBoxColumn.Name = "officenameDataGridViewTextBoxColumn";
            this.officenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officedescriptionDataGridViewTextBoxColumn
            // 
            this.officedescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officedescriptionDataGridViewTextBoxColumn.DataPropertyName = "office_description";
            this.officedescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.officedescriptionDataGridViewTextBoxColumn.Name = "officedescriptionDataGridViewTextBoxColumn";
            this.officedescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Date of Creation";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "offices";
            this.officesBindingSource.DataSource = this.evotingDataSet;
            // 
            // evotingDataSet
            // 
            this.evotingDataSet.DataSetName = "evotingDataSet";
            this.evotingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(73, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1136, 41);
            this.menu.TabIndex = 14;
            // 
            // Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 501);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.officeGridView);
            this.Controls.Add(this.partyPanel);
            this.Name = "Office";
            this.Text = "Office";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Office_Load);
            this.partyPanel.ResumeLayout(false);
            this.partyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel partyPanel;
        private System.Windows.Forms.Label party_vision_label;
        private System.Windows.Forms.Label party_name_label;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox register_year_heading;
        private System.Windows.Forms.TextBox office_name;
        private System.Windows.Forms.Button registerOffice;
        private System.Windows.Forms.Button deleteOffice;
        private System.Windows.Forms.Button updateOffice;
        private System.Windows.Forms.DataGridView officeGridView;
        private evotingDataSet evotingDataSet;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private evotingDataSetTableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private Menu menu;
    }
}