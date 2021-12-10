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
    class KVLT
    {
        Database db;
        public KVLT()
        {
            db = new Database();
        }
        public DataTable LayDSKVLT()
        {
            string strSQL = @"Select * From KV_LUUTRUTHUOC";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void XoaKVLT(string makv)
        {
            string sql = @"delete from KV_LUUTRUTHUOC where(MA_KHUVUC = '" + makv + "')";
            db.ExecuteNonQuery(sql);
        }
        public void ThemKVLT(string makv, string tenkv)
        {
            string sql = string.Format("Insert Into KV_LUUTRUTHUOC Values('{0}',N'{1}')", makv, tenkv);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string makv, string tenkv)
        {
            //Cap nhat du lieu
            string str = @"update KV_LUUTRUTHUOC set MA_KHUVUC = '" + makv + "', TEN_KHUVUC = N'" + tenkv + "' where(MA_KHUVUC = '"+ makv +"')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTen(string timkiem)
        {
            string strSQL = "Select * From KV_LUUTRUTHUOC where TEN_KHUVUC Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
}
