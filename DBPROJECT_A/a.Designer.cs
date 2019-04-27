namespace DBPROJECT_A
{
    partial class Form1
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
            this.Garage_Name = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.Show_Info = new System.Windows.Forms.Button();
            this.start_work = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Garage_Name
            // 
            this.Garage_Name.AutoSize = true;
            this.Garage_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Garage_Name.Location = new System.Drawing.Point(260, 22);
            this.Garage_Name.Name = "Garage_Name";
            this.Garage_Name.Size = new System.Drawing.Size(0, 39);
            this.Garage_Name.TabIndex = 0;
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(502, 52);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(152, 66);
            this.update_btn.TabIndex = 1;
            this.update_btn.Text = "Update_Info";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Show_Info
            // 
            this.Show_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Info.Location = new System.Drawing.Point(64, 52);
            this.Show_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show_Info.Name = "Show_Info";
            this.Show_Info.Size = new System.Drawing.Size(137, 66);
            this.Show_Info.TabIndex = 2;
            this.Show_Info.Text = "Show_Info";
            this.Show_Info.UseVisualStyleBackColor = true;
            this.Show_Info.Click += new System.EventHandler(this.Show_Info_Click);
            // 
            // start_work
            // 
            this.start_work.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_work.Location = new System.Drawing.Point(64, 293);
            this.start_work.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_work.Name = "start_work";
            this.start_work.Size = new System.Drawing.Size(137, 66);
            this.start_work.TabIndex = 3;
            this.start_work.Text = "Start_Work";
            this.start_work.UseVisualStyleBackColor = true;
            this.start_work.Click += new System.EventHandler(this.start_work_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 99);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show_Archive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_work);
            this.Controls.Add(this.Show_Info);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Garage_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Garage_Name;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Show_Info;
        private System.Windows.Forms.Button start_work;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

