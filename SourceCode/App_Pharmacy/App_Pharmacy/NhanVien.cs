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
    class NhanVien
    {
        Database db;
        public NhanVien()
        {
            db = new Database();
        }
        public DataTable LayDSNhanVien()
        {
            string strSQL = @"SELECT MA_NHANVIEN,TEN_NHANVIEN,GIOI_TINH,format(NV_NGAYSINH, 'dd/MM/yyyy')as NV_NGAYSINH,SDT_NHANVIEN,BANG_CAP,TINH_TRANG  from NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable LayTinhTrang(string manv)
        {
            string strSQL = @"SELECT TINH_TRANG from NHANVIEN where MA_NHANVIEN = '"+ manv+"'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void CapNhatTaiKhoanDong(string taikhoan)
        {
            //Cap nhat du lieu
            string tt = "Đã đóng";
            string str = @"update DANGNHAP set TRANG_THAI = N'"+ tt +"' where(TAIKHOAN = '" + taikhoan + "')";
            db.ExecuteNonQuery(str);
        }
        public void CapNhatTaiKhoanMo(string taikhoan)
        {
            //Cap nhat du lieu
            string tt = "Hoạt động";
            string str = @"update DANGNHAP set TRANG_THAI = N'" + tt + "' where(TAIKHOAN = '" + taikhoan + "')";
            db.ExecuteNonQuery(str);
        }
        /*public void XoaNhanVien(string manv)
        {
            string sql = @"delete from NHANVIEN where(MA_NHANVIEN = '" + manv + "')";
            db.ExecuteNonQuery(sql);
        }*/
        public void ThemNhanVien(string manv, string tennv, string gioitinh, string ngaysinh,  string sdt, string bangcap)
        {
            string tinhtrang = "Hoạt động";
            string sql = string.Format("Insert Into NHANVIEN Values('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}',N'{6}')", manv, tennv, gioitinh, ngaysinh, sdt, bangcap, tinhtrang);
            db.ExecuteNonQuery(sql);
        }
        public void ThemTaiKhoan(string taikhoan, string matkhau, string manv)
        {
            string trangthai = "Hoạt động";
            string sql = string.Format("Insert into DANGNHAP Values('{0}','{1}',{2},'{3}',N'{4}',{5},{6},{7},{8},{9},{10},{11})", taikhoan, matkhau, 2, manv, trangthai,1,1,1,1,1,1,1);
            db.ExecuteNonQuery(sql);
        }

        public void CapNhatNhanVien(string manv, string tennv, string gioitinh, string ngaysinh,  string sdt, string bangcap, string tinhtrang)
        {
            //Cap nhat du lieu
            string str = @"update NHANVIEN set MA_NHANVIEN = '" + manv + "', TEN_NHANVIEN = N'" + tennv + "', NV_NGAYSINH = '" + ngaysinh + "', GIOI_TINH = N'" + gioitinh + "', SDT_NHANVIEN = '" + sdt + "', BANG_CAP = N'" + bangcap + "', TINH_TRANG = N'"+ tinhtrang +"' where(MA_NHANVIEN = '" + manv + "')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTen(string timkiem)
        {
            string strSQL = "Select * From NHANVIEN where TEN_NHANVIEN Like N'%" + timkiem + "%'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
    
}
