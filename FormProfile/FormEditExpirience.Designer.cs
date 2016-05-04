namespace FormProfile
{
    partial class FormEditExpirience
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
            this.btnEditSelectedExp = new System.Windows.Forms.Button();
            this.btnAddSelectedExpToTitle = new System.Windows.Forms.Button();
            this.btnDelSelectedExp = new System.Windows.Forms.Button();
            this.rtbExpirienceInfo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalEducationTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.lblCreateExp = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnAddExp = new System.Windows.Forms.Button();
            this.lboxExpirience = new System.Windows.Forms.ListBox();
            this.lblPrefferedExp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditSelectedExp
            // 
            this.btnEditSelectedExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSelectedExp.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditSelectedExp.Location = new System.Drawing.Point(212, 19);
            this.btnEditSelectedExp.Name = "btnEditSelectedExp";
            this.btnEditSelectedExp.Size = new System.Drawing.Size(24, 24);
            this.btnEditSelectedExp.TabIndex = 63;
            this.btnEditSelectedExp.Text = "E";
            this.btnEditSelectedExp.UseVisualStyleBackColor = true;
            this.btnEditSelectedExp.Click += new System.EventHandler(this.btnEditSelectedExp_Click);
            // 
            // btnAddSelectedExpToTitle
            // 
            this.btnAddSelectedExpToTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSelectedExpToTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddSelectedExpToTitle.Location = new System.Drawing.Point(182, 19);
            this.btnAddSelectedExpToTitle.Name = "btnAddSelectedExpToTitle";
            this.btnAddSelectedExpToTitle.Size = new System.Drawing.Size(24, 24);
            this.btnAddSelectedExpToTitle.TabIndex = 62;
            this.btnAddSelectedExpToTitle.Text = "T";
            this.btnAddSelectedExpToTitle.UseVisualStyleBackColor = true;
            this.btnAddSelectedExpToTitle.Click += new System.EventHandler(this.btnAddSelectedExpToTitle_Click);
            // 
            // btnDelSelectedExp
            // 
            this.btnDelSelectedExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelSelectedExp.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelSelectedExp.Location = new System.Drawing.Point(242, 19);
            this.btnDelSelectedExp.Name = "btnDelSelectedExp";
            this.btnDelSelectedExp.Size = new System.Drawing.Size(24, 24);
            this.btnDelSelectedExp.TabIndex = 61;
            this.btnDelSelectedExp.Text = "X";
            this.btnDelSelectedExp.UseVisualStyleBackColor = true;
            this.btnDelSelectedExp.Click += new System.EventHandler(this.btnDelSelectedExp_Click);
            // 
            // rtbExpirienceInfo
            // 
            this.rtbExpirienceInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbExpirienceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbExpirienceInfo.Location = new System.Drawing.Point(279, 77);
            this.rtbExpirienceInfo.Name = "rtbExpirienceInfo";
            this.rtbExpirienceInfo.ReadOnly = true;
            this.rtbExpirienceInfo.Size = new System.Drawing.Size(317, 106);
            this.rtbExpirienceInfo.TabIndex = 60;
            this.rtbExpirienceInfo.Text = "rtbExpirienceInfo (Hidden)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(21, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Expirience";
            // 
            // lblTotalEducationTime
            // 
            this.lblTotalEducationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalEducationTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalEducationTime.Location = new System.Drawing.Point(509, 285);
            this.lblTotalEducationTime.Name = "lblTotalEducationTime";
            this.lblTotalEducationTime.Size = new System.Drawing.Size(103, 23);
            this.lblTotalEducationTime.TabIndex = 114;
            this.lblTotalEducationTime.Text = "years (Hidden)";
            this.lblTotalEducationTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(361, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 23);
            this.label10.TabIndex = 113;
            this.label10.Text = "Total working time";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(400, 253);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(212, 20);
            this.dtpTo.TabIndex = 112;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(400, 227);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(212, 20);
            this.dtpFrom.TabIndex = 111;
            // 
            // tbPost
            // 
            this.tbPost.Location = new System.Drawing.Point(102, 255);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(212, 20);
            this.tbPost.TabIndex = 110;
            this.tbPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPost_KeyDown);
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(102, 229);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(212, 20);
            this.tbCompany.TabIndex = 109;
            this.tbCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCompany_KeyDown);
            // 
            // lblCreateExp
            // 
            this.lblCreateExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateExp.Location = new System.Drawing.Point(21, 200);
            this.lblCreateExp.Name = "lblCreateExp";
            this.lblCreateExp.Size = new System.Drawing.Size(591, 24);
            this.lblCreateExp.TabIndex = 108;
            this.lblCreateExp.Text = "Create new expirience";
            this.lblCreateExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPost
            // 
            this.lblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPost.Location = new System.Drawing.Point(22, 254);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(74, 20);
            this.lblPost.TabIndex = 107;
            this.lblPost.Text = "Post";
            this.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateTo.Location = new System.Drawing.Point(348, 255);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 20);
            this.lblDateTo.TabIndex = 106;
            this.lblDateTo.Text = "To";
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateFrom.Location = new System.Drawing.Point(345, 229);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(49, 20);
            this.lblDateFrom.TabIndex = 105;
            this.lblDateFrom.Text = "From";
            this.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCompany.Location = new System.Drawing.Point(22, 229);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(74, 20);
            this.lblCompany.TabIndex = 104;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddExp
            // 
            this.btnAddExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddExp.Location = new System.Drawing.Point(475, 320);
            this.btnAddExp.Name = "btnAddExp";
            this.btnAddExp.Size = new System.Drawing.Size(137, 23);
            this.btnAddExp.TabIndex = 103;
            this.btnAddExp.Text = "Add Expirience";
            this.btnAddExp.UseVisualStyleBackColor = true;
            this.btnAddExp.Click += new System.EventHandler(this.btnAddExp_Click);
            // 
            // lboxExpirience
            // 
            this.lboxExpirience.FormattingEnabled = true;
            this.lboxExpirience.Location = new System.Drawing.Point(25, 49);
            this.lboxExpirience.Name = "lboxExpirience";
            this.lboxExpirience.Size = new System.Drawing.Size(227, 134);
            this.lboxExpirience.TabIndex = 115;
            this.lboxExpirience.SelectedIndexChanged += new System.EventHandler(this.lboxExpirience_SelectedIndexChanged);
            // 
            // lblPrefferedExp
            // 
            this.lblPrefferedExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrefferedExp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrefferedExp.Location = new System.Drawing.Point(274, 49);
            this.lblPrefferedExp.Name = "lblPrefferedExp";
            this.lblPrefferedExp.Size = new System.Drawing.Size(338, 24);
            this.lblPrefferedExp.TabIndex = 116;
            this.lblPrefferedExp.Text = "lblPrefferedExp (Hidden)";
            this.lblPrefferedExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEditExpirience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.lblPrefferedExp);
            this.Controls.Add(this.lboxExpirience);
            this.Controls.Add(this.lblTotalEducationTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.lblCreateExp);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnAddExp);
            this.Controls.Add(this.btnEditSelectedExp);
            this.Controls.Add(this.btnAddSelectedExpToTitle);
            this.Controls.Add(this.btnDelSelectedExp);
            this.Controls.Add(this.rtbExpirienceInfo);
            this.Controls.Add(this.label7);
            this.Name = "FormEditExpirience";
            this.Text = "FormEditExpirience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditSelectedExp;
        private System.Windows.Forms.Button btnAddSelectedExpToTitle;
        private System.Windows.Forms.Button btnDelSelectedExp;
        private System.Windows.Forms.RichTextBox rtbExpirienceInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalEducationTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label lblCreateExp;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnAddExp;
        private System.Windows.Forms.ListBox lboxExpirience;
        private System.Windows.Forms.Label lblPrefferedExp;
    }
}