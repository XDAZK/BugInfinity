using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//thêm thư viện
using FontAwesome.Sharp;

namespace App_Pharmacy
{
    public partial class FrmKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        Boolean themmoi;
        int Tong = 0;
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        private bool ktTrung(string makh)
        {
            for (int i = 0; i < lsvDanhSachThongTin.Items.Count; i++)
            {
                if (lsvDanhSachThongTin.Items[i].SubItems[0].Text.ToString() == makh)
                {
                    return true;
                }
            }
            return false;
        }
        //Hiển thị danh sách Khách Hàng
        private void HienthiKH()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = kh.LayDSKH();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "KH00000000")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        lvi.SubItems.Add(dt.Rows[i][5].ToString());
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
        //Hiển thị danh sách Khách Hàng tìm theo tên
        private void DSTimKiemTen()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = kh.TimKiemTen(txtTimKiem.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i][0].ToString() != "KH00000000")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        lvi.SubItems.Add(dt.Rows[i][5].ToString());
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
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            dtNgaySinh.Text = "1/1/1999";
            txtSDTKH.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            txtBenhLy.Text = "";
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
            txtMaKH.ReadOnly = val;
            txtTenKH.ReadOnly = val;
            dtNgaySinh.Enabled = !val;
            txtSDTKH.ReadOnly = val ;
            rbtnNam.Enabled = !val;
            rbtnNu.Enabled = !val;
            txtBenhLy.ReadOnly = val;
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

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            HienthiKH();
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
            dieuchinh(true);
            txtMaKH.ReadOnly = true;
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
                        kh.XoaKH(txtMaKH.Text);
                        lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                        setNull();
                        HienthiKH();
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
                if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtSDTKH.Text) || string.IsNullOrEmpty(txtBenhLy.Text) || (rbtnNam.Checked == false && rbtnNu.Checked == false))
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
                        if (ktTrung(txtMaKH.Text) == false)
                        {
                            kh.ThemKH(txtMaKH.Text, txtTenKH.Text, gioitinh, ngay, txtSDTKH.Text, txtBenhLy.Text);
                            MessageBox.Show("Thêm khách hàng thành công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã khách hàng", "Cảnh Báo");
                        }

                    }
                    else
                    {
                        kh.CapNhatKH(txtMaKH.Text, txtTenKH.Text, gioitinh, ngay, txtSDTKH.Text, txtBenhLy.Text);
                    }
                    HienthiKH();
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
                    txtMaKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
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
                    String.Format("{0:yyyy-MM-dd}", dtNgaySinh.Value);
                    txtSDTKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                    txtBenhLy.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;
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
                    txtMaKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
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
                    String.Format("{0:yyyy-MM-dd}", dtNgaySinh.Value);
                    txtSDTKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                    txtBenhLy.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;
                }
                dieuchinh(true);
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
                    HienthiKH();
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
                HienthiKH();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông Báo");
            }
        }
    }
}
