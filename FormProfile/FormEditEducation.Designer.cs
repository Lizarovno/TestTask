namespace FormProfile
{
    partial class FormEditEducation
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
            this.btnEditSelectedEducation = new System.Windows.Forms.Button();
            this.btnAddSelectedEducationToTitle = new System.Windows.Forms.Button();
            this.btnDelSelectedEducation = new System.Windows.Forms.Button();
            this.rtbEducationInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddEducation = new System.Windows.Forms.Button();
            this.lblInstitution = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblCreateEduc = new System.Windows.Forms.Label();
            this.tbSpecialty = new System.Windows.Forms.TextBox();
            this.tbInstitution = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lboxEducation = new System.Windows.Forms.ListBox();
            this.lblPrefferedEduc = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditSelectedEducation
            // 
            this.btnEditSelectedEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSelectedEducation.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditSelectedEducation.Location = new System.Drawing.Point(198, 18);
            this.btnEditSelectedEducation.Name = "btnEditSelectedEducation";
            this.btnEditSelectedEducation.Size = new System.Drawing.Size(24, 24);
            this.btnEditSelectedEducation.TabIndex = 50;
            this.btnEditSelectedEducation.Text = "E";
            this.btnEditSelectedEducation.UseVisualStyleBackColor = true;
            this.btnEditSelectedEducation.Click += new System.EventHandler(this.btnEditSelectedEducation_Click);
            // 
            // btnAddSelectedEducationToTitle
            // 
            this.btnAddSelectedEducationToTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSelectedEducationToTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddSelectedEducationToTitle.Location = new System.Drawing.Point(168, 18);
            this.btnAddSelectedEducationToTitle.Name = "btnAddSelectedEducationToTitle";
            this.btnAddSelectedEducationToTitle.Size = new System.Drawing.Size(24, 24);
            this.btnAddSelectedEducationToTitle.TabIndex = 49;
            this.btnAddSelectedEducationToTitle.Text = "T";
            this.btnAddSelectedEducationToTitle.UseVisualStyleBackColor = true;
            this.btnAddSelectedEducationToTitle.Click += new System.EventHandler(this.btnAddSelectedEducationToTitle_Click);
            // 
            // btnDelSelectedEducation
            // 
            this.btnDelSelectedEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelSelectedEducation.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelSelectedEducation.Location = new System.Drawing.Point(228, 18);
            this.btnDelSelectedEducation.Name = "btnDelSelectedEducation";
            this.btnDelSelectedEducation.Size = new System.Drawing.Size(24, 24);
            this.btnDelSelectedEducation.TabIndex = 48;
            this.btnDelSelectedEducation.Text = "X";
            this.btnDelSelectedEducation.UseVisualStyleBackColor = true;
            this.btnDelSelectedEducation.Click += new System.EventHandler(this.btnDelSelectedEducation_Click);
            // 
            // rtbEducationInfo
            // 
            this.rtbEducationInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEducationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEducationInfo.Location = new System.Drawing.Point(278, 82);
            this.rtbEducationInfo.Name = "rtbEducationInfo";
            this.rtbEducationInfo.ReadOnly = true;
            this.rtbEducationInfo.Size = new System.Drawing.Size(334, 100);
            this.rtbEducationInfo.TabIndex = 47;
            this.rtbEducationInfo.Text = "rtbEducationInfo (Hidden)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Education";
            // 
            // btnAddEducation
            // 
            this.btnAddEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEducation.ForeColor = System.Drawing.Color.Blue;
            this.btnAddEducation.Location = new System.Drawing.Point(475, 288);
            this.btnAddEducation.Name = "btnAddEducation";
            this.btnAddEducation.Size = new System.Drawing.Size(137, 23);
            this.btnAddEducation.TabIndex = 44;
            this.btnAddEducation.Text = "Add Education";
            this.btnAddEducation.UseVisualStyleBackColor = true;
            this.btnAddEducation.Click += new System.EventHandler(this.btnAddEducation_Click);
            // 
            // lblInstitution
            // 
            this.lblInstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInstitution.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInstitution.Location = new System.Drawing.Point(22, 228);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(74, 20);
            this.lblInstitution.TabIndex = 80;
            this.lblInstitution.Text = "Institution";
            this.lblInstitution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateFrom.Location = new System.Drawing.Point(345, 228);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(49, 20);
            this.lblDateFrom.TabIndex = 81;
            this.lblDateFrom.Text = "From";
            this.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateTo.Location = new System.Drawing.Point(348, 254);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 20);
            this.lblDateTo.TabIndex = 82;
            this.lblDateTo.Text = "To";
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpecialty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSpecialty.Location = new System.Drawing.Point(22, 253);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(74, 20);
            this.lblSpecialty.TabIndex = 83;
            this.lblSpecialty.Text = "Specialty";
            this.lblSpecialty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateEduc
            // 
            this.lblCreateEduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateEduc.Location = new System.Drawing.Point(21, 199);
            this.lblCreateEduc.Name = "lblCreateEduc";
            this.lblCreateEduc.Size = new System.Drawing.Size(591, 24);
            this.lblCreateEduc.TabIndex = 84;
            this.lblCreateEduc.Text = "Create new education place";
            this.lblCreateEduc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Location = new System.Drawing.Point(102, 254);
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Size = new System.Drawing.Size(212, 20);
            this.tbSpecialty.TabIndex = 98;
            this.tbSpecialty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSpecialty_KeyDown);
            // 
            // tbInstitution
            // 
            this.tbInstitution.Location = new System.Drawing.Point(102, 228);
            this.tbInstitution.Name = "tbInstitution";
            this.tbInstitution.Size = new System.Drawing.Size(212, 20);
            this.tbInstitution.TabIndex = 95;
            this.tbInstitution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInstitution_KeyDown);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(400, 226);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(212, 20);
            this.dtpFrom.TabIndex = 99;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(400, 252);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(212, 20);
            this.dtpTo.TabIndex = 100;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lboxEducation
            // 
            this.lboxEducation.FormattingEnabled = true;
            this.lboxEducation.Location = new System.Drawing.Point(25, 48);
            this.lboxEducation.Name = "lboxEducation";
            this.lboxEducation.Size = new System.Drawing.Size(227, 134);
            this.lboxEducation.TabIndex = 105;
            this.lboxEducation.SelectedIndexChanged += new System.EventHandler(this.lboxEducation_SelectedIndexChanged);
            // 
            // lblPrefferedEduc
            // 
            this.lblPrefferedEduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrefferedEduc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrefferedEduc.Location = new System.Drawing.Point(274, 48);
            this.lblPrefferedEduc.Name = "lblPrefferedEduc";
            this.lblPrefferedEduc.Size = new System.Drawing.Size(338, 24);
            this.lblPrefferedEduc.TabIndex = 106;
            this.lblPrefferedEduc.Text = "lblPrefferedEduc (Hidden)";
            this.lblPrefferedEduc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(394, 288);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 107;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FormEditEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 329);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblPrefferedEduc);
            this.Controls.Add(this.lboxEducation);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tbSpecialty);
            this.Controls.Add(this.tbInstitution);
            this.Controls.Add(this.lblCreateEduc);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblInstitution);
            this.Controls.Add(this.btnEditSelectedEducation);
            this.Controls.Add(this.btnAddSelectedEducationToTitle);
            this.Controls.Add(this.btnDelSelectedEducation);
            this.Controls.Add(this.rtbEducationInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddEducation);
            this.Name = "FormEditEducation";
            this.Text = "FormEditEducation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditSelectedEducation;
        private System.Windows.Forms.Button btnAddSelectedEducationToTitle;
        private System.Windows.Forms.Button btnDelSelectedEducation;
        private System.Windows.Forms.RichTextBox rtbEducationInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddEducation;
        private System.Windows.Forms.Label lblInstitution;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblCreateEduc;
        private System.Windows.Forms.TextBox tbSpecialty;
        private System.Windows.Forms.TextBox tbInstitution;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox lboxEducation;
        private System.Windows.Forms.Label lblPrefferedEduc;
        private System.Windows.Forms.Button btnClean;
    }
}