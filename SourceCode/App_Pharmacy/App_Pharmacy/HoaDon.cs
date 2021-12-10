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
    class HoaDon
    {
        Database db;
        public HoaDon()
        {
            db = new Database();
        }
        public DataTable LayDSHoaDon()
        {
            string strSQL = @"Select HD.MA_HOADON, KH.TEN_KHACHHANG, NV.TEN_NHANVIEN, HD.NGAY_LAP, HD.TONG_TIEN From HOADON HD, KHACHHANG KH,NHANVIEN NV where HD.MA_KHACHHANG = KH.MA_KHACHHANG AND HD.MA_NHANVIEN = NV.MA_NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable LayDSCTHoaDon(int mahd)
        {
            string strSQL = @"Select T.TEN_THUOC, CT.SO_LUONG, T.GIA_BAN, CT.THANH_TIEN From CT_HOADON CT, THUOC T  WHERE CT.MA_THUOC = T.MA_THUOC AND CT.MA_HOADON = "+ mahd +"";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void ThemHoaDon(int mahd, string manv, string ngaylap, int tongtien)
        {
            string makh = "KH00000000";
            string sql = string.Format("Insert Into HOADON Values({0},'{1}','{2}','{3}',{4})", mahd, makh, manv, ngaylap, tongtien);
            db.ExecuteNonQuery(sql);
        }
        public void ThemCT_HoaDon(int mahd, string mathuoc, int soluong, int thanhtien)
        {
            string sql = string.Format("Insert Into CT_HOADON Values({0},'{1}',{2},{3})", mahd, mathuoc, soluong, thanhtien);
            db.ExecuteNonQuery(sql);
        }
        /*public void CapNhatCT_HoaDon(int mahd, int soluong, int thanhtien)
        {
            string sql = @"Update CT_HOADON set SO_LUONG = "+ soluong +", THANH_TIEN = "+ thanhtien + " where MA_HOADON = "+mahd+"";
            db.ExecuteNonQuery(sql);
        }*/

        public DataTable layMaHD()
        {
            string strSQL = @"Select top 1 with ties MA_HOADON from HOADON Order by MA_HOADON DESC";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layTenNV(string maNV)
        {
            string strSQL = @"Select TEN_NHANVIEN from NHANVIEN where MA_NHANVIEN = '"+ maNV +"' ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layDSKH()
        {
            string strSQL = @"Select * from KHACHHANG";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layDSThuoc()
        {
            string strSQL = @"Select * from THUOC";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layGia(string tenthuoc)
        {
            string strSQL = @"Select * from THUOC where TEN_THUOC = N'"+ tenthuoc +"'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public DataTable TimKiemTenKH(string timkiem)
        {
            string strSQL = "Select * From KHACHHANG where TEN_KHACHHANG Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
        public DataTable TimKiemTenThuoc(string timkiem)
        {
            string strSQL = "Select * From THUOC where TEN_THUOC Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public void XoaHoaDon(int mahd)
        {
            string sql = @"delete from HOADON where(MA_HOADON = " + mahd + ")";
            db.ExecuteNonQuery(sql);
        }
        public void XoaCTHoaDon(int mahd)
        {
            string sql = @"delete from CT_HOADON where(MA_HOADON = " + mahd + ")";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatHoaDon(int mahd, string makh, int tongtien)
        {
            //Cap nhat du lieu
            string str = @"update HOADON set MA_KHACHHANG = '" + makh + "', TONG_TIEN = " + tongtien + " where(MA_HOADON = " + mahd + ")";
            db.ExecuteNonQuery(str);
        }

        public DataTable TongTien(int mahd)
        {
            string strSQL = @"select Sum(THANH_TIEN) from CT_HOADON where MA_HOADON = " + mahd + "";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void XoaThuoc(string mathuoc)
        {
            string sql = @"delete from CT_HOADON where(MA_THUOC = " + mathuoc + ")";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatThuoc(string mathuoc, int soluong, int thanhtien)
        {
            string sql = @"update CT_HOADON Set SO_LUONG = "+soluong+ ",THANH_TIEN = " + thanhtien + " where(MA_THUOC = " + mathuoc + ")";
            db.ExecuteNonQuery(sql);
        }

        public DataTable laySLTon(string tenthuoc)
        {
            string strSQL = @"Select SL_TON from THUOC where TEN_THUOC = '"+tenthuoc+"'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void CapNhatSLTon(string mathuoc, int soluong)
        {
            string sql = @"update CT_HOADON Set SO_LUONG = " + soluong + " where(MA_THUOC = " + mathuoc + ")";
            db.ExecuteNonQuery(sql);
        }
    }
}
