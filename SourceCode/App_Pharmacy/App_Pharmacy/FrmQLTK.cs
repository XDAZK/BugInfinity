using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace App_Pharmacy
{
    public partial class FrmQLTK : Form
    {
        QLTK tk = new QLTK();
        int Tong = 0;
        string tendangnhap = "", matkhau = "", maNV = "";
        int phanloai, PQ_thuoc, PQ_nhanvien, PQ_kvlt, PQ_khachhang, PQ_ncc, PQ_hoadon, PQ_dondatthuoc;
        public FrmQLTK()
        {
            InitializeComponent();
        }
        public FrmQLTK(string tendangnhap, string matkhau, int phanloai, string maNV, int PQ_thuoc, int PQ_nhanvien, int PQ_kvlt, int PQ_khachhang, int PQ_ncc, int PQ_hoadon, int PQ_dondatthuoc)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.phanloai = phanloai;
            this.maNV = maNV;
            this.PQ_thuoc = PQ_thuoc;
            this.PQ_nhanvien = PQ_nhanvien;
            this.PQ_kvlt = PQ_kvlt;
            this.PQ_khachhang = PQ_khachhang;
            this.PQ_ncc = PQ_ncc;
            this.PQ_hoadon = PQ_hoadon;
            this.PQ_dondatthuoc = PQ_dondatthuoc;
        }
        //Hiển thị danh sách thuốc
        private void HienthiTK()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = tk.LayDSTK();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i][3].ToString() != "NV00000000" && dt.Rows[i][4].ToString() != "Đã đóng")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        Tong += 1;
                    }
                }
                lblTong.Text = Tong.ToString();
                Tong = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hiển thị danh sách thuốc tìm theo tên
        private void DSTimKiemTaiKhoan()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = tk.TimKiemTenNV(txtTimKiem.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][3].ToString() != "NV00000000" && dt.Rows[i][4].ToString() != "Đã đóng")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        Tong += 1;
                    }
                }
                lblTong.Text = Tong.ToString();
                Tong = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void setNull()
        {
            txtTenNV.Text = "";
            cbThuoc.Checked = false;
            cbNhanVien.Checked = false;
            cbKVLT.Checked = false;
            cbKhachHang.Checked = false;
            cbNhaCungCap.Checked = false;
            cbHoaDon.Checked = false;
            cbDonDatHang.Checked = false;
        }

        void setButton(bool val)
        {
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnKhoiPhuc.Enabled = !val;
        }
        void setKhoa(bool val)
        {
            txtTenNV.ReadOnly = val;
            cbThuoc.Enabled = !val;
            cbNhanVien.Enabled = !val;
            cbKVLT.Enabled = !val;
            cbKhachHang.Enabled = !val;
            cbNhaCungCap.Enabled = !val;
            cbHoaDon.Enabled = !val;
            cbDonDatHang.Enabled = !val;
        }
        private void FrmQLTK_Load(object sender, EventArgs e)
        {
            HienthiTK();
            txtTenNV.Text = "";
            txtTenNV.ReadOnly = true;
            setButton(true);
            setNull();
            setKhoa(true);
            btnPhanQuyen.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    HienthiTK();
                }
                else
                {
                    lsvDanhSachThongTin.Items.Clear();
                    if (txtTimKiem.Text == "Nhập thông tin cần tìm")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        DSTimKiemTaiKhoan();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    HienthiTK();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //điều chỉnh khu vực nhập thông tin
        private void dieuchinh(bool e)
        {
            if (e == true)
            {
                pnThongTin.Visible = true;
                pbUpDown.IconChar = IconChar.AngleDown;
            }
            else
            {
                pnThongTin.Visible = false;
                pbUpDown.IconChar = IconChar.AngleUp;
            }
        }

        private void pbUpDown_Click(object sender, EventArgs e)
        {
            if (pbUpDown.IconChar == IconChar.AngleUp)
            {
                dieuchinh(true);
            }
            else
            {
                dieuchinh(false);
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            btnPhanQuyen.Enabled = false;
            setButton(false);
            txtTenNV.ReadOnly = true;
            dieuchinh(true);
            setKhoa(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //thuốc
                if (cbThuoc.Checked == false)
                    PQ_thuoc = 0;
                else
                    PQ_thuoc = 1;
                //nhân viên
                if (cbNhanVien.Checked == false)
                    PQ_nhanvien = 0;
                else
                    PQ_nhanvien = 1;
                //khu vực lưu trữ
                if (cbKVLT.Checked == false)
                    PQ_kvlt = 0;
                else
                    PQ_kvlt = 1;
                //khách hàng
                if (cbKhachHang.Checked == false)
                    PQ_khachhang = 0;
                else
                    PQ_khachhang = 1;
                //Nhà cung cấp
                if (cbNhaCungCap.Checked == false)
                    PQ_ncc = 0;
                else
                    PQ_ncc = 1;
                //hóa đơn
                if (cbHoaDon.Checked == false)
                    PQ_hoadon = 0;
                else
                    PQ_hoadon = 1;
                //đơn đặt thuốc
                if (cbDonDatHang.Checked == false)
                    PQ_dondatthuoc = 0;
                else
                    PQ_dondatthuoc = 1;
                string taikhoan = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                tk.CapNhat(taikhoan, PQ_thuoc, PQ_nhanvien, PQ_kvlt, PQ_khachhang, PQ_ncc, PQ_hoadon, PQ_dondatthuoc);
                MessageBox.Show("Phân Quyền Thành Công","Thông Báo");
                setNull();
                setButton(true);
                btnPhanQuyen.Enabled = false;
                setKhoa(true);
                txtTenNV.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phân quyền lỗi vui lòng xem lại","Thông báo");
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            btnPhanQuyen.Enabled = false;
            setKhoa(true);
            txtTenNV.ReadOnly = true;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            txtTenNV.ReadOnly = true;
            cbThuoc.Checked = true;
            cbNhanVien.Checked = true;
            cbKVLT.Checked = true;
            cbKhachHang.Checked = true;
            cbNhaCungCap.Checked = true;
            cbHoaDon.Checked = true;
            cbDonDatHang.Checked = true;
        }
        private void lsvDanhSachThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnPhanQuyen.Enabled = true;
                txtTenNV.ReadOnly = true;
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    txtTenNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                    //thuốc
                    if (PQ_thuoc == 1)
                        cbThuoc.Checked = true;
                    else
                        cbThuoc.Checked = false;
                    //nhân viên
                    if (PQ_nhanvien == 1)
                        cbNhanVien.Checked = true;
                    else
                        cbNhanVien.Checked = false;
                    //khu vực lưu trữ
                    if (PQ_kvlt == 1)
                        cbKVLT.Checked = true;
                    else
                        cbKVLT.Checked = false;
                    //khách hàng
                    if (PQ_khachhang == 1)
                        cbKhachHang.Checked = true;
                    else
                        cbKhachHang.Checked = false;
                    //Nhà cung cấp
                    if (PQ_ncc == 1)
                        cbNhaCungCap.Checked = true;
                    else
                        cbNhaCungCap.Checked = false;
                    //hóa đơn
                    if (PQ_hoadon == 1)
                        cbHoaDon.Checked = true;
                    else
                        cbHoaDon.Checked = false;
                    //đơn đặt thuốc
                    if (PQ_dondatthuoc == 1)
                        cbDonDatHang.Checked = true;
                    else
                        cbDonDatHang.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTaiKhoanDong_Click(object sender, EventArgs e)
        {
            if (btnTaiKhoanDong.Text == "Tài Khoản Đã Đóng")
            {
                btnTaiKhoanDong.Text = "Tài Khoản Đang Hoạt Động";
            }
            else
            {
                btnTaiKhoanDong.Text = "Tài Khoản Đã Đóng";
            }
        }

        private void btnTaiKhoanDong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnTaiKhoanDong.Text == "Tài Khoản Đang Hoạt Động")
                {
                    lsvDanhSachThongTin.Items.Clear();
                    DataTable dt = tk.LayDSTK();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][3].ToString() != "NV00000000" && dt.Rows[i][4].ToString() == "Đã đóng")
                        {
                            ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                            lvi.SubItems.Add(dt.Rows[i][1].ToString());
                            lvi.SubItems.Add(dt.Rows[i][2].ToString());
                            lvi.SubItems.Add(dt.Rows[i][3].ToString());
                            lvi.SubItems.Add(dt.Rows[i][4].ToString());
                            Tong += 1;
                        }
                    }
                    lblTong.Text = Tong.ToString();
                    Tong = 0;
                }
                if (btnTaiKhoanDong.Text == "Tài Khoản Đã Đóng")
                {
                    HienthiTK();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
