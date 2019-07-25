namespace EVotingDesktop
{
    partial class CertifiedParty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertifiedParty));
            this.certified_parties = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partysloganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyvisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partymissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evotingDataSet = new EVotingDesktop.evotingDataSet();
            this.partyTableAdapter = new EVotingDesktop.evotingDataSetTableAdapters.partyTableAdapter();
            this.menu = new EVotingDesktop.Menu();
            ((System.ComponentModel.ISupportInitialize)(this.certified_parties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // certified_parties
            // 
            this.certified_parties.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.certified_parties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.certified_parties.AutoGenerateColumns = false;
            this.certified_parties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.certified_parties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certified_parties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.partynameDataGridViewTextBoxColumn,
            this.partysloganDataGridViewTextBoxColumn,
            this.partyvisionDataGridViewTextBoxColumn,
            this.partymissionDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.certified_parties.DataSource = this.partyBindingSource;
            this.certified_parties.Location = new System.Drawing.Point(179, 118);
            this.certified_parties.Name = "certified_parties";
            this.certified_parties.Size = new System.Drawing.Size(912, 277);
            this.certified_parties.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Party Number";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partynameDataGridViewTextBoxColumn
            // 
            this.partynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partynameDataGridViewTextBoxColumn.DataPropertyName = "party_name";
            this.partynameDataGridViewTextBoxColumn.HeaderText = "Party Name";
            this.partynameDataGridViewTextBoxColumn.Name = "partynameDataGridViewTextBoxColumn";
            // 
            // partysloganDataGridViewTextBoxColumn
            // 
            this.partysloganDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partysloganDataGridViewTextBoxColumn.DataPropertyName = "party_slogan";
            this.partysloganDataGridViewTextBoxColumn.HeaderText = "Party Slogan";
            this.partysloganDataGridViewTextBoxColumn.Name = "partysloganDataGridViewTextBoxColumn";
            // 
            // partyvisionDataGridViewTextBoxColumn
            // 
            this.partyvisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partyvisionDataGridViewTextBoxColumn.DataPropertyName = "party_vision";
            this.partyvisionDataGridViewTextBoxColumn.HeaderText = "Party Vision";
            this.partyvisionDataGridViewTextBoxColumn.Name = "partyvisionDataGridViewTextBoxColumn";
            // 
            // partymissionDataGridViewTextBoxColumn
            // 
            this.partymissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partymissionDataGridViewTextBoxColumn.DataPropertyName = "party_mission";
            this.partymissionDataGridViewTextBoxColumn.HeaderText = "Party Mission";
            this.partymissionDataGridViewTextBoxColumn.Name = "partymissionDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Registration Date";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "party";
            this.partyBindingSource.DataSource = this.evotingDataSet;
            // 
            // evotingDataSet
            // 
            this.evotingDataSet.DataSetName = "evotingDataSet";
            this.evotingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(64, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1136, 41);
            this.menu.TabIndex = 13;
            // 
            // CertifiedParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 501);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.certified_parties);
            this.Name = "CertifiedParty";
            this.Text = "CertifiedParty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CertifiedParty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certified_parties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evotingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView certified_parties;
        private evotingDataSet evotingDataSet;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private evotingDataSetTableAdapters.partyTableAdapter partyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partysloganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyvisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partymissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private Menu menu;
    }
}