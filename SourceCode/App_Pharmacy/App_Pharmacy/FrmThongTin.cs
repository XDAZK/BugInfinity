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
    public partial class FrmThongTin : Form
    {
        ThongTin tt = new ThongTin();
        string maNV = "";
        public FrmThongTin()
        {
            InitializeComponent();
        }
        public FrmThongTin(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        void setKhoaThongTin(bool val) 
        {
            txtTenNV.ReadOnly = val;
            rbtnNam.Enabled = !val;
            rbtnNu.Enabled = !val;
            dtNgaySinh.Enabled = !val;
            txtSDT.ReadOnly = val;
            txtBangCap.ReadOnly = val;
        }
        void setKhoaTaiKhoan(bool val)
        {       
            txtMatKhau.ReadOnly = val;
            txtMatKhauMoi.ReadOnly = val;
            txtNhapLai.ReadOnly = val;
        }
        private void HienthiThongTinNV()
        {
            try
            {
                DataTable dt = tt.LayThongTinNV(maNV);
                txtMaNV.Text = dt.Rows[0][0].ToString();
                txtTenNV.Text = dt.Rows[0][1].ToString();
                string gioitinh = dt.Rows[0][2].ToString();
                if (gioitinh == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                } 
                dtNgaySinh.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                String.Format("{0:yyyy-MM-dd}", dtNgaySinh.Value);
                txtSDT.Text = dt.Rows[0][4].ToString();
                txtBangCap.Text = dt.Rows[0][5].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HienthiTaiKhoan()
        {
            try
            {
                DataTable dt = tt.LayThongTinTK(maNV);
                txtTaiKhoan.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmThongTin_Load(object sender, EventArgs e)
        {
            DataTable dt = tt.LayThongTinNV(maNV);
            lblTenNV.Text = dt.Rows[0][1].ToString();
            HienthiThongTinNV();
            HienthiTaiKhoan();
            setKhoaThongTin(true);
            setKhoaTaiKhoan(true);
            setButtonTT(true);
            setButtonDMK(true);
            txtMaNV.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
        }
        void setButtonTT(bool val)
        {
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }

        void setButtonDMK(bool val)
        {
            btnDoiMatKhau.Enabled = val;
            btnLuuMK.Enabled = !val;
            btnHuyMK.Enabled = !val;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            setButtonTT(false);
            setKhoaThongTin(false);
            txtMaNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtBangCap.Text) || (rbtnNam.Checked == false && rbtnNu.Checked == false))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    string ngay = String.Format("{0:yyyy-MM-dd}", dtNgaySinh.Value);
                    string gioitinh;
                    if (rbtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nữ";
                    }
                    tt.CapNhatThongTinNV(txtMaNV.Text, txtTenNV.Text, gioitinh, ngay, txtSDT.Text, txtBangCap.Text);
                    setButtonTT(true);
                    setKhoaThongTin(true);
                    MessageBox.Show("Đổi thông tin thành công", "Thông báo");
                    HienthiThongTinNV();
                    DataTable dt = tt.LayThongTinNV(maNV);
                    lblTenNV.Text = dt.Rows[0][1].ToString();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButtonTT(true);
            setKhoaThongTin(true);
            HienthiThongTinNV();
        }
        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tt.LayThongTinTK(maNV);
                if (txtMatKhau.Text == dt.Rows[0][1].ToString())
                {
                    if (txtMatKhauMoi.Text.Trim().Length >= 6)
                    {
                        if (txtMatKhauMoi.Text == txtNhapLai.Text)
                        {
                            tt.DoiMatKhau(maNV, txtMatKhauMoi.Text);
                            setButtonDMK(true);
                            setKhoaTaiKhoan(true);
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                            txtMatKhau.Text = "";
                            txtMatKhauMoi.Text = "";
                            txtNhapLai.Text = "";
                            HienthiTaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Nhập lại mật khẩu không đúng!", "Thông Báo");
                            txtMatKhauMoi.Text = "";
                            txtNhapLai.Text = "";
                            txtMatKhauMoi.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông Báo");
                        txtMatKhauMoi.Text = "";
                        txtNhapLai.Text = "";
                        txtMatKhauMoi.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Thông Báo");
                    txtMatKhau.Text = "";
                    txtMatKhau.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnHuyMK_Click(object sender, EventArgs e)
        {
            setButtonDMK(true);
            setKhoaTaiKhoan(true);
            HienthiTaiKhoan();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            setButtonDMK(false);
            setKhoaTaiKhoan(false);
            txtTaiKhoan.Focus();
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông Báo");
            }
        }
    }
}
