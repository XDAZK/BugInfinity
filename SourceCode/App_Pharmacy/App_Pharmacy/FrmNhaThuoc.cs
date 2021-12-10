using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thêm thư viện
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace App_Pharmacy
{
    public partial class FrmNhaThuoc : Form
    {
        Database dt;
        DangNhap dangnhap = new DangNhap();
        private IconButton currentBtn;
        private Form currentFormCon;
        string tendangnhap = "", matkhau = "", maNV = "";
        int phanloai, PQ_thuoc, PQ_nhanvien, PQ_kvlt, PQ_khachhang, PQ_ncc, PQ_hoadon, PQ_dondatthuoc;
        public FrmNhaThuoc()
        {
            InitializeComponent();
        }
        public FrmNhaThuoc(string tendangnhap, string matkhau, int phanloai, string maNV, int PQ_thuoc, int PQ_nhanvien, int PQ_kvlt, int PQ_khachhang, int PQ_ncc, int PQ_hoadon, int PQ_dondatthuoc)
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
            try
            {
                if (phanloai == 2)
                {
                    btnHeThong.Enabled = false;
                    btnNhanVien.Enabled = false;
                    //phân quyền chức năng thuốc
                    if (PQ_thuoc == 0)
                        btnThuoc.Enabled = false;
                    else
                        btnThuoc.Enabled = true;
                    //phân quyền chức năng khu vực lưu trữ
                    if (PQ_kvlt == 0)
                        btnKhuVucLuuTru.Enabled = false;
                    else
                        btnKhuVucLuuTru.Enabled = true;
                    //phân quyền chức năng khách hàng
                    if (PQ_khachhang == 0)
                        btnKhachHang.Enabled = false;
                    else
                        btnKhachHang.Enabled = true;
                    //phân quyền chức năng nhà cung cấp
                    if (PQ_ncc == 0)
                        btnNCC.Enabled = false;
                    else
                        btnNCC.Enabled = true;
                    //phân quyền chức năng hóa đơn
                    if (PQ_hoadon == 0)
                        btnHoaDon.Enabled = false;
                    else
                        btnHoaDon.Enabled = true;
                    //phân quyền chức năng đơn đặt thuốc
                    if (PQ_dondatthuoc == 0)
                        btnDonDatThuoc.Enabled = false;
                    else
                        btnDonDatThuoc.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            hidePnMenu();
            timer1.Start();
        }

        private void FrmNhaThuoc_Load(object sender, EventArgs e)
        {
            pnChucNang.Width = 300;
            guna2ShadowForm1.SetShadowForm(this);
        }

        //ẩn menu của các chức năng
        private void hidePnMenu()
        {
            pnMenuHeThong.Visible = false;
            pnMenuDanhMuc.Visible = false;
            pnMenuDoiTac.Visible = false;
            pnMenuGiaoDich.Visible = false;
        }

        //thực hiện chức năng phóng to thu nhỏ thanh panel
        #region code
        private void ibtnThuPhong_Click(object sender, EventArgs e)
        {
            if (ibtnThuPhong.IconChar == IconChar.AngleLeft)
            {
                pnChucNang.Visible = false;
                ibtnThuPhong.IconChar = IconChar.AngleRight;
            }
            else
            {
                pnChucNang.Visible = true;
                ibtnThuPhong.IconChar = IconChar.AngleLeft;
            }
        }
        #endregion

        //code mở form
        #region code
        private void openForm(Form formCon)
        {
            try
            {
                if (currentFormCon != null)
                {
                    currentFormCon.Close();
                }
                currentFormCon = formCon;
                formCon.TopLevel = false;
                formCon.FormBorderStyle = FormBorderStyle.None;
                formCon.Dock = DockStyle.Fill;
                pnFormCon.Controls.Add(formCon);
                pnFormCon.Tag = formCon;
                formCon.BringToFront();
                formCon.Show();
                btnFrmCon.Text = formCon.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        #endregion

        private void Reset()
        {
            timer1.Start();
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._2;
            btnFrmCon.Text = "Trang Chủ";
        }

        //Trang chủ
        private void pbHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFormCon != null)
                {
                    currentFormCon.Close();
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM, yyyy");
        }
        private void showPnMenu(string str, Panel panel)
        {
            if(str == "cha")
            {
                
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
            if(str == "con")
            {
                panel.Visible = true;
            }
        }

        //------------
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showPnMenu("cha", pnMenuHeThong);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._246909697_370142048235641_8217397975466038543_n;
            btnFrmCon.Text = "Hệ Thống";
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuHeThong);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._250487154_1065184514218050_8406670398698731925_n;
            DataTable dt = dangnhap.KiemTraTaiKhoan(tendangnhap, matkhau);
            openForm(new FrmQLTK(tendangnhap, matkhau, phanloai, maNV, PQ_thuoc, PQ_nhanvien, PQ_kvlt, PQ_khachhang, PQ_ncc, PQ_hoadon, PQ_dondatthuoc));
        }

        private void btnDonDatThuoc_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuGiaoDich);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._248751895_4463919896987268_2220862966804608883_n;
            openForm(new FrmDDT(maNV));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuGiaoDich);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._249521400_1552041598479821_5772972398304419219_n;
            openForm(new FrmHoaDon(maNV));
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            showPnMenu("cha", pnMenuGiaoDich);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._247753619_280976217271925_3647071176021241484_n;
            btnFrmCon.Text = "Giao Dịch";
        }


        private void btnNCC_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuDoiTac);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._247713697_228897949308615_5550968023572345860_n;
            openForm(new FrmNhaCungCap());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuDoiTac);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._247708465_216707543822097_4551382351804463666_n;
            openForm(new FrmKhachHang());
        }

        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            showPnMenu("cha", pnMenuDoiTac);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._247681706_907627133209562_4178248516554967252_n;
            btnFrmCon.Text = "Đối Tác";
        }

        private void btnKhuVucLuuTru_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuDanhMuc);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._248483957_231078342287682_5776697212467635048_n;
            openForm(new FrmKVLT());
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuDanhMuc);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._246978745_426302802395202_6006122810398841857_n;
            openForm(new FrmThuoc());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showPnMenu("con", pnMenuDanhMuc);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._247031497_2271236563018358_8695784303535232736_n;
            openForm(new FrmNhanVien());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showPnMenu("cha", pnMenuDanhMuc);
            btnFrmCon.Image = global::App_Pharmacy.Properties.Resources._247584259_414220946907833_5544654349735558018_n;
            btnFrmCon.Text = "Danh Mục";
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            FrmThongTin thongtin = new FrmThongTin(maNV);
            thongtin.ShowDialog();
        }
    }
}
