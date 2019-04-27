namespace DBPROJECT_A
{
    partial class Owner
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
            this.Add_Worker = new System.Windows.Forms.Button();
            this.Delete_Worker = new System.Windows.Forms.Button();
            this.ADD_Garage = new System.Windows.Forms.Button();
            this.Delete_Garage = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Worker
            // 
            this.Add_Worker.Location = new System.Drawing.Point(31, 26);
            this.Add_Worker.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Worker.Name = "Add_Worker";
            this.Add_Worker.Size = new System.Drawing.Size(119, 76);
            this.Add_Worker.TabIndex = 0;
            this.Add_Worker.Text = "Add_Worker";
            this.Add_Worker.UseVisualStyleBackColor = true;
            this.Add_Worker.Click += new System.EventHandler(this.Add_Worker_Click);
            // 
            // Delete_Worker
            // 
            this.Delete_Worker.Location = new System.Drawing.Point(512, 26);
            this.Delete_Worker.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Worker.Name = "Delete_Worker";
            this.Delete_Worker.Size = new System.Drawing.Size(110, 76);
            this.Delete_Worker.TabIndex = 1;
            this.Delete_Worker.Text = "Delete_Worker";
            this.Delete_Worker.UseVisualStyleBackColor = true;
            this.Delete_Worker.Click += new System.EventHandler(this.Delete_Worker_Click);
            // 
            // ADD_Garage
            // 
            this.ADD_Garage.Location = new System.Drawing.Point(31, 206);
            this.ADD_Garage.Margin = new System.Windows.Forms.Padding(2);
            this.ADD_Garage.Name = "ADD_Garage";
            this.ADD_Garage.Size = new System.Drawing.Size(119, 76);
            this.ADD_Garage.TabIndex = 2;
            this.ADD_Garage.Text = "ADD_Garage";
            this.ADD_Garage.UseVisualStyleBackColor = true;
            this.ADD_Garage.Click += new System.EventHandler(this.ADD_Garage_Click);
            // 
            // Delete_Garage
            // 
            this.Delete_Garage.Location = new System.Drawing.Point(512, 206);
            this.Delete_Garage.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Garage.Name = "Delete_Garage";
            this.Delete_Garage.Size = new System.Drawing.Size(110, 76);
            this.Delete_Garage.TabIndex = 3;
            this.Delete_Garage.Text = "Delete_Garage";
            this.Delete_Garage.UseVisualStyleBackColor = true;
            this.Delete_Garage.Click += new System.EventHandler(this.Delete_Garage_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(31, 355);
            this.Show.Margin = new System.Windows.Forms.Padding(2);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(119, 76);
            this.Show.TabIndex = 4;
            this.Show.Text = "Garages Statistics";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 486);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Delete_Garage);
            this.Controls.Add(this.ADD_Garage);
            this.Controls.Add(this.Delete_Worker);
            this.Controls.Add(this.Add_Worker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Owner";
            this.Text = "Owner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_FormClosed);
            this.Load += new System.EventHandler(this.Owner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Worker;
        private System.Windows.Forms.Button Delete_Worker;
        private System.Windows.Forms.Button ADD_Garage;
        private System.Windows.Forms.Button Delete_Garage;
        private System.Windows.Forms.Button Show;
    }
}