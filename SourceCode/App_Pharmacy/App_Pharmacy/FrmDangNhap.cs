using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thư viện liên kết với sql
using System.Data.SqlClient;

namespace App_Pharmacy
{
    public partial class FrmDangNhap : Form
    {
        DangNhap dangnhap = new DangNhap();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            txtTaiKhoan.Text = Properties.Settings.Default.User;
            txtMatKhau.Text = Properties.Settings.Default.Pass;
            if(Properties.Settings.Default.User != "")
            {
                cbLuuTaiKhoan.Checked = true;
            }
        }
        private void error(string er)
        {
            lblError.Text = "     " + er;
            lblError.Visible = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try 
            {
                //Kiểm tra xem tài khoản và mật khẩu đã nhập hay chưa
                #region code
                if (txtTaiKhoan.Text != "") { }
                else
                {
                    error("Tài khoản không được để trống!");
                    txtTaiKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text != "") { }
                else
                {
                    error("Mật khẩu không được để trống!");
                    txtMatKhau.Focus();
                    return;
                }
                #endregion

                //kiểm tra xem tài khoản và mật khẩu có đúng hay không
                #region code
                DataTable dt = dangnhap.KiemTraTaiKhoan(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable dtable = dangnhap.KiemTraTrangThai(txtTaiKhoan.Text.Trim());
                    if(dtable.Rows[0][0].ToString() == "Đã đóng")
                    {
                        error("Tài khoản của bạn đã bị khóa");
                        return;
                    }
                    else
                    {
                        FrmLoading load = new FrmLoading(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
                        load.Show();
                        this.Hide();
                    }  
                }
                else
                {
                    error("Sai thông tin đăng nhập!");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void cbLuuTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text != null && txtMatKhau.Text != null)
                {
                    if (cbLuuTaiKhoan.Checked == true)
                    {
                        string username = txtTaiKhoan.Text;
                        string password = txtMatKhau.Text;
                        Properties.Settings.Default.User = username;
                        Properties.Settings.Default.Pass = password;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Reset();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
