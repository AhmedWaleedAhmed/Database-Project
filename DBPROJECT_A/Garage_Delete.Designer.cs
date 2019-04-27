namespace DBPROJECT_A
{
    partial class Garage_Delete
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
            this.GarageIDsconmboBox = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.garageDeleteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GarageIDsconmboBox
            // 
            this.GarageIDsconmboBox.FormattingEnabled = true;
            this.GarageIDsconmboBox.Location = new System.Drawing.Point(100, 36);
            this.GarageIDsconmboBox.Name = "GarageIDsconmboBox";
            this.GarageIDsconmboBox.Size = new System.Drawing.Size(121, 21);
            this.GarageIDsconmboBox.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(125, 63);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // garageDeleteLabel
            // 
            this.garageDeleteLabel.AutoSize = true;
            this.garageDeleteLabel.Location = new System.Drawing.Point(57, 9);
            this.garageDeleteLabel.Name = "garageDeleteLabel";
            this.garageDeleteLabel.Size = new System.Drawing.Size(206, 13);
            this.garageDeleteLabel.TabIndex = 2;
            this.garageDeleteLabel.Text = "Please choose your garage ID to delete it";
            // 
            // Garage_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 98);
            this.Controls.Add(this.garageDeleteLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GarageIDsconmboBox);
            this.Name = "Garage_Delete";
            this.Text = "Garage_Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Garage_Delete_FormClosed);
            this.Load += new System.EventHandler(this.Garage_Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GarageIDsconmboBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label garageDeleteLabel;
    }
}