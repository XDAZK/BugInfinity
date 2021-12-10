
namespace App_Pharmacy
{
    partial class FrmReportHD
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
            this.hoadonTableAdapter1 = new App_Pharmacy.QLNTDataSetTableAdapters.HOADONTableAdapter();
            this.cT_HOADONTableAdapter1 = new App_Pharmacy.QLNTDataSetTableAdapters.CT_HOADONTableAdapter();
            this.thuocTableAdapter1 = new App_Pharmacy.QLNTDataSetTableAdapters.THUOCTableAdapter();
            this.qlntDataSet1 = new App_Pharmacy.QLNTDataSet();
            this.QLNTDataSet = new App_Pharmacy.QLNTDataSet();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new App_Pharmacy.QLNTDataSetTableAdapters.HOADONTableAdapter();
            this.CT_HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CT_HOADONTableAdapter = new App_Pharmacy.QLNTDataSetTableAdapters.CT_HOADONTableAdapter();
            this.THUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THUOCTableAdapter = new App_Pharmacy.QLNTDataSetTableAdapters.THUOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlntDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THUOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HD";
            reportDataSource1.Value = this.HOADONBindingSource;
            reportDataSource2.Name = "CT_HD";
            reportDataSource2.Value = this.CT_HOADONBindingSource;
            reportDataSource3.Name = "THUOC";
            reportDataSource3.Value = this.THUOCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App_Pharmacy.RPHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // hoadonTableAdapter1
            // 
            this.hoadonTableAdapter1.ClearBeforeFill = true;
            // 
            // cT_HOADONTableAdapter1
            // 
            this.cT_HOADONTableAdapter1.ClearBeforeFill = true;
            // 
            // thuocTableAdapter1
            // 
            this.thuocTableAdapter1.ClearBeforeFill = true;
            // 
            // qlntDataSet1
            // 
            this.qlntDataSet1.DataSetName = "QLNTDataSet";
            this.qlntDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QLNTDataSet
            // 
            this.QLNTDataSet.DataSetName = "QLNTDataSet";
            this.QLNTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QLNTDataSet;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // CT_HOADONBindingSource
            // 
            this.CT_HOADONBindingSource.DataMember = "CT_HOADON";
            this.CT_HOADONBindingSource.DataSource = this.QLNTDataSet;
            // 
            // CT_HOADONTableAdapter
            // 
            this.CT_HOADONTableAdapter.ClearBeforeFill = true;
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
            // FrmReportHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportHD";
            this.Text = "FrmReportHD";
            this.Load += new System.EventHandler(this.FrmReportHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlntDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THUOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLNTDataSetTableAdapters.HOADONTableAdapter hoadonTableAdapter1;
        private QLNTDataSetTableAdapters.CT_HOADONTableAdapter cT_HOADONTableAdapter1;
        private QLNTDataSetTableAdapters.THUOCTableAdapter thuocTableAdapter1;
        private QLNTDataSet qlntDataSet1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QLNTDataSet QLNTDataSet;
        private System.Windows.Forms.BindingSource CT_HOADONBindingSource;
        private System.Windows.Forms.BindingSource THUOCBindingSource;
        private QLNTDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private QLNTDataSetTableAdapters.CT_HOADONTableAdapter CT_HOADONTableAdapter;
        private QLNTDataSetTableAdapters.THUOCTableAdapter THUOCTableAdapter;
    }
}