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
    class KhachHang
    {
        Database db;
        public KhachHang()
        {
            db = new Database();
        }
        public DataTable LayDSKH()
        {
            string strSQL = @"Select MA_KHACHHANG,TEN_KHACHHANG,GIOI_TINH,format(KH_NGAYSINH, 'dd/MM/yyyy')as KH_NGAYSINH,SDT_KHACHHANG,BENH_LI From KHACHHANG";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void XoaKH(string makh)
        {
            string sql = @"delete from KHACHHANG where(MA_KHACHHANG = '" + makh + "')";
            db.ExecuteNonQuery(sql);
        }

        public void ThemKH(string makh, string tenkh, string gioitinh, string ngaysinh, string sdt,  string benhly)
        {
            string sql = string.Format("Insert Into KHACHHANG Values('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}')", makh, tenkh, gioitinh, ngaysinh, sdt, benhly);
            db.ExecuteNonQuery(sql);
        }

        public void CapNhatKH(string makh, string tenkh, string gioitinh, string ngaysinh, string sdt, string benhly)
        {
            //Cap nhat du lieu
            string str = @"update KHACHHANG set MA_KHACHHANG = '" + makh + "', TEN_KHACHHANG = N'" + tenkh + "', GIOI_TINH = '" + gioitinh + "', KH_NGAYSINH = '" + ngaysinh + "', SDT_KHACHHANG = '" + sdt + "', BENH_LI = '"+ benhly + "' where(MA_KHACHHANG = '" + makh + "')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTen(string timkiem)
        {
            string strSQL = "Select * From KHACHHANG where TEN_KHACHHANG Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
}
