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
    class DDT
    {
        Database db;
        public DDT()
        {
            db = new Database();
        }
        public DataTable LayDSDonDat()
        {
            string strSQL = @"Select DD.MA_DONDAT, NV.TEN_NHANVIEN, NCC.TEN_NCC, DD.NGAY_LAP From DONDATTHUOC DD, NHACUNGCAP NCC,NHANVIEN NV where DD.MA_NCC = NCC.MA_NCC AND DD.MA_NHANVIEN = NV.MA_NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable LayDSCTDonDat(int madd)
        {
            string strSQL = @"Select T.TEN_THUOC, CT.SL_DAT From CT_DONDAT CT, THUOC T  WHERE CT.MA_THUOC = T.MA_THUOC AND CT.MA_DONDAT = " + madd + "";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void ThemDonDat(int madd, string manv, string ngaylap)
        {
            string mancc = "NCC0000001";
            string sql = string.Format("Insert Into DONDATTHUOC Values({0},'{1}','{2}','{3}')", madd, manv, mancc, ngaylap);
            db.ExecuteNonQuery(sql);
        }
        public void ThemCT_DonDat(int mahd, string mathuoc, int soluong)
        {
            string sql = string.Format("Insert Into CT_DONDAT Values({0},'{1}',{2})", mahd, mathuoc, soluong);
            db.ExecuteNonQuery(sql);
        }
        /*public void CapNhatCT_DonDat(int madd, int soluong)
        {
            string sql = @"Update CT_DONDAT set SL_DAT = " + soluong + " where MA_DONDAT = " + madd + "";
            db.ExecuteNonQuery(sql);
        }*/

        public DataTable layMaDD()
        {
            string strSQL = @"Select top 1 with ties MA_DONDAT from DONDATTHUOC Order by MA_DONDAT DESC";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layTenNV(string maNV)
        {
            string strSQL = @"Select TEN_NHANVIEN from NHANVIEN where MA_NHANVIEN = '" + maNV + "' ";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable layDSNCC()
        {
            string strSQL = @"Select * from NHACUNGCAP";
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

        public DataTable TimKiemTenNCC(string timkiem)
        {
            string strSQL = "Select * From NHACUNGCAP where TEN_NCC Like N'%" + timkiem + "%'";
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

        public void XoaDonDat(int madd)
        {
            string sql = @"delete from DONDATTHUOC where(MA_DONDAT = " + madd + ")";
            db.ExecuteNonQuery(sql);
        }
        public void XoaCTDonDat(int madd)
        {
            string sql = @"delete from CT_DONDAT where(MA_DONDAT = " + madd + ")";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatDonDat(int madd, string macc)
        {
            //Cap nhat du lieu
            string str = @"update DONDATTHUOC set MA_NCC = '" + macc + "' where(MA_DONDAT = " + madd + ")";
            db.ExecuteNonQuery(str);
        }
        public void XoaThuoc(string mathuoc)
        {
            string sql = @"delete from CT_DONDAT where(MA_THUOC = " + mathuoc + ")";
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatThuoc(string mathuoc, int soluong)
        {
            string sql = @"update CT_DONDAT Set SO_LUONG = " + soluong + " where(MA_THUOC = " + mathuoc + ")";
            db.ExecuteNonQuery(sql);
        }
    }
}
