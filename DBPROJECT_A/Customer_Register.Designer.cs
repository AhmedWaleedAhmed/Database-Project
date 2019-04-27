namespace DBPROJECT_A
{
    partial class Customer_Register
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
            this.username_Label = new System.Windows.Forms.Label();
            this.username_Box = new System.Windows.Forms.TextBox();
            this.password_Label1 = new System.Windows.Forms.Label();
            this.password_Box1 = new System.Windows.Forms.TextBox();
            this.Password_Label2 = new System.Windows.Forms.Label();
            this.password_Box2 = new System.Windows.Forms.TextBox();
            this.email_Label = new System.Windows.Forms.Label();
            this.email_Box = new System.Windows.Forms.TextBox();
            this.BirthDate_Label = new System.Windows.Forms.Label();
            this.Adress_Box = new System.Windows.Forms.TextBox();
            this.Adress_Label = new System.Windows.Forms.Label();
            this.Register_Button = new System.Windows.Forms.Button();
            this.BirthDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter these data for registration";
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(9, 48);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(54, 13);
            this.username_Label.TabIndex = 1;
            this.username_Label.Text = "username";
            // 
            // username_Box
            // 
            this.username_Box.Location = new System.Drawing.Point(12, 64);
            this.username_Box.Name = "username_Box";
            this.username_Box.Size = new System.Drawing.Size(200, 20);
            this.username_Box.TabIndex = 2;
            // 
            // password_Label1
            // 
            this.password_Label1.AutoSize = true;
            this.password_Label1.Location = new System.Drawing.Point(9, 98);
            this.password_Label1.Name = "password_Label1";
            this.password_Label1.Size = new System.Drawing.Size(53, 13);
            this.password_Label1.TabIndex = 3;
            this.password_Label1.Text = "password";
            // 
            // password_Box1
            // 
            this.password_Box1.Location = new System.Drawing.Point(12, 114);
            this.password_Box1.Name = "password_Box1";
            this.password_Box1.PasswordChar = '*';
            this.password_Box1.Size = new System.Drawing.Size(200, 20);
            this.password_Box1.TabIndex = 4;
            // 
            // Password_Label2
            // 
            this.Password_Label2.AutoSize = true;
            this.Password_Label2.Location = new System.Drawing.Point(9, 153);
            this.Password_Label2.Name = "Password_Label2";
            this.Password_Label2.Size = new System.Drawing.Size(115, 13);
            this.Password_Label2.TabIndex = 5;
            this.Password_Label2.Text = "re-enter the password";
            // 
            // password_Box2
            // 
            this.password_Box2.Location = new System.Drawing.Point(12, 169);
            this.password_Box2.Name = "password_Box2";
            this.password_Box2.PasswordChar = '*';
            this.password_Box2.Size = new System.Drawing.Size(200, 20);
            this.password_Box2.TabIndex = 6;
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Location = new System.Drawing.Point(9, 204);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(35, 13);
            this.email_Label.TabIndex = 7;
            this.email_Label.Text = "E-mail";
            // 
            // email_Box
            // 
            this.email_Box.Location = new System.Drawing.Point(12, 220);
            this.email_Box.Name = "email_Box";
            this.email_Box.Size = new System.Drawing.Size(200, 20);
            this.email_Box.TabIndex = 8;
            // 
            // BirthDate_Label
            // 
            this.BirthDate_Label.AutoSize = true;
            this.BirthDate_Label.Location = new System.Drawing.Point(9, 258);
            this.BirthDate_Label.Name = "BirthDate_Label";
            this.BirthDate_Label.Size = new System.Drawing.Size(55, 13);
            this.BirthDate_Label.TabIndex = 9;
            this.BirthDate_Label.Text = "Birth Date";
            // 
            // Adress_Box
            // 
            this.Adress_Box.Location = new System.Drawing.Point(12, 330);
            this.Adress_Box.Name = "Adress_Box";
            this.Adress_Box.Size = new System.Drawing.Size(200, 20);
            this.Adress_Box.TabIndex = 12;
            // 
            // Adress_Label
            // 
            this.Adress_Label.AutoSize = true;
            this.Adress_Label.Location = new System.Drawing.Point(9, 314);
            this.Adress_Label.Name = "Adress_Label";
            this.Adress_Label.Size = new System.Drawing.Size(40, 13);
            this.Adress_Label.TabIndex = 11;
            this.Adress_Label.Text = "Adress";
            // 
            // Register_Button
            // 
            this.Register_Button.Location = new System.Drawing.Point(231, 382);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(75, 23);
            this.Register_Button.TabIndex = 13;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = true;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // BirthDate_Picker
            // 
            this.BirthDate_Picker.Location = new System.Drawing.Point(12, 274);
            this.BirthDate_Picker.Name = "BirthDate_Picker";
            this.BirthDate_Picker.Size = new System.Drawing.Size(200, 20);
            this.BirthDate_Picker.TabIndex = 14;
            this.BirthDate_Picker.Value = new System.DateTime(2018, 12, 4, 0, 0, 0, 0);
            // 
            // Customer_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 417);
            this.Controls.Add(this.BirthDate_Picker);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.Adress_Box);
            this.Controls.Add(this.Adress_Label);
            this.Controls.Add(this.BirthDate_Label);
            this.Controls.Add(this.email_Box);
            this.Controls.Add(this.email_Label);
            this.Controls.Add(this.password_Box2);
            this.Controls.Add(this.Password_Label2);
            this.Controls.Add(this.password_Box1);
            this.Controls.Add(this.password_Label1);
            this.Controls.Add(this.username_Box);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Register";
            this.Text = "Customer_Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.TextBox username_Box;
        private System.Windows.Forms.Label password_Label1;
        private System.Windows.Forms.TextBox password_Box1;
        private System.Windows.Forms.Label Password_Label2;
        private System.Windows.Forms.TextBox password_Box2;
        private System.Windows.Forms.Label email_Label;
        private System.Windows.Forms.TextBox email_Box;
        private System.Windows.Forms.Label BirthDate_Label;
        private System.Windows.Forms.TextBox Adress_Box;
        private System.Windows.Forms.Label Adress_Label;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.DateTimePicker BirthDate_Picker;
    }
}