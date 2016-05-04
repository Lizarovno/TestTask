namespace FormProfile
{
    partial class FormEditName
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
            this.btnEditName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFamilyName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditName
            // 
            this.btnEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditName.Location = new System.Drawing.Point(175, 106);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(95, 23);
            this.btnEditName.TabIndex = 4;
            this.btnEditName.Text = "Edit Name";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFamilyName
            // 
            this.tbFamilyName.Location = new System.Drawing.Point(120, 45);
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.Size = new System.Drawing.Size(150, 20);
            this.tbFamilyName.TabIndex = 2;
            this.tbFamilyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFamilyName_KeyDown);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(120, 19);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFirstName_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Family Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Patronymic:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(120, 71);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(150, 20);
            this.tbPatronymic.TabIndex = 3;
            this.tbPatronymic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPatronymic_KeyDown);
            // 
            // FormEditName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFamilyName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPatronymic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditName";
            this.Text = "Enter all fills (only letters)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFamilyName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPatronymic;

    }
}