namespace FormProfile
{
    partial class FormSwitchUser
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
            this.gbCreateUser = new System.Windows.Forms.GroupBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditName
            // 
            this.btnEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditName.Location = new System.Drawing.Point(192, 116);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(87, 23);
            this.btnEditName.TabIndex = 4;
            this.btnEditName.Text = "Create";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFamilyName
            // 
            this.tbFamilyName.Location = new System.Drawing.Point(129, 55);
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.Size = new System.Drawing.Size(150, 20);
            this.tbFamilyName.TabIndex = 2;
            this.tbFamilyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFamilyName_KeyDown);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(129, 29);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFirstName_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Family Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Patronymic:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(129, 81);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(150, 20);
            this.tbPatronymic.TabIndex = 3;
            this.tbPatronymic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPatronymic_KeyDown);
            // 
            // gbCreateUser
            // 
            this.gbCreateUser.Controls.Add(this.label1);
            this.gbCreateUser.Controls.Add(this.btnEditName);
            this.gbCreateUser.Controls.Add(this.tbPatronymic);
            this.gbCreateUser.Controls.Add(this.label2);
            this.gbCreateUser.Controls.Add(this.tbFamilyName);
            this.gbCreateUser.Controls.Add(this.label3);
            this.gbCreateUser.Controls.Add(this.tbFirstName);
            this.gbCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCreateUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCreateUser.Location = new System.Drawing.Point(23, 273);
            this.gbCreateUser.Name = "gbCreateUser";
            this.gbCreateUser.Size = new System.Drawing.Size(301, 153);
            this.gbCreateUser.TabIndex = 108;
            this.gbCreateUser.TabStop = false;
            this.gbCreateUser.Text = "Create New User";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colUser});
            this.lvUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvUsers.Location = new System.Drawing.Point(23, 52);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(301, 152);
            this.lvUsers.TabIndex = 109;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colUser
            // 
            this.colUser.Text = "Users";
            this.colUser.Width = 235;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "Users";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Location = new System.Drawing.Point(215, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 30);
            this.btnLogin.TabIndex = 106;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormSwitchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 446);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.gbCreateUser);
            this.Name = "FormSwitchUser";
            this.Text = "FormSwitchUser";
            this.gbCreateUser.ResumeLayout(false);
            this.gbCreateUser.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCreateUser;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colUser;
    }
}