
namespace App_Pharmacy
{
    partial class FrmReportDDT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLNTDataSet = new App_Pharmacy.QLNTDataSet();
            this.DONDATTHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DONDATTHUOCTableAdapter = new App_Pharmacy.QLNTDataSetTableAdapters.DONDATTHUOCTableAdapter();
            this.CT_DONDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CT_DONDATTableAdapter = new App_Pharmacy.QLNTDataSetTableAdapters.CT_DONDATTableAdapter();
            this.THUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THUOCTableAdapter = new App_Pharmacy.QLNTDataSetTableAdapters.THUOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DONDATTHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_DONDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THUOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DDT";
            reportDataSource1.Value = this.DONDATTHUOCBindingSource;
            reportDataSource2.Name = "CT_DDT";
            reportDataSource2.Value = this.CT_DONDATBindingSource;
            reportDataSource3.Name = "THUOC";
            reportDataSource3.Value = this.THUOCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App_Pharmacy.RPDDT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNTDataSet
            // 
            this.QLNTDataSet.DataSetName = "QLNTDataSet";
            this.QLNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DONDATTHUOCBindingSource
            // 
            this.DONDATTHUOCBindingSource.DataMember = "DONDATTHUOC";
            this.DONDATTHUOCBindingSource.DataSource = this.QLNTDataSet;
            // 
            // DONDATTHUOCTableAdapter
            // 
            this.DONDATTHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // CT_DONDATBindingSource
            // 
            this.CT_DONDATBindingSource.DataMember = "CT_DONDAT";
            this.CT_DONDATBindingSource.DataSource = this.QLNTDataSet;
            // 
            // CT_DONDATTableAdapter
            // 
            this.CT_DONDATTableAdapter.ClearBeforeFill = true;
            // 
            // THUOCBindingSource
            // 
            this.THUOCBindingSource.DataMember = "THUOC";
            this.THUOCBindingSource.DataSource = this.QLNTDataSet;
            // 
            // THUOCTableAdapter
            // 
            this.THUOCTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportDDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportDDT";
            this.Text = "FrmReportDDT";
            this.Load += new System.EventHandler(this.FrmReportDDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DONDATTHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_DONDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THUOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DONDATTHUOCBindingSource;
        private QLNTDataSet QLNTDataSet;
        private System.Windows.Forms.BindingSource CT_DONDATBindingSource;
        private System.Windows.Forms.BindingSource THUOCBindingSource;
        private QLNTDataSetTableAdapters.DONDATTHUOCTableAdapter DONDATTHUOCTableAdapter;
        private QLNTDataSetTableAdapters.CT_DONDATTableAdapter CT_DONDATTableAdapter;
        private QLNTDataSetTableAdapters.THUOCTableAdapter THUOCTableAdapter;
    }
}