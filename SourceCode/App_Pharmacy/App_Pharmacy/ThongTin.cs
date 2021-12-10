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
    class ThongTin
    {
        Database db;
        public ThongTin()
        {
            db = new Database();
        }
        public DataTable LayThongTinNV(string maNV)
        {
            string strSQL = @"Select MA_NHANVIEN,TEN_NHANVIEN,GIOI_TINH,format(NV_NGAYSINH, 'dd/MM/yyyy')as NV_NGAYSINH,SDT_NHANVIEN,BANG_CAP,TINH_TRANG From NHANVIEN where (MA_NHANVIEN = '" + maNV +"')";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable LayThongTinTK(string maNV)
        {
            string strSQL = @"Select TAIKHOAN, MATKHAU From DANGNHAP where (MA_NHANVIEN = '"+ maNV +"')";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void CapNhatThongTinNV(string manv, string tennv, string gioitinh, string ngaysinh, string sdt, string bangcap)
        {
            //Cap nhat du lieu
            string str = @"update NHANVIEN set MA_NHANVIEN = '" + manv + "', TEN_NHANVIEN = N'" + tennv + "', GIOI_TINH = N'" + gioitinh + "', NV_NGAYSINH = '" + ngaysinh + "', SDT_NHANVIEN = '" + sdt + "', BANG_CAP = N'" + bangcap + "' where(MA_NHANVIEN = '" + manv + "')";
            db.ExecuteNonQuery(str);
        }
        public void DoiMatKhau(string maNV, string matkhau)
        {
            //Cap nhat du lieu
            string str = @"update DANGNHAP set MATKHAU = '" + matkhau + "'  where(MA_NHANVIEN = '" + maNV + "')";
            db.ExecuteNonQuery(str);
        }
    }
}
