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
    public partial class FrmThuoc : Form
    {
        Thuoc thuoc = new Thuoc();
        Boolean themmoi;
        int Tong = 0;
        public FrmThuoc()
        {
            InitializeComponent();
        }
        private bool ktTrung(string mathuoc)
        {
            for(int i = 0; i < lsvDanhSachThongTin.Items.Count; i++)
            {
                if (lsvDanhSachThongTin.Items[i].SubItems[0].Text.ToString() == mathuoc)
                {
                    return true;
                }
            }
            return false;
        }

        private void HienthiKhuVuc()
        {
            try
            {
                DataTable dt = thuoc.layDSKV();
                cboKhuVuc.DataSource = dt;
                cboKhuVuc.DisplayMember = "TEN_KHUVUC";
                cboKhuVuc.ValueMember = "MA_KHUVUC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hiển thị danh sách thuốc
        private void HienthiThuoc()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = thuoc.LayDSThuoc();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
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
        //Hiển thị danh sách thuốc tìm theo tên
        private void DSTimKiemTen()
        {
            try
            {
                lsvDanhSachThongTin.Items.Clear();
                DataTable dt = thuoc.TimKiemTen(txtTimKiem.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
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
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtGiaBan.Text = "";
            cboDonViTinh.Text = "";
            cboKhuVuc.Text = "";
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
            txtMaThuoc.ReadOnly = val;
            txtTenThuoc.ReadOnly = val;
            txtGiaBan.ReadOnly = val;
            cboDonViTinh.Enabled = !val;
            cboKhuVuc.Enabled = !val;
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
        private void FrmThuoc_Load(object sender, EventArgs e)
        {
            HienthiThuoc();
            HienthiKhuVuc();
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
            txtMaThuoc.ReadOnly = true;
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
                        thuoc.XoaThuoc(txtMaThuoc.Text);
                        lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                        setNull();
                        HienthiThuoc();
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
                if (string.IsNullOrEmpty(txtMaThuoc.Text) || string.IsNullOrEmpty(txtTenThuoc.Text) || string.IsNullOrEmpty(txtGiaBan.Text) || string.IsNullOrEmpty(cboDonViTinh.Text) || string.IsNullOrEmpty(cboKhuVuc.Text))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông Báo");
                }
                else
                {
                    if (themmoi == true)
                    {
                        if (ktTrung(txtMaThuoc.Text) == false)
                        {
                            thuoc.ThemThuoc(txtMaThuoc.Text, txtTenThuoc.Text, txtGiaBan.Text, cboDonViTinh.Text, cboKhuVuc.SelectedValue.ToString());
                            MessageBox.Show("Thêm thuốc thành công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Trùng mã thuốc", "Cảnh Báo");
                        }
                    }
                    else
                    {
                        thuoc.CapNhatThuoc(txtMaThuoc.Text, txtTenThuoc.Text, txtGiaBan.Text, cboDonViTinh.Text, cboKhuVuc.SelectedValue.ToString());
                        MessageBox.Show("Cật Nhật thuốc thành công", "Thông Báo");
                    }
                    HienthiThuoc();
                    setNull();
                    setButton(true);
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
                    txtMaThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    txtGiaBan.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                    cboDonViTinh.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
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
                    txtMaThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                    txtTenThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                    txtGiaBan.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                    cboDonViTinh.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
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
                    HienthiThuoc();
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
            if(txtTimKiem.Text == "")
            {
                HienthiThuoc();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông Báo");
            }
        }

    }
}
