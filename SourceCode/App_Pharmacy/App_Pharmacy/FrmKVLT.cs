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
    public partial class FrmKVLT : Form
    {
        KVLT kv = new KVLT();
        Boolean themmoi;
        int Tong = 0;
        public FrmKVLT()
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
        //Hiển thị danh sách khu vực
        private void HienthiDSKV()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = kv.LayDSKVLT();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    Tong += 1;
                }
                lblTong.Text = Tong.ToString();
                Tong = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hiển thị danh sách khu vực tìm theo tên
        private void DSTimKiemTen()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = kv.TimKiemTen(txtTimKiem.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    Tong += 1;
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
            txtMaKV.Text = "";
            txtTenKV.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void setKhoa(bool val)
        {
            txtMaKV.ReadOnly = val;
            txtTenKV.ReadOnly = val;
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

        private void FrmKVLT_Load(object sender, EventArgs e)
        {
            HienthiDSKV();
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
            txtMaKV.ReadOnly = true;
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
                        kv.XoaKVLT(txtMaKV.Text);
                        lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                        setNull();
                        HienthiDSKV();
                    }
                }
                else
                    MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khu vực này đang lưu trữ thuốc, Không thể xóa","Thông Báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtMaKV.Text) || string.IsNullOrEmpty(txtTenKV.Text))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    if (themmoi == true)
                    {
                        kv.ThemKVLT(txtMaKV.Text, txtTenKV.Text);
                        MessageBox.Show("Thêm khu vực thành Công", "Thông Báo");
                    }
                    else
                    {
                        kv.CapNhatNhanVien(txtMaKV.Text, txtTenKV.Text);
                        MessageBox.Show("Sửa khu vực thành Công", "Thông Báo");
                    }
                    HienthiDSKV();
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    HienthiDSKV();
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

        private void lsvDanhSachThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
                {
                    txtMaKV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenKV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
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
                    txtMaKV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenKV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    dieuchinh(true);
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
                HienthiDSKV();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }
    }
}
