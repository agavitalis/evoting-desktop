namespace EVotingDesktop
{
    partial class Contestant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contestant));
            this.partyPanel = new System.Windows.Forms.Panel();
            this.updateContestant = new System.Windows.Forms.Button();
            this.deleteContestant = new System.Windows.Forms.Button();
            this.office = new System.Windows.Forms.ListBox();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evotingDataSet = new EVotingDesktop.evotingDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.party = new System.Windows.Forms.ListBox();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.ListBox();
            this.yearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evotingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.party_vision_label = new System.Windows.Forms.Label();
            this.party_name_label = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.register_year_heading = new System.Windows.Forms.TextBox();
            this.registerContestant = new System.Windows.Forms.Button();
            this.contestantGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearsTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.yearsTableAdapter();
            this.officesTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.officesTableAdapter();
            this.partyTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.partyTableAdapter();
            this.contestantsTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.contestantsTableAdapter();
            this.menu = new EVotingDesktop.Menu();
            this.partyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partyPanel
            // 
            this.partyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partyPanel.BackColor = System.Drawing.Color.Transparent;
            this.partyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partyPanel.Controls.Add(this.updateContestant);
            this.partyPanel.Controls.Add(this.deleteContestant);
            this.partyPanel.Controls.Add(this.office);
            this.partyPanel.Controls.Add(this.label2);
            this.partyPanel.Controls.Add(this.party);
            this.partyPanel.Controls.Add(this.label1);
            this.partyPanel.Controls.Add(this.year);
            this.partyPanel.Controls.Add(this.party_vision_label);
            this.partyPanel.Controls.Add(this.party_name_label);
            this.partyPanel.Controls.Add(this.user);
            this.partyPanel.Controls.Add(this.register_year_heading);
            this.partyPanel.Controls.Add(this.registerContestant);
            this.partyPanel.Location = new System.Drawing.Point(116, 133);
            this.partyPanel.Name = "partyPanel";
            this.partyPanel.Size = new System.Drawing.Size(380, 402);
            this.partyPanel.TabIndex = 5;
            // 
            // updateContestant
            // 
            this.updateContestant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.updateContestant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateContestant.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateContestant.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.updateContestant.FlatAppearance.BorderSize = 2;
            this.updateContestant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateContestant.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateContestant.Location = new System.Drawing.Point(126, 361);
            this.updateContestant.Name = "updateContestant";
            this.updateContestant.Size = new System.Drawing.Size(214, 39);
            this.updateContestant.TabIndex = 14;
            this.updateContestant.Text = "Update Contestant";
            this.updateContestant.UseVisualStyleBackColor = false;
            this.updateContestant.Click += new System.EventHandler(this.updateContestant_Click);
            // 
            // deleteContestant
            // 
            this.deleteContestant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteContestant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteContestant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteContestant.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.deleteContestant.FlatAppearance.BorderSize = 2;
            this.deleteContestant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteContestant.Location = new System.Drawing.Point(25, 360);
            this.deleteContestant.Name = "deleteContestant";
            this.deleteContestant.Size = new System.Drawing.Size(95, 39);
            this.deleteContestant.TabIndex = 12;
            this.deleteContestant.Text = "Delete Contestant";
            this.deleteContestant.UseVisualStyleBackColor = false;
            this.deleteContestant.Click += new System.EventHandler(this.deleteContestant_Click);
            // 
            // office
            // 
            this.office.DataSource = this.officesBindingSource;
            this.office.DisplayMember = "office_name";
            this.office.FormattingEnabled = true;
            this.office.Location = new System.Drawing.Point(24, 76);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(316, 30);
            this.office.TabIndex = 13;
            this.office.ValueMember = "id";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Party";
            // 
            // party
            // 
            this.party.DataSource = this.partyBindingSource;
            this.party.DisplayMember = "party_name";
            this.party.FormattingEnabled = true;
            this.party.Location = new System.Drawing.Point(24, 254);
            this.party.Name = "party";
            this.party.Size = new System.Drawing.Size(316, 30);
            this.party.TabIndex = 11;
            this.party.ValueMember = "id";
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "party";
            this.partyBindingSource.DataSource = this.evotingDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Year:";
            // 
            // year
            // 
            this.year.DataSource = this.yearsBindingSource;
            this.year.DisplayMember = "year_name";
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(24, 194);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(316, 30);
            this.year.TabIndex = 9;
            this.year.ValueMember = "id";
            // 
            // yearsBindingSource
            // 
            this.yearsBindingSource.DataMember = "years";
            this.yearsBindingSource.DataSource = this.evotingDataSetBindingSource;
            // 
            // evotingDataSetBindingSource
            // 
            this.evotingDataSetBindingSource.DataSource = this.evotingDataSet;
            this.evotingDataSetBindingSource.Position = 0;
            // 
            // party_vision_label
            // 
            this.party_vision_label.AutoSize = true;
            this.party_vision_label.Location = new System.Drawing.Point(22, 118);
            this.party_vision_label.Name = "party_vision_label";
            this.party_vision_label.Size = new System.Drawing.Size(71, 13);
            this.party_vision_label.TabIndex = 8;
            this.party_vision_label.Text = "Enter User ID";
            // 
            // party_name_label
            // 
            this.party_name_label.AutoSize = true;
            this.party_name_label.Location = new System.Drawing.Point(21, 59);
            this.party_name_label.Name = "party_name_label";
            this.party_name_label.Size = new System.Drawing.Size(71, 13);
            this.party_name_label.TabIndex = 6;
            this.party_name_label.Text = "Select Office:";
            // 
            // user
            // 
            this.user.AllowDrop = true;
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(24, 134);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(316, 31);
            this.user.TabIndex = 4;
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
            this.register_year_heading.Size = new System.Drawing.Size(380, 37);
            this.register_year_heading.TabIndex = 2;
            this.register_year_heading.Text = "Register a Contestant";
            this.register_year_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerContestant
            // 
            this.registerContestant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registerContestant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerContestant.BackColor = System.Drawing.Color.LimeGreen;
            this.registerContestant.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.registerContestant.FlatAppearance.BorderSize = 2;
            this.registerContestant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerContestant.Location = new System.Drawing.Point(24, 305);
            this.registerContestant.Name = "registerContestant";
            this.registerContestant.Size = new System.Drawing.Size(316, 46);
            this.registerContestant.TabIndex = 0;
            this.registerContestant.Text = "Register Contestant";
            this.registerContestant.UseVisualStyleBackColor = false;
            this.registerContestant.Click += new System.EventHandler(this.registerContestant_Click);
            // 
            // contestantGridView
            // 
            this.contestantGridView.AllowUserToAddRows = false;
            this.contestantGridView.AllowUserToDeleteRows = false;
            this.contestantGridView.AllowUserToOrderColumns = true;
            this.contestantGridView.AutoGenerateColumns = false;
            this.contestantGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.contestantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contestantGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.partyDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.contestantGridView.DataSource = this.contestantsBindingSource;
            this.contestantGridView.Location = new System.Drawing.Point(574, 133);
            this.contestantGridView.Name = "contestantGridView";
            this.contestantGridView.ReadOnly = true;
            this.contestantGridView.Size = new System.Drawing.Size(678, 401);
            this.contestantGridView.TabIndex = 10;
            this.contestantGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.contestantGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyDataGridViewTextBoxColumn
            // 
            this.partyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partyDataGridViewTextBoxColumn.DataPropertyName = "party";
            this.partyDataGridViewTextBoxColumn.HeaderText = "Party";
            this.partyDataGridViewTextBoxColumn.Name = "partyDataGridViewTextBoxColumn";
            this.partyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Date Registered";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contestantsBindingSource
            // 
            this.contestantsBindingSource.DataMember = "contestants";
            this.contestantsBindingSource.DataSource = this.evotingDataSet;
            // 
            // yearsTableAdapter
            // 
            this.yearsTableAdapter.ClearBeforeFill = true;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // contestantsTableAdapter
            // 
            this.contestantsTableAdapter.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(116, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1136, 41);
            this.menu.TabIndex = 12;
            // 
            // Contestant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 501);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.contestantGridView);
            this.Controls.Add(this.partyPanel);
            this.Name = "Contestant";
            this.Text = "Contestant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Contestant_Load);
            this.partyPanel.ResumeLayout(false);
            this.partyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel partyPanel;
        private System.Windows.Forms.ListBox year;
        private System.Windows.Forms.BindingSource evotingDataSetBindingSource;
        private evotingDataSet evotingDataSet;
        private System.Windows.Forms.Label party_vision_label;
        private System.Windows.Forms.Label party_name_label;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox register_year_heading;
        private System.Windows.Forms.Button registerContestant;
        private System.Windows.Forms.BindingSource yearsBindingSource;
        private evotingDataSetTableAdapters.yearsTableAdapter yearsTableAdapter;
        private System.Windows.Forms.ListBox office;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox party;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private evotingDataSetTableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private evotingDataSetTableAdapters.partyTableAdapter partyTableAdapter;
        private System.Windows.Forms.Button deleteContestant;
        private System.Windows.Forms.Button updateContestant;
        private System.Windows.Forms.DataGridView contestantGridView;
        private System.Windows.Forms.BindingSource contestantsBindingSource;
        private evotingDataSetTableAdapters.contestantsTableAdapter contestantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private Menu menu;
    }
}