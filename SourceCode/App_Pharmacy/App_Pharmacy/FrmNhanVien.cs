using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Pharmacy
{
    public partial class FrmNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        Boolean themmoi;
        int Tong = 0;
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private bool ktTrung(string manv)
        {
            for (int i = 0; i < lsvDanhSachThongTin.Items.Count; i++)
            {
                if (lsvDanhSachThongTin.Items[i].SubItems[0].Text.ToString() == manv)
                {
                    return true;
                }
            }
            return false;
        }
        //Hiển thị danh sách nhân viên
        private void HienthiNhanVien()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = nv.LayDSNhanVien();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i][0].ToString() != "NV00000000" && dt.Rows[i][6].ToString() != "Đã nghỉ" && dt.Rows[i][0].ToString() != "AD00000000")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        lvi.SubItems.Add(dt.Rows[i][5].ToString());
                        lvi.SubItems.Add(dt.Rows[i][6].ToString());
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
        //Hiển thị danh sách nhân viên tìm theo tên
        private void DSTimKiemTen()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = nv.TimKiemTen(txtTimKiem.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "NV00000000" && dt.Rows[i][6].ToString() != "Đã nghỉ" && dt.Rows[i][0].ToString() != "AD00000000")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        lvi.SubItems.Add(dt.Rows[i][5].ToString());
                        lvi.SubItems.Add(dt.Rows[i][6].ToString());
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
        #region set
        void setNull()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dtNgaySinh.Text = "1/1/1999";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            txtSDTNV.Text = "";
            cboBangCap.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            //btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void setKhoa(bool val)
        {
            txtMaNV.ReadOnly = val;
            txtTenNV.ReadOnly = val;
            dtNgaySinh.Enabled = !val;
            rbtnNam.Enabled = !val;
            rbtnNu.Enabled = !val;
            txtSDTNV.ReadOnly = val;
            cboBangCap.Enabled = !val;
        }
        #endregion
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

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            HienthiNhanVien();
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setNull();
            themmoi = true;
            dieuchinh(true);
            cboTinhTrang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
            dieuchinh(true);
            txtMaNV.ReadOnly = true;
            cboTinhTrang.Enabled = true;
        }

        /*private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        nv.CapNhatTaiKhoan(txtMaNV.Text);
                        nv.XoaNhanVien(txtMaNV.Text);
                        lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                        setNull();
                        HienthiNhanVien();
                    }
                }
                else
                    MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDTNV.Text) || string.IsNullOrEmpty(cboBangCap.Text) || (rbtnNam.Checked == false && rbtnNu.Checked == false))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    string ngay = String.Format("{0:yyyy-MM-dd}", dtNgaySinh.Value);
                    //Định dạng ngày tương ứng với trong CSDL SQLserver 
                    string gioitinh;
                    if (rbtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }
                    if (themmoi == true)
                    {
                        if (ktTrung(txtMaNV.Text) == false)
                        {
                            nv.ThemNhanVien(txtMaNV.Text, txtTenNV.Text, gioitinh, ngay, txtSDTNV.Text, cboBangCap.Text);
                            nv.ThemTaiKhoan(txtMaNV.Text, txtSDTNV.Text, txtMaNV.Text);
                            string thongbao = "Tài Khoản Mới: " + txtMaNV.Text + "\nMật Khẩu: " + txtSDTNV.Text;
                            MessageBox.Show("Thêm Nhân Viên thành Công\n" + thongbao, "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã nhân viên", "Thông Báo");
                        }
                    }
                    else
                    {
                        nv.CapNhatNhanVien(txtMaNV.Text, txtTenNV.Text, gioitinh, ngay, txtSDTNV.Text, cboBangCap.Text, cboTinhTrang.Text);
                        DataTable dt = nv.LayTinhTrang(txtMaNV.Text);
                        if(dt.Rows[0][0].ToString() == "Đã nghỉ")
                        {
                            nv.CapNhatTaiKhoanDong(txtMaNV.Text);
                        }
                        if (dt.Rows[0][0].ToString() == "Hoạt động")
                        {
                            nv.CapNhatTaiKhoanMo(txtMaNV.Text);
                        }
                        MessageBox.Show("Sửa Nhân Viên thành Công", "Thông Báo");
                    }
                    HienthiNhanVien();
                    setNull();
                    setButton(true);
                    setKhoa(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void lsvDanhSachThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    txtMaNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    string gioitinh = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                    if (gioitinh == "Nam")
                    {
                        rbtnNam.Checked = true;
                    }
                    else
                    {
                        rbtnNu.Checked = true;
                    }
                    dtNgaySinh.Value = DateTime.Parse(lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text);
                    txtSDTNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                    cboBangCap.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;
                    cboTinhTrang.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[6].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void lsvDanhSachThongTin_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    txtMaNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    string gioitinh = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                    if (gioitinh == "Nam")
                    {
                        rbtnNam.Checked = true;
                    }
                    else
                    {
                        rbtnNu.Checked = true;
                    }
                    dtNgaySinh.Value = DateTime.Parse(lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text);
                    txtSDTNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                    cboBangCap.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;
                    cboTinhTrang.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[6].Text;
                    dieuchinh(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    HienthiNhanVien();
                }
                else
                {
                    btnThem.Enabled = true;
                    lsvDanhSachThongTin.Items.Clear();
                    if (txtTimKiem.Text == "Nhập thông tin cần tìm")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        DSTimKiemTen();
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
            if (txtTimKiem.Text == "")
            {
                HienthiNhanVien();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        private void btnNVDaNghi_Click(object sender, EventArgs e)
        {
            if(btnNVDaNghi.Text == "Nhân Viên Đã Nghỉ")
            {
                btnNVDaNghi.Text = "Nhân Viên Đang Hoạt Động";
            }
            else
            {
                btnNVDaNghi.Text = "Nhân Viên Đã Nghỉ";
            }
        }

        private void btnNVDaNghi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(btnNVDaNghi.Text == "Nhân Viên Đang Hoạt Động")
                {
                    lsvDanhSachThongTin.Items.Clear();
                    DataTable dt = nv.LayDSNhanVien();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() != "NV00000000" && dt.Rows[i][6].ToString() == "Đã nghỉ" && dt.Rows[i][0].ToString() != "AD00000000")
                        {
                            ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                            lvi.SubItems.Add(dt.Rows[i][1].ToString());
                            lvi.SubItems.Add(dt.Rows[i][2].ToString());
                            lvi.SubItems.Add(dt.Rows[i][3].ToString());
                            lvi.SubItems.Add(dt.Rows[i][4].ToString());
                            lvi.SubItems.Add(dt.Rows[i][5].ToString());
                            lvi.SubItems.Add(dt.Rows[i][6].ToString());
                            Tong += 1;
                        }
                    }
                    lblTong.Text = Tong.ToString();
                    Tong = 0;
                }
                if(btnNVDaNghi.Text == "Nhân Viên Đã Nghỉ")
                {
                    HienthiNhanVien();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông Báo");
            }
        }
    }
}
