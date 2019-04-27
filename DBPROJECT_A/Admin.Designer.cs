namespace DBPROJECT_A
{
    partial class Admin
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
            this.AddOwner = new System.Windows.Forms.Button();
            this.AddAdmin = new System.Windows.Forms.Button();
            this.DeleteOwner = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.DeleteAdmin = new System.Windows.Forms.Button();
            this.ownerDelete = new System.Windows.Forms.ComboBox();
            this.CustomerDelete = new System.Windows.Forms.ComboBox();
            this.AdminDelete = new System.Windows.Forms.ComboBox();
            this.SHOW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOwner
            // 
            this.AddOwner.Location = new System.Drawing.Point(16, 15);
            this.AddOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddOwner.Name = "AddOwner";
            this.AddOwner.Size = new System.Drawing.Size(169, 38);
            this.AddOwner.TabIndex = 0;
            this.AddOwner.Text = "Add Owner";
            this.AddOwner.UseVisualStyleBackColor = true;
            this.AddOwner.Click += new System.EventHandler(this.AddOwner_Click);
            // 
            // AddAdmin
            // 
            this.AddAdmin.Location = new System.Drawing.Point(16, 60);
            this.AddAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(169, 38);
            this.AddAdmin.TabIndex = 1;
            this.AddAdmin.Text = "Add Admin";
            this.AddAdmin.UseVisualStyleBackColor = true;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
            // 
            // DeleteOwner
            // 
            this.DeleteOwner.Location = new System.Drawing.Point(16, 106);
            this.DeleteOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteOwner.Name = "DeleteOwner";
            this.DeleteOwner.Size = new System.Drawing.Size(169, 38);
            this.DeleteOwner.TabIndex = 2;
            this.DeleteOwner.Text = "Delete Owner";
            this.DeleteOwner.UseVisualStyleBackColor = true;
            this.DeleteOwner.Click += new System.EventHandler(this.DeleteOwner_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Location = new System.Drawing.Point(16, 151);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(169, 38);
            this.DeleteCustomer.TabIndex = 3;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // DeleteAdmin
            // 
            this.DeleteAdmin.Location = new System.Drawing.Point(16, 197);
            this.DeleteAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteAdmin.Name = "DeleteAdmin";
            this.DeleteAdmin.Size = new System.Drawing.Size(169, 38);
            this.DeleteAdmin.TabIndex = 4;
            this.DeleteAdmin.Text = "Delete Admin";
            this.DeleteAdmin.UseVisualStyleBackColor = true;
            this.DeleteAdmin.Click += new System.EventHandler(this.DeleteAdmin_Click);
            // 
            // ownerDelete
            // 
            this.ownerDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerDelete.FormattingEnabled = true;
            this.ownerDelete.Location = new System.Drawing.Point(248, 106);
            this.ownerDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ownerDelete.Name = "ownerDelete";
            this.ownerDelete.Size = new System.Drawing.Size(220, 24);
            this.ownerDelete.TabIndex = 5;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerDelete.FormattingEnabled = true;
            this.CustomerDelete.Location = new System.Drawing.Point(248, 151);
            this.CustomerDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(220, 24);
            this.CustomerDelete.TabIndex = 6;
            // 
            // AdminDelete
            // 
            this.AdminDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminDelete.FormattingEnabled = true;
            this.AdminDelete.Location = new System.Drawing.Point(248, 197);
            this.AdminDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminDelete.Name = "AdminDelete";
            this.AdminDelete.Size = new System.Drawing.Size(220, 24);
            this.AdminDelete.TabIndex = 7;
            // 
            // SHOW
            // 
            this.SHOW.Location = new System.Drawing.Point(248, 15);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(220, 68);
            this.SHOW.TabIndex = 8;
            this.SHOW.Text = "SHOW";
            this.SHOW.UseVisualStyleBackColor = true;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 247);
            this.Controls.Add(this.SHOW);
            this.Controls.Add(this.AdminDelete);
            this.Controls.Add(this.CustomerDelete);
            this.Controls.Add(this.ownerDelete);
            this.Controls.Add(this.DeleteAdmin);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.DeleteOwner);
            this.Controls.Add(this.AddAdmin);
            this.Controls.Add(this.AddOwner);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddOwner;
        private System.Windows.Forms.Button AddAdmin;
        private System.Windows.Forms.Button DeleteOwner;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button DeleteAdmin;
        private System.Windows.Forms.ComboBox ownerDelete;
        private System.Windows.Forms.ComboBox CustomerDelete;
        private System.Windows.Forms.ComboBox AdminDelete;
        private System.Windows.Forms.Button SHOW;
    }
}