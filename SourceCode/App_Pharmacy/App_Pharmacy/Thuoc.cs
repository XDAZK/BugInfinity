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
    class Thuoc
    {
        Database db;
        public Thuoc()
        {
            db = new Database();
        }
        public DataTable LayDSThuoc()
        {
            string strSQL = @"Select T.MA_THUOC, T.TEN_THUOC, T.GIA_BAN, T.DON_VI_TINH, KV.TEN_KHUVUC From THUOC T, KV_LUUTRUTHUOC KV WHERE T.MA_KHUVUC = KV.MA_KHUVUC";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layDSKV()
        {
            string strSQL = @"Select * From KV_LUUTRUTHUOC";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void XoaThuoc(string mathuoc)
        {
            string sql = @"delete from THUOC where(MA_THUOC = '" + mathuoc + "')";
            db.ExecuteNonQuery(sql);
        }

        public void ThemThuoc(string mathuoc, string tenthuoc, string giaban, string donvitinh, string khuvuc)
        {
            string sql = string.Format("Insert Into THUOC Values('{0}',N'{1}','{2}',N'{3}',N'{4}')", mathuoc, tenthuoc, giaban, donvitinh, khuvuc);

            db.ExecuteNonQuery(sql);
        }

        public void CapNhatThuoc(string mathuoc, string tenthuoc, string giaban, string donvitinh, string khuvuc)
        {
            //Cap nhat du lieu
            string str = @"update THUOC set MA_THUOC = '" + mathuoc + "', TEN_THUOC = N'" + tenthuoc + "', GIA_BAN = '" + giaban + "', DON_VI_TINH = N'" + donvitinh + "', MA_KHUVUC = '"+ khuvuc +"' where(MA_THUOC = '" + mathuoc + "')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTen(string timkiem)
        {
            string strSQL = "Select * From THUOC where TEN_THUOC Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
}
