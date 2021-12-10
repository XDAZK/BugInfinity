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
    class QLTK
    {
        Database db;
        public QLTK()
        {
            db = new Database();
        }
        public DataTable LayDSTK()
        {
            string strSQL = "Select D.TAIKHOAN, D.MATKHAU, D.PHANLOAI, NV.TEN_NHANVIEN, D.TRANG_THAI From DANGNHAP D, NHANVIEN NV Where D.MA_NHANVIEN = NV.MA_NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void CapNhat(string taikhoan, int thuoc, int nhanvien, int kvlt, int khachhang, int ncc, int hoadon, int dondatthuoc)
        {
            //Cap nhat du lieu
            string str = @"update DANGNHAP set  PQ_THUOC = "+ thuoc + ", PQ_NHANVIEN = "+ nhanvien + ", PQ_KVLT = "+ kvlt +", PQ_KHACHHANG ="+ khachhang + ", PQ_NCC = "+ ncc + ", PQ_HOADON = "+ hoadon+ ", PQ_DONDATTHUOC = "+ dondatthuoc+ " where(TAIKHOAN = '" + taikhoan + "')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTenNV(string timkiem)
        {
            string strSQL = "Select * From NHANVIEN where TEN_NHANVIEN Like '%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
}
