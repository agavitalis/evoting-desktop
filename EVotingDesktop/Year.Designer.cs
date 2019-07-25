namespace EVotingDesktop
{
    partial class Year
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Year));
            this.registerYear = new System.Windows.Forms.Button();
            this.election_year = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateYear = new System.Windows.Forms.Button();
            this.election_year_label = new System.Windows.Forms.Label();
            this.deleteYear = new System.Windows.Forms.Button();
            this.register_year_heading = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.yearDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evotingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evotingDataSet = new EVotingDesktop.evotingDataSet();
            this.yearsTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.yearsTableAdapter();
            this.menu = new EVotingDesktop.Menu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // registerYear
            // 
            this.registerYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registerYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerYear.BackColor = System.Drawing.Color.Lime;
            this.registerYear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.registerYear.FlatAppearance.BorderSize = 2;
            this.registerYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerYear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerYear.Location = new System.Drawing.Point(17, 180);
            this.registerYear.Name = "registerYear";
            this.registerYear.Size = new System.Drawing.Size(301, 39);
            this.registerYear.TabIndex = 0;
            this.registerYear.Text = "Register Year";
            this.registerYear.UseVisualStyleBackColor = false;
            this.registerYear.Click += new System.EventHandler(this.registerYear_Click);
            // 
            // election_year
            // 
            this.election_year.AllowDrop = true;
            this.election_year.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_year.Location = new System.Drawing.Point(17, 116);
            this.election_year.Multiline = true;
            this.election_year.Name = "election_year";
            this.election_year.Size = new System.Drawing.Size(301, 39);
            this.election_year.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.updateYear);
            this.panel1.Controls.Add(this.election_year_label);
            this.panel1.Controls.Add(this.deleteYear);
            this.panel1.Controls.Add(this.register_year_heading);
            this.panel1.Controls.Add(this.election_year);
            this.panel1.Controls.Add(this.registerYear);
            this.panel1.Location = new System.Drawing.Point(155, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 300);
            this.panel1.TabIndex = 2;
            // 
            // updateYear
            // 
            this.updateYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.updateYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateYear.BackColor = System.Drawing.Color.DodgerBlue;
            this.updateYear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.updateYear.FlatAppearance.BorderSize = 2;
            this.updateYear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateYear.Location = new System.Drawing.Point(152, 237);
            this.updateYear.Name = "updateYear";
            this.updateYear.Size = new System.Drawing.Size(166, 39);
            this.updateYear.TabIndex = 12;
            this.updateYear.Text = "Update Year";
            this.updateYear.UseVisualStyleBackColor = false;
            this.updateYear.Click += new System.EventHandler(this.updateYear_Click);
            // 
            // election_year_label
            // 
            this.election_year_label.AutoSize = true;
            this.election_year_label.Location = new System.Drawing.Point(17, 95);
            this.election_year_label.Name = "election_year_label";
            this.election_year_label.Size = new System.Drawing.Size(76, 13);
            this.election_year_label.TabIndex = 7;
            this.election_year_label.Text = "Election Year :";
            // 
            // deleteYear
            // 
            this.deleteYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteYear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.deleteYear.FlatAppearance.BorderSize = 2;
            this.deleteYear.Location = new System.Drawing.Point(17, 237);
            this.deleteYear.Name = "deleteYear";
            this.deleteYear.Size = new System.Drawing.Size(119, 39);
            this.deleteYear.TabIndex = 11;
            this.deleteYear.Text = "Delete Year";
            this.deleteYear.UseVisualStyleBackColor = false;
            this.deleteYear.Click += new System.EventHandler(this.deleteYear_Click);
            // 
            // register_year_heading
            // 
            this.register_year_heading.BackColor = System.Drawing.Color.Green;
            this.register_year_heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.register_year_heading.Cursor = System.Windows.Forms.Cursors.Default;
            this.register_year_heading.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_year_heading.Location = new System.Drawing.Point(-2, 16);
            this.register_year_heading.Multiline = true;
            this.register_year_heading.Name = "register_year_heading";
            this.register_year_heading.ReadOnly = true;
            this.register_year_heading.Size = new System.Drawing.Size(336, 36);
            this.register_year_heading.TabIndex = 2;
            this.register_year_heading.Text = "Register Election Year";
            this.register_year_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(606, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(559, 300);
            this.dataGridView2.TabIndex = 1;
            // 
            // yearDataGridView
            // 
            this.yearDataGridView.AllowUserToAddRows = false;
            this.yearDataGridView.AllowUserToDeleteRows = false;
            this.yearDataGridView.AllowUserToOrderColumns = true;
            this.yearDataGridView.AutoGenerateColumns = false;
            this.yearDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.yearDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.yearDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.yearnameDataGridViewTextBoxColumn,
            this.iscurrentDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.yearDataGridView.DataSource = this.yearsBindingSource;
            this.yearDataGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.yearDataGridView.Location = new System.Drawing.Point(597, 186);
            this.yearDataGridView.Name = "yearDataGridView";
            this.yearDataGridView.ReadOnly = true;
            this.yearDataGridView.Size = new System.Drawing.Size(636, 300);
            this.yearDataGridView.TabIndex = 10;
            this.yearDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.yearDataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Year ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearnameDataGridViewTextBoxColumn
            // 
            this.yearnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearnameDataGridViewTextBoxColumn.DataPropertyName = "year_name";
            this.yearnameDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearnameDataGridViewTextBoxColumn.Name = "yearnameDataGridViewTextBoxColumn";
            this.yearnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iscurrentDataGridViewTextBoxColumn
            // 
            this.iscurrentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iscurrentDataGridViewTextBoxColumn.DataPropertyName = "is_current";
            this.iscurrentDataGridViewTextBoxColumn.HeaderText = "Current Year";
            this.iscurrentDataGridViewTextBoxColumn.Name = "iscurrentDataGridViewTextBoxColumn";
            this.iscurrentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
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
            // evotingDataSet
            // 
            this.evotingDataSet.DataSetName = "evotingDataSet";
            this.evotingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yearsTableAdapter
            // 
            this.yearsTableAdapter.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(97, -1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1136, 41);
            this.menu.TabIndex = 13;
            // 
            // Year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 501);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.yearDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Year";
            this.Text = "Year";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Year_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerYear;
        private System.Windows.Forms.TextBox election_year;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox register_year_heading;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label election_year_label;
        private System.Windows.Forms.DataGridView yearDataGridView;
        private System.Windows.Forms.BindingSource evotingDataSetBindingSource;
        private evotingDataSet evotingDataSet;
        private System.Windows.Forms.BindingSource yearsBindingSource;
        private evotingDataSetTableAdapters.yearsTableAdapter yearsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteYear;
        private System.Windows.Forms.Button updateYear;
        private Menu menu;
    }
}