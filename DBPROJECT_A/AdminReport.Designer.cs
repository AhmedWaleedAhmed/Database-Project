namespace DBPROJECT_A
{
    partial class AdminReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GarageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new DBPROJECT_A.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GarageTableAdapter = new DBPROJECT_A.DataSet1TableAdapters.GarageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GarageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // GarageBindingSource
            // 
            this.GarageBindingSource.DataMember = "Garage";
            this.GarageBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GarageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBPROJECT_A.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(871, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // GarageTableAdapter
            // 
            this.GarageTableAdapter.ClearBeforeFill = true;
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AdminReport";
            this.Text = "AdminReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminReport_FormClosed);
            this.Load += new System.EventHandler(this.AdminReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GarageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource GarageBindingSource;
        private DataSet1TableAdapters.GarageTableAdapter GarageTableAdapter;
    }
}