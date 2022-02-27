
namespace MahashakyaPharmacy.Reports
{
    partial class Invoice_Form
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
            this.tblSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Invoice_Report = new MahashakyaPharmacy.Reports.Invoice_Report();
            this.reportViewerInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblSalesTableAdapter = new MahashakyaPharmacy.Reports.Invoice_ReportTableAdapters.tblSalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSalesBindingSource
            // 
            this.tblSalesBindingSource.DataMember = "tblSales";
            this.tblSalesBindingSource.DataSource = this.Invoice_Report;
            // 
            // Invoice_Report
            // 
            this.Invoice_Report.DataSetName = "Invoice_Report";
            this.Invoice_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerInvoice
            // 
            this.reportViewerInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblSalesBindingSource;
            this.reportViewerInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerInvoice.LocalReport.ReportEmbeddedResource = "MahashakyaPharmacy.Reports.Invoice_Report.rdlc";
            this.reportViewerInvoice.Location = new System.Drawing.Point(15, 62);
            this.reportViewerInvoice.Name = "reportViewerInvoice";
            this.reportViewerInvoice.ServerReport.BearerToken = null;
            this.reportViewerInvoice.Size = new System.Drawing.Size(584, 671);
            this.reportViewerInvoice.TabIndex = 0;
            // 
            // tblSalesTableAdapter
            // 
            this.tblSalesTableAdapter.ClearBeforeFill = true;
            // 
            // Invoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 756);
            this.Controls.Add(this.reportViewerInvoice);
            this.Name = "Invoice_Form";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Invoice Print";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Invoice_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblSalesBindingSource;
        private Invoice_Report Invoice_Report;
        private Invoice_ReportTableAdapters.tblSalesTableAdapter tblSalesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInvoice;
    }
}