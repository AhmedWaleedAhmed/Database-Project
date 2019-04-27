namespace DBPROJECT_A
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Log_In_Button = new System.Windows.Forms.Button();
            this.OR_Label = new System.Windows.Forms.Label();
            this.Customer_Button = new System.Windows.Forms.Button();
            this.types = new System.Windows.Forms.GroupBox();
            this.AdminRadio = new System.Windows.Forms.RadioButton();
            this.workerRadio = new System.Windows.Forms.RadioButton();
            this.customerRadio = new System.Windows.Forms.RadioButton();
            this.OwnerRadio = new System.Windows.Forms.RadioButton();
            this.types.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the username and password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(24, 61);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(54, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "username";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(84, 58);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(126, 20);
            this.usernameBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(25, 105);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(84, 105);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(126, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.Location = new System.Drawing.Point(98, 272);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Size = new System.Drawing.Size(95, 23);
            this.Log_In_Button.TabIndex = 5;
            this.Log_In_Button.Text = "Log In";
            this.Log_In_Button.UseVisualStyleBackColor = true;
            this.Log_In_Button.Click += new System.EventHandler(this.Log_In_Button_Click);
            // 
            // OR_Label
            // 
            this.OR_Label.AutoSize = true;
            this.OR_Label.Location = new System.Drawing.Point(118, 298);
            this.OR_Label.Name = "OR_Label";
            this.OR_Label.Size = new System.Drawing.Size(65, 13);
            this.OR_Label.TabIndex = 6;
            this.OR_Label.Text = "OR Register";
            // 
            // Customer_Button
            // 
            this.Customer_Button.Location = new System.Drawing.Point(98, 314);
            this.Customer_Button.Name = "Customer_Button";
            this.Customer_Button.Size = new System.Drawing.Size(95, 23);
            this.Customer_Button.TabIndex = 8;
            this.Customer_Button.Text = "As Customer";
            this.Customer_Button.UseVisualStyleBackColor = true;
            this.Customer_Button.Click += new System.EventHandler(this.Customer_Button_Click);
            // 
            // types
            // 
            this.types.Controls.Add(this.AdminRadio);
            this.types.Controls.Add(this.workerRadio);
            this.types.Controls.Add(this.customerRadio);
            this.types.Controls.Add(this.OwnerRadio);
            this.types.Location = new System.Drawing.Point(73, 144);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(147, 122);
            this.types.TabIndex = 9;
            this.types.TabStop = false;
            this.types.Text = "choose your type of user";
            // 
            // AdminRadio
            // 
            this.AdminRadio.AutoSize = true;
            this.AdminRadio.Location = new System.Drawing.Point(6, 86);
            this.AdminRadio.Name = "AdminRadio";
            this.AdminRadio.Size = new System.Drawing.Size(54, 17);
            this.AdminRadio.TabIndex = 3;
            this.AdminRadio.TabStop = true;
            this.AdminRadio.Text = "Admin";
            this.AdminRadio.UseVisualStyleBackColor = true;
            // 
            // workerRadio
            // 
            this.workerRadio.AutoSize = true;
            this.workerRadio.Location = new System.Drawing.Point(6, 63);
            this.workerRadio.Name = "workerRadio";
            this.workerRadio.Size = new System.Drawing.Size(60, 17);
            this.workerRadio.TabIndex = 2;
            this.workerRadio.Text = "Worker";
            this.workerRadio.UseVisualStyleBackColor = true;
            // 
            // customerRadio
            // 
            this.customerRadio.AutoSize = true;
            this.customerRadio.Location = new System.Drawing.Point(6, 40);
            this.customerRadio.Name = "customerRadio";
            this.customerRadio.Size = new System.Drawing.Size(71, 17);
            this.customerRadio.TabIndex = 1;
            this.customerRadio.Text = "Customer";
            this.customerRadio.UseVisualStyleBackColor = true;
            // 
            // OwnerRadio
            // 
            this.OwnerRadio.AutoSize = true;
            this.OwnerRadio.Location = new System.Drawing.Point(7, 20);
            this.OwnerRadio.Name = "OwnerRadio";
            this.OwnerRadio.Size = new System.Drawing.Size(57, 17);
            this.OwnerRadio.TabIndex = 0;
            this.OwnerRadio.Text = "Owner";
            this.OwnerRadio.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 349);
            this.Controls.Add(this.types);
            this.Controls.Add(this.Customer_Button);
            this.Controls.Add(this.OR_Label);
            this.Controls.Add(this.Log_In_Button);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.types.ResumeLayout(false);
            this.types.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button Log_In_Button;
        private System.Windows.Forms.Label OR_Label;
        private System.Windows.Forms.Button Customer_Button;
        private System.Windows.Forms.GroupBox types;
        private System.Windows.Forms.RadioButton workerRadio;
        private System.Windows.Forms.RadioButton customerRadio;
        private System.Windows.Forms.RadioButton OwnerRadio;
        private System.Windows.Forms.RadioButton AdminRadio;
    }
}

