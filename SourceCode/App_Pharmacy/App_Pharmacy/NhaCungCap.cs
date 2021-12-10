using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//them 2 thu vien
using System.Data;
using System.Data.SqlClient;

namespace App_Pharmacy
{
    class NhaCungCap
    {
        Database db;
        public NhaCungCap()
        {
            db = new Database();
        }

        public DataTable LayDSNCC()
        {
            string strSQL = @"Select * From NHACUNGCAP";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void XoaNCC(string mancc)
        {
            string sql = @"delete from NHACUNGCAP where(MA_NCC = '" + mancc + "')";
            db.ExecuteNonQuery(sql);
        }

        public void ThemNCC(string mancc, string tenncc, string sdt, string diachi)
        {
            string sql = string.Format("Insert Into NHACUNGCAP Values('{0}',N'{1}','{2}',N'{3}')", mancc, tenncc, sdt, diachi);
            db.ExecuteNonQuery(sql);
        }

        public void CapNhatNCC(string mancc, string tenncc, string sdt, string diachi)
        {
            //Cap nhat du lieu
            string str = @"update NHACUNGCAP set MA_NCC = '" + mancc + "', TEN_NCC = N'" + tenncc + "', SDT_NCC = '" + sdt + "', DIA_CHI = N'" + diachi + "'  where(MA_NCC = '" + mancc + "')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTen(string timkiem)
        {
            string strSQL = "Select * From NHACUNGCAP where TEN_NCC Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
}
