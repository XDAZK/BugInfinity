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
    public partial class FrmNhaCungCap : Form
    {
        NhaCungCap ncc = new NhaCungCap();
        Boolean themmoi;
        int Tong = 0;
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }
        private bool ktTrung(string mancc)
        {
            for (int i = 0; i < lsvDanhSachThongTin.Items.Count; i++)
            {
                if (lsvDanhSachThongTin.Items[i].SubItems[0].Text.ToString() == mancc)
                {
                    return true;
                }
            }
            return false;
        }
        //Hiển thị danh sách nhà cung cấp
        private void HienthiNCC()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = ncc.LayDSNCC();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i][0].ToString() != "NCC0000000")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
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
        //Hiển thị danh sách nhà cung cấp tìm theo tên
        private void DSTimKiemTen()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = ncc.TimKiemTen(txtTimKiem.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "NCC0000000")
                    {
                        ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
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
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT_NCC.Text = "";
            txtDiaChi.Text = "";
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
            txtMaNCC.ReadOnly = val;
            txtTenNCC.ReadOnly = val;
            txtSDT_NCC.ReadOnly = val;
            txtDiaChi.ReadOnly = val;
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

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienthiNCC();
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
            txtMaNCC.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        ncc.XoaNCC(txtMaNCC.Text);
                        lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                        setNull();
                        HienthiNCC();
                    }
                }
                else
                    MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtSDT_NCC.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    if (themmoi == true)
                    {
                        if (ktTrung(txtMaNCC.Text) == false)
                        {
                            ncc.ThemNCC(txtMaNCC.Text, txtTenNCC.Text, txtSDT_NCC.Text, txtDiaChi.Text);
                            MessageBox.Show("Thêm nhà cung cấp thành Công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã nhà cung cấp", "Cảnh Báo");

                        }
                    }
                    else
                    {
                        ncc.CapNhatNCC(txtMaNCC.Text, txtTenNCC.Text, txtSDT_NCC.Text, txtDiaChi.Text);
                    }
                    HienthiNCC();
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

        private void lsvDanhSachThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    txtMaNCC.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenNCC.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    txtSDT_NCC.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                    txtDiaChi.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
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
                    txtMaNCC.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenNCC.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    txtSDT_NCC.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                    txtDiaChi.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                }
                dieuchinh(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    HienthiNCC();
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
                HienthiNCC();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        private void txtSDT_NCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông Báo");
            }
        }
    }
}
