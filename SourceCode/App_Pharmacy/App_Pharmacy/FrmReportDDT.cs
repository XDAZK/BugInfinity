using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Pharmacy
{
    public partial class FrmReportDDT : Form
    {
        string maddt = "", nv = "", ncc = "", ngaylap = "";
        public FrmReportDDT()
        {
            InitializeComponent();
        }
        public FrmReportDDT(string maddt, string nv, string ncc, string ngaylap)
        {
            InitializeComponent();
            this.maddt = maddt;
            this.nv = nv;
            this.ncc = ncc;
            this.ngaylap = ngaylap;
        }
        private void FrmReportDDT_Load(object sender, EventArgs e)
        {
            int maDDT = int.Parse(maddt);
            // TODO: This line of code loads data into the 'QLNTDataSet.DONDATTHUOC' table. You can move, or remove it, as needed.
            this.DONDATTHUOCTableAdapter.Fill(this.QLNTDataSet.DONDATTHUOC,maDDT);
            // TODO: This line of code loads data into the 'QLNTDataSet.CT_DONDAT' table. You can move, or remove it, as needed.
            this.CT_DONDATTableAdapter.Fill(this.QLNTDataSet.CT_DONDAT,maDDT);
            // TODO: This line of code loads data into the 'QLNTDataSet.THUOC' table. You can move, or remove it, as needed.
            this.THUOCTableAdapter.Fill(this.QLNTDataSet.THUOC);
            ReportParameter[] reportParameters = new ReportParameter[4];
            reportParameters[0] = new ReportParameter("MADDT", maddt);
            reportParameters[1] = new ReportParameter("NV", nv);
            reportParameters[2] = new ReportParameter("NCC", ncc);
            reportParameters[3] = new ReportParameter("NGAYLAP", ngaylap);
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
