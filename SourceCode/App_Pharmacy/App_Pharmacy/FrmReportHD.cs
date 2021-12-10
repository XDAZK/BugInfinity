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
    public partial class FrmReportHD : Form
    {
        string mahd = "", nv = "", kh = "", ngaylap = "";
        public FrmReportHD()
        {
            InitializeComponent();
        }
        public FrmReportHD(string mahd, string nv, string kh, string ngaylap)
        {
            InitializeComponent();
            this.mahd = mahd;
            this.nv = nv;
            this.kh = kh;
            this.ngaylap = ngaylap;
        }

        private void FrmReportHD_Load(object sender, EventArgs e)
        {
            int maHD = int.Parse(mahd);
            // TODO: This line of code loads data into the 'QLNTDataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QLNTDataSet.HOADON,maHD);
            // TODO: This line of code loads data into the 'QLNTDataSet.CT_HOADON' table. You can move, or remove it, as needed.
            this.CT_HOADONTableAdapter.Fill(this.QLNTDataSet.CT_HOADON,maHD);
            // TODO: This line of code loads data into the 'QLNTDataSet.THUOC' table. You can move, or remove it, as needed.
            this.THUOCTableAdapter.Fill(this.QLNTDataSet.THUOC);
            ReportParameter[] reportParameters = new ReportParameter[4];
            reportParameters[0] = new ReportParameter("MAHD", mahd);
            reportParameters[1] = new ReportParameter("NV", nv);
            reportParameters[2] = new ReportParameter("KH", kh);
            reportParameters[3] = new ReportParameter("NGAYLAP", ngaylap);
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
