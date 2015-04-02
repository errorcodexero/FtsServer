namespace FirstTeamScouter_Server
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridMatchList = new System.Windows.Forms.DataGridView();
            this.lblMatchList = new System.Windows.Forms.Label();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.lblCompetitionName = new System.Windows.Forms.Label();
            this.cmbCompetitionName = new System.Windows.Forms.ComboBox();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.lblTestMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMatchList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMatchList
            // 
            this.gridMatchList.AllowUserToAddRows = false;
            this.gridMatchList.AllowUserToDeleteRows = false;
            this.gridMatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMatchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridMatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMatchList.Location = new System.Drawing.Point(16, 185);
            this.gridMatchList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridMatchList.Name = "gridMatchList";
            this.gridMatchList.Size = new System.Drawing.Size(1019, 342);
            this.gridMatchList.TabIndex = 10;
            // 
            // lblMatchList
            // 
            this.lblMatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatchList.AutoSize = true;
            this.lblMatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchList.Location = new System.Drawing.Point(432, 145);
            this.lblMatchList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatchList.Name = "lblMatchList";
            this.lblMatchList.Size = new System.Drawing.Size(151, 36);
            this.lblMatchList.TabIndex = 11;
            this.lblMatchList.Text = "Match List";
            this.lblMatchList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(51, 562);
            this.btnAddMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(139, 46);
            this.btnAddMatch.TabIndex = 12;
            this.btnAddMatch.Text = "Add Match";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(883, 562);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(139, 46);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(212, 562);
            this.btnRefreshData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(139, 46);
            this.btnRefreshData.TabIndex = 12;
            this.btnRefreshData.Text = "Refresh Data";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Enabled = false;
            this.lblStatus.Location = new System.Drawing.Point(16, 651);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompetition
            // 
            this.lblCompetition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetition.Location = new System.Drawing.Point(432, 11);
            this.lblCompetition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(173, 36);
            this.lblCompetition.TabIndex = 14;
            this.lblCompetition.Text = "Competition";
            this.lblCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.AutoSize = true;
            this.lblCompetitionName.Location = new System.Drawing.Point(16, 70);
            this.lblCompetitionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(123, 17);
            this.lblCompetitionName.TabIndex = 15;
            this.lblCompetitionName.Text = "Competition Name";
            // 
            // cmbCompetitionName
            // 
            this.cmbCompetitionName.FormattingEnabled = true;
            this.cmbCompetitionName.Location = new System.Drawing.Point(148, 66);
            this.cmbCompetitionName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCompetitionName.Name = "cmbCompetitionName";
            this.cmbCompetitionName.Size = new System.Drawing.Size(160, 24);
            this.cmbCompetitionName.TabIndex = 16;
            this.cmbCompetitionName.SelectedValueChanged += new System.EventHandler(this.cmbCompetitionName_SelectedValueChanged);
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(613, 562);
            this.btnExportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(139, 46);
            this.btnExportData.TabIndex = 12;
            this.btnExportData.Text = "Export Data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(453, 562);
            this.btnImportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(139, 46);
            this.btnImportData.TabIndex = 12;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // lblTestMode
            // 
            this.lblTestMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestMode.AutoSize = true;
            this.lblTestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestMode.Location = new System.Drawing.Point(351, 53);
            this.lblTestMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestMode.Name = "lblTestMode";
            this.lblTestMode.Size = new System.Drawing.Size(0, 36);
            this.lblTestMode.TabIndex = 17;
            this.lblTestMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 672);
            this.Controls.Add(this.lblTestMode);
            this.Controls.Add(this.cmbCompetitionName);
            this.Controls.Add(this.lblCompetitionName);
            this.Controls.Add(this.lblCompetition);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.lblMatchList);
            this.Controls.Add(this.gridMatchList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMatchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMatchList;
        private System.Windows.Forms.Label lblMatchList;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCompetition;
        private System.Windows.Forms.Label lblCompetitionName;
        private System.Windows.Forms.ComboBox cmbCompetitionName;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label lblTestMode;
    }
}

