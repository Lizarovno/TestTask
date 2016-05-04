namespace FormProfile
{
    partial class FormEditeSkills
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
            this.butSendSkill = new System.Windows.Forms.Button();
            this.lboxSkills = new System.Windows.Forms.ListBox();
            this.tbSkill = new System.Windows.Forms.TextBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.btnEditSelectedSkill = new System.Windows.Forms.Button();
            this.btnDelSelectedSkill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSendSkill
            // 
            this.butSendSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSendSkill.ForeColor = System.Drawing.Color.Blue;
            this.butSendSkill.Location = new System.Drawing.Point(208, 158);
            this.butSendSkill.Name = "butSendSkill";
            this.butSendSkill.Size = new System.Drawing.Size(85, 23);
            this.butSendSkill.TabIndex = 93;
            this.butSendSkill.Text = "Add Skill";
            this.butSendSkill.UseVisualStyleBackColor = true;
            this.butSendSkill.Click += new System.EventHandler(this.butSendSkill_Click);
            // 
            // lboxSkills
            // 
            this.lboxSkills.FormattingEnabled = true;
            this.lboxSkills.Location = new System.Drawing.Point(21, 21);
            this.lboxSkills.Name = "lboxSkills";
            this.lboxSkills.Size = new System.Drawing.Size(272, 95);
            this.lboxSkills.TabIndex = 94;
            // 
            // tbSkill
            // 
            this.tbSkill.Location = new System.Drawing.Point(101, 132);
            this.tbSkill.Name = "tbSkill";
            this.tbSkill.Size = new System.Drawing.Size(192, 20);
            this.tbSkill.TabIndex = 97;
            this.tbSkill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSkill_KeyDown);
            // 
            // lblSkill
            // 
            this.lblSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSkill.Location = new System.Drawing.Point(21, 132);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(74, 20);
            this.lblSkill.TabIndex = 96;
            this.lblSkill.Text = "Add Skill";
            this.lblSkill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditSelectedSkill
            // 
            this.btnEditSelectedSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSelectedSkill.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditSelectedSkill.Location = new System.Drawing.Point(178, 158);
            this.btnEditSelectedSkill.Name = "btnEditSelectedSkill";
            this.btnEditSelectedSkill.Size = new System.Drawing.Size(24, 24);
            this.btnEditSelectedSkill.TabIndex = 98;
            this.btnEditSelectedSkill.Text = "E";
            this.btnEditSelectedSkill.UseVisualStyleBackColor = true;
            this.btnEditSelectedSkill.Click += new System.EventHandler(this.btnEditSelectedSkill_Click);
            // 
            // btnDelSelectedSkill
            // 
            this.btnDelSelectedSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelSelectedSkill.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelSelectedSkill.Location = new System.Drawing.Point(148, 158);
            this.btnDelSelectedSkill.Name = "btnDelSelectedSkill";
            this.btnDelSelectedSkill.Size = new System.Drawing.Size(24, 24);
            this.btnDelSelectedSkill.TabIndex = 99;
            this.btnDelSelectedSkill.Text = "X";
            this.btnDelSelectedSkill.UseVisualStyleBackColor = true;
            this.btnDelSelectedSkill.Click += new System.EventHandler(this.btnDelSelectedSkill_Click);
            // 
            // FormEditeSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 196);
            this.Controls.Add(this.btnDelSelectedSkill);
            this.Controls.Add(this.btnEditSelectedSkill);
            this.Controls.Add(this.tbSkill);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.lboxSkills);
            this.Controls.Add(this.butSendSkill);
            this.Name = "FormEditeSkills";
            this.Text = "FormEditeSkills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSendSkill;
        private System.Windows.Forms.ListBox lboxSkills;
        private System.Windows.Forms.TextBox tbSkill;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Button btnEditSelectedSkill;
        private System.Windows.Forms.Button btnDelSelectedSkill;
    }
}