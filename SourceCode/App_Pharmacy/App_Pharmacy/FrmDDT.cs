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
    public partial class FrmDDT : Form
    {
        DDT dd = new DDT();
        string maNV = "";
        public FrmDDT()
        {
            InitializeComponent();
        }

        public FrmDDT(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        #region set
        void setNull()
        {
            txtMaDDT.Text = "";
            dtNgayLap.Text = "1/1/1999";
            txtNhanVien.Text = "";
            txtTimKiemNCC.Text = "";
            cboNCC.Text = "";
        }
        void setButton(bool val)
        {
            btnTaoDD.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void setKhoa(bool val)
        {
            txtMaDDT.ReadOnly = val;
            dtNgayLap.Enabled = !val;
            txtNhanVien.ReadOnly = val;
            txtTimKiemNCC.ReadOnly = val;
            cboNCC.Enabled = !val;
        }
        void Khoa()
        {
            txtMaDDT.ReadOnly = true;
            dtNgayLap.Enabled = false;
            txtNhanVien.ReadOnly = true;
        }
        #endregion
        private void HienthiDonDat()
        {
            try
            {
                lsvDonDat.Items.Clear();
                DataTable dt = dd.LayDSDonDat();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() != "2021000")
                    {
                        ListViewItem lvi = lsvDonDat.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienthiCTDonDat(int madd)
        {
            try
            {
                lsvCTDD.Items.Clear();
                DataTable dt = dd.LayDSCTDonDat(madd);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = lsvCTDD.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void HienthiNCC()
        {
            DataTable dt = dd.layDSNCC();
            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "TEN_NCC";
            cboNCC.ValueMember = "MA_NCC";
        }
        void HienthiThuoc()
        {
            DataTable dt = dd.layDSThuoc();
            cboThuoc.DataSource = dt;
            cboThuoc.DisplayMember = "TEN_THUOC";
            cboThuoc.ValueMember = "MA_THUOC";
        }
        private void FrmDDT_Load(object sender, EventArgs e)
        {
            HienthiDonDat();
            HienthiNCC();
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void btnTaoDD_Click(object sender, EventArgs e)
        {
            try
            {
                setNull();
                setButton(false);
                setKhoa(false);
                Khoa();
                gbCTDD.Enabled = true;
                DataTable dt1 = dd.layMaDD();
                DataTable dt2 = dd.layTenNV(maNV);
                int maDD = int.Parse(dt1.Rows[0][0].ToString()) + 1;
                txtMaDDT.Text = maDD.ToString();
                dtNgayLap.Value = DateTime.Now;
                txtNhanVien.Text = dt2.Rows[0][0].ToString();
                HienthiThuoc();
                HienthiNCC();
                string ngaylap = String.Format("{0:yyyy-MM-dd HH:mm:ss}", dtNgayLap.Value);
                dd.ThemDonDat(maDD, maNV, ngaylap);
                lsvDonDat.Enabled = false;
                btnIn.Enabled = false;
                lsvCTDD.Items.Clear();
                MessageBox.Show("Đơn đặt đã được tạo\nHãy thêm thuốc vào đơn đặt", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiemNCC.Text == "")
                {
                    cboNCC.Text = "";
                }
                else
                {
                    DataTable dt = dd.TimKiemTenNCC(txtTimKiemNCC.Text);
                    if (dt.Rows[0][1].ToString() != null)
                    {
                        cboNCC.Text = dt.Rows[0][1].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp nào với ký tự vừa nhập", "Thông Báo");
            }
        }

        private void txtTimKiemNCC_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemNCC.Text == "")
            {
                cboNCC.Text = "None";
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
                    DataTable dt = dd.TimKiemTenThuoc(txtTimKiemThuoc.Text);
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
                    int maDD = int.Parse(txtMaDDT.Text);
                    int soLuong = int.Parse(txtSoLuong.Text);
                    dd.ThemCT_DonDat(maDD, cboThuoc.SelectedValue.ToString(), soLuong);
                    HienthiCTDonDat(maDD);
                    txtSoLuong.Text = "";
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
                if (lsvCTDD.SelectedIndices.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chăn muốn xóa không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int maDD = int.Parse(txtMaDDT.Text);
                        dd.XoaThuoc(cboThuoc.SelectedValue.ToString());
                        lsvCTDD.Items.RemoveAt(lsvCTDD.SelectedIndices[0]);
                        HienthiCTDonDat(maDD);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvCTDD.Items.Count > 0)
                {
                    int maDD = int.Parse(txtMaDDT.Text);
                    dd.CapNhatDonDat(maDD, cboNCC.SelectedValue.ToString());
                    HienthiDonDat();
                    setNull();
                    setButton(true);
                    setKhoa(true);
                    Khoa();
                    gbCTDD.Enabled = false;
                    lsvCTDD.Items.Clear();
                    lsvDonDat.Enabled = true;
                }
                else
                    MessageBox.Show("Bạn chưa thêm thuốc vào đơn đặt", "Thông Báo");
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
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy đơn đặt? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int maDD = int.Parse(txtMaDDT.Text);
                    dd.XoaCTDonDat(maDD);
                    dd.XoaDonDat(maDD);
                    HienthiDonDat();
                    setNull();
                    setButton(true);
                    setKhoa(true);
                    Khoa();
                    gbCTDD.Enabled = false;
                    lsvCTDD.Items.Clear();
                    lsvDonDat.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDonDat.SelectedIndices.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int maDD = int.Parse(txtMaDDT.Text);
                        dd.XoaCTDonDat(maDD);
                        dd.XoaDonDat(maDD);
                        lsvDonDat.Items.RemoveAt(lsvDonDat.SelectedIndices[0]);
                        HienthiDonDat();
                        lsvCTDD.Items.Clear();
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

        private void lsvDonDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvDonDat.SelectedIndices.Count > 0)
                {
                    txtMaDDT.Text = lsvDonDat.SelectedItems[0].SubItems[0].Text;
                    cboNCC.Text = lsvDonDat.SelectedItems[0].SubItems[2].Text;
                    txtNhanVien.Text = lsvDonDat.SelectedItems[0].SubItems[1].Text;
                    dtNgayLap.Value = DateTime.Parse(lsvDonDat.SelectedItems[0].SubItems[3].Text);
                    int maDD = int.Parse(txtMaDDT.Text);
                    HienthiCTDonDat(maDD);
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

        private void lsvCTDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvCTDD.SelectedIndices.Count > 0)
                {
                    cboThuoc.Text = lsvCTDD.SelectedItems[0].SubItems[0].Text;
                    txtSoLuong.Text = lsvCTDD.SelectedItems[0].SubItems[1].Text;
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
                int maDD = int.Parse(txtMaDDT.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                dd.CapNhatThuoc(cboThuoc.SelectedValue.ToString(), soluong);
                HienthiCTDonDat(maDD);
                btnThemThuoc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bạn có muốn in hóa đơn này?", "Thông Báo", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                new FrmReportDDT(txtMaDDT.Text, txtNhanVien.Text, cboNCC.Text, dtNgayLap.Value.ToString()).Show();
            }
            btnIn.Enabled = false;   
        }
    }
}
