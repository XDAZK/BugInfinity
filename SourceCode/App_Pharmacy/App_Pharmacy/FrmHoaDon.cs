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
    public partial class FrmHoaDon : Form
    {
        HoaDon hd = new HoaDon();
        string maNV = "";
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        public FrmHoaDon(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        #region set
        void setNull()
        {
            txtMaHD.Text = "";
            dtNgayLap.Text = "1/1/1999";
            txtNhanVien.Text = "";
            txtTimKiemKH.Text = "";
            cboKhachHang.Text = "";
        }
        void setButton(bool val)
        {
            btnTaoHD.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void setKhoa(bool val)
        {
            txtMaHD.ReadOnly = val;
            dtNgayLap.Enabled = !val;
            txtNhanVien.ReadOnly = val;
            txtTimKiemKH.ReadOnly = val;
            cboKhachHang.Enabled = !val;
        }
        void Khoa()
        {
            txtMaHD.ReadOnly = true;
            dtNgayLap.Enabled = false;
            txtNhanVien.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
        }
        #endregion
        private void HienthiHoaDon()
        {
            try
            {
                lsvHoaDon.Items.Clear();
                DataTable dt = hd.LayDSHoaDon();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "2021000" && dt.Rows[i][4].ToString() != "0")
                    {
                        ListViewItem lvi = lsvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienthiCTHoaDon(int mahd)
        {
            try
            {
                lsvCTHD.Items.Clear();
                DataTable dt = hd.LayDSCTHoaDon(mahd);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvCTHD.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void HienthiKhachHang()
        {
            DataTable dt = hd.layDSKH();
            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "TEN_KHACHHANG";
            cboKhachHang.ValueMember = "MA_KHACHHANG";
        }
        void HienthiThuoc()
        {
            DataTable dt = hd.layDSThuoc();
            cboThuoc.DataSource = dt;
            cboThuoc.DisplayMember = "TEN_THUOC";
            cboThuoc.ValueMember = "MA_THUOC";
        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            HienthiHoaDon();
            HienthiKhachHang();
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                setNull();
                setButton(false);
                setKhoa(false);
                Khoa();
                gbCTHD.Enabled = true;
                DataTable dt1 = hd.layMaHD();
                DataTable dt2 = hd.layTenNV(maNV);
                int maHD = int.Parse(dt1.Rows[0][0].ToString()) + 1;
                txtMaHD.Text = maHD.ToString();
                dtNgayLap.Value = DateTime.Now;
                txtNhanVien.Text = dt2.Rows[0][0].ToString();
                HienthiKhachHang();
                HienthiThuoc();
                string ngaylap = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dtNgayLap.Value);
                hd.ThemHoaDon(maHD, maNV, ngaylap, 0);
                lsvHoaDon.Enabled = false;
                btnIn.Enabled = false;
                lsvCTHD.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemKH.Text == "")
                {
                    cboKhachHang.Text = "";
                }
                else
                {
                    DataTable dt = hd.TimKiemTenKH(txtTimKiemKH.Text);
                    if (dt.Rows[0][1].ToString() != null)
                    {
                        cboKhachHang.Text = dt.Rows[0][1].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào với ký tự vừa nhập", "Thông Báo");
            }
        }

        private void txtTimKiemKH_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text == "")
            {
                cboKhachHang.Text = "None";
            }
        }

        private void txtTimKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemThuoc.Text == "")
                {
                    cboThuoc.Text = "";
                }
                else
                {
                    DataTable dt = hd.TimKiemTenThuoc(txtTimKiemThuoc.Text);
                    if (dt.Rows[0][1].ToString() != null)
                    {
                        cboThuoc.Text = dt.Rows[0][1].ToString();
                    }
                    else
                    {
                        cboThuoc.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy thuốc nào với ký tự vừa nhập", "Thông Báo");
            }
        }

        private void txtTimKiemThuoc_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemThuoc.Text == "")
            {
                cboThuoc.Text = "Thevapop";
            }
        }

        private void cboThuoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = hd.layGia(cboThuoc.Text);
                string gia = dt.Rows[0][2].ToString();
                txtGiaBan.Text = gia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hóa đơn đã được tạo\nHãy thêm thuốc vào hóa đơn", "Thông Báo");
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                string soluong = txtSoLuong.Text;
                if (string.IsNullOrEmpty(soluong))
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Cảnh Báo");
                }
                else
                {
                    int thanhtien = int.Parse(txtSoLuong.Text) * int.Parse(txtGiaBan.Text);
                    int mahd = int.Parse(txtMaHD.Text);
                    int soLuong = int.Parse(txtSoLuong.Text);
                    hd.ThemCT_HoaDon(mahd, cboThuoc.SelectedValue.ToString(), soLuong, thanhtien);
                    HienthiCTHoaDon(mahd);
                    txtSoLuong.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvHoaDon.SelectedIndices.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int maHD = int.Parse(txtMaHD.Text);
                        hd.XoaCTHoaDon(maHD);
                        hd.XoaHoaDon(maHD);
                        lsvHoaDon.Items.RemoveAt(lsvHoaDon.SelectedIndices[0]);
                        HienthiHoaDon();
                        lsvCTHD.Items.Clear();
                    }
                }
                else
                    MessageBox.Show("Bạn phải chọn mẩu tin cần xóa", "Thông Báo");
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
                if (lsvCTHD.Items.Count > 0)
                {
                    int maHD = int.Parse(txtMaHD.Text);
                    DataTable dt = hd.TongTien(maHD);
                    int tongtien = int.Parse(dt.Rows[0][0].ToString());
                    hd.CapNhatHoaDon(maHD, cboKhachHang.SelectedValue.ToString(), tongtien);
                    HienthiHoaDon();
                    setNull();
                    setButton(true);
                    setKhoa(true);
                    Khoa();
                    gbCTHD.Enabled = false;
                    lsvCTHD.Items.Clear();
                    lsvHoaDon.Enabled = true;
                }
                else
                    MessageBox.Show("Bạn chưa thêm thuốc vào hóa đơn", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int maHD = int.Parse(txtMaHD.Text);
                    hd.XoaCTHoaDon(maHD);
                    hd.XoaHoaDon(maHD);
                    HienthiHoaDon();
                    setNull();
                    setButton(true);
                    setKhoa(true);
                    Khoa();
                    gbCTHD.Enabled = false;
                    lsvCTHD.Items.Clear();
                    lsvHoaDon.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvCTHD.SelectedIndices.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int maHD = int.Parse(txtMaHD.Text);
                        hd.XoaThuoc(cboThuoc.SelectedValue.ToString());
                        lsvCTHD.Items.RemoveAt(lsvCTHD.SelectedIndices[0]);
                        HienthiCTHoaDon(maHD);
                        btnThemThuoc.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Bạn phải chọn mẩu tin cần xóa", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvHoaDon.SelectedIndices.Count > 0)
                {
                    txtMaHD.Text = lsvHoaDon.SelectedItems[0].SubItems[0].Text;
                    cboKhachHang.Text = lsvHoaDon.SelectedItems[0].SubItems[1].Text;
                    txtNhanVien.Text = lsvHoaDon.SelectedItems[0].SubItems[2].Text;
                    dtNgayLap.Value = DateTime.Parse(lsvHoaDon.SelectedItems[0].SubItems[3].Text);
                    int maHD = int.Parse(txtMaHD.Text);
                    HienthiCTHoaDon(maHD);
                    btnIn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông Báo");
            }
        }

        private void lsvCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvCTHD.SelectedIndices.Count > 0)
                {
                    cboThuoc.Text = lsvCTHD.SelectedItems[0].SubItems[0].Text;
                    txtSoLuong.Text = lsvCTHD.SelectedItems[0].SubItems[1].Text;
                    txtGiaBan.Text = lsvCTHD.SelectedItems[0].SubItems[2].Text;
                }
                btnThemThuoc.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int thanhtien = int.Parse(txtSoLuong.Text) * int.Parse(txtGiaBan.Text);
                int maHD = int.Parse(txtMaHD.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                hd.CapNhatThuoc(cboThuoc.SelectedValue.ToString(), soluong, thanhtien);
                HienthiCTHoaDon(maHD);
                btnThemThuoc.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bạn có muốn in hóa đơn này?", "Thông Báo", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                new FrmReportHD(txtMaHD.Text, txtNhanVien.Text, cboKhachHang.Text, dtNgayLap.Value.ToString()).Show();
            }
            btnIn.Enabled = false;
        }
    }
}
