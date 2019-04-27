namespace DBPROJECT_A
{
    partial class Admin_Registration
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
            this.Email_Label = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.password2 = new System.Windows.Forms.TextBox();
            this.password2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Location = new System.Drawing.Point(12, 39);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(31, 13);
            this.Email_Label.TabIndex = 0;
            this.Email_Label.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 55);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(168, 20);
            this.EmailBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 119);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(168, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(12, 103);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 2;
            this.Password_Label.Text = "Password";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(60, 226);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(12, 180);
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(168, 20);
            this.password2.TabIndex = 6;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(12, 164);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(118, 13);
            this.password2Label.TabIndex = 5;
            this.password2Label.Text = "Re-Enter the password";
            // 
            // Admin_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 261);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password2Label);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.Email_Label);
            this.Name = "Admin_Registration";
            this.Text = "Admin_Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label password2Label;
    }
}