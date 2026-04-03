using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using Quan_Ly_Lich_Lam_Viec.Reports;
using System.Diagnostics;
using BC = BCrypt.Net.BCrypt;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmMain : Form
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        string hoVaTenNhanVien = "";
        string tenDangNhap = "";

        frmDangNhap dangNhap = null;
        frmDiaDiem diaDiem = null;
        frmDoiMatKhau doiMatKhau = null;
        frmLichLamViec lichLamViec = null;
        frmLoaiCongViec loaiCongViec = null;
        frmNhanVien nhanVien = null;
        frmPhanCong phanCong = null;
        frmTaiKhoan taiKhoan = null;
        frmTienDoCongViec tienDoCongViec = null;
        frmThongKeTienDoCongViec thongKeTienDoCongViec = null;
        frmThongKeLichLamViec thongKeLichLamViec = null;
        frmThongKeChiTietCongViec thongKeChiTietCongViec = null;
        frmThongKeLHieuSuatLamViec thongKeHieuSuatLamViec = null;

        public frmMain()
        {
            InitializeComponent();
        }

        public void ChuaDangNhap()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuNhanVien.Enabled = false;
            mnuLichLamViec.Enabled = false;
            mnuDiaDiem.Enabled = false;
            mnuTaiKhoan.Enabled = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void DangNhap()
        {
        LamLai:

            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDN = dangNhap.TenDangNhap;
                string matKhau = dangNhap.MatKhau;

                if (tenDN == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto LamLai;
                }
                else if (matKhau == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto LamLai;
                }
                else
                {
                    var taiKhoan = context.Tai_Khoan
                        .Include(tk => tk.Nhan_Vien)
                        .FirstOrDefault(tk => tk.Username == tenDN);




                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, taiKhoan.Password))
                        {
                            Program.CurrentUser = taiKhoan;
                            tenDangNhap = taiKhoan.Username;
                            hoVaTenNhanVien = taiKhoan.Nhan_Vien.HoTen;
                            if (taiKhoan.MaQuyen == 1)
                                QuyenQuanLy();
                            else if (taiKhoan.MaQuyen == 0)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void QuyenQuanLy()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuNhanVien.Enabled = true;
            mnuTaiKhoan.Enabled = true;
            mnuLichLamViec.Enabled = true;
            mnuDiaDiem.Enabled = true;

            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;

            mnuNhanVien.Enabled = false;
            mnuTaiKhoan.Enabled = false;

            mnuLichLamViec.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void mnuDiaDiem_Click(object sender, EventArgs e)
        {
            if (diaDiem == null || diaDiem.IsDisposed)
            {
                diaDiem = new frmDiaDiem();
                diaDiem.MdiParent = this;
                diaDiem.Show();
            }
            else
                diaDiem.Activate();
        }

        private void mnuLichLamViec_Click(object sender, EventArgs e)
        {
            if (lichLamViec == null || lichLamViec.IsDisposed)
            {
                lichLamViec = new frmLichLamViec();
                lichLamViec.MdiParent = this;
                lichLamViec.Show();
            }
            else lichLamViec.Activate();
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            if (phanCong == null || phanCong.IsDisposed)
            {
                phanCong = new frmPhanCong();
                phanCong.MdiParent = this;
                phanCong.Show();
            }
            else phanCong.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else nhanVien.Activate();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoan == null || taiKhoan.IsDisposed)
            {
                taiKhoan = new frmTaiKhoan();
                taiKhoan.MdiParent = this;
                taiKhoan.Show();
            }
            else taiKhoan.Activate();
        }

        private void lblLienKet_Click_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuTienDoCongViec_Click(object sender, EventArgs e)
        {
            if (tienDoCongViec == null || tienDoCongViec.IsDisposed)
            {
                tienDoCongViec = new frmTienDoCongViec();
                tienDoCongViec.MdiParent = this;
                tienDoCongViec.Show();
            }
            else tienDoCongViec.Activate();
        }

        private void mnuThongKeTienDoCongViec_Click(object sender, EventArgs e)
        {
            if (thongKeTienDoCongViec == null || thongKeTienDoCongViec.IsDisposed)
            {
                thongKeTienDoCongViec = new frmThongKeTienDoCongViec();
                thongKeTienDoCongViec.MdiParent = this;
                thongKeTienDoCongViec.Show();
            }
            else thongKeTienDoCongViec.Activate();
        }

        private void mnuThongKeLichLamViec_Click(object sender, EventArgs e)
        {
            if (thongKeLichLamViec == null || thongKeLichLamViec.IsDisposed)
            {
                thongKeLichLamViec = new frmThongKeLichLamViec();
                thongKeLichLamViec.MdiParent = this;
                thongKeLichLamViec.Show();
            }
            else thongKeLichLamViec.Activate();
        }

        private void mnuThongKeChiTietCongViec_Click(object sender, EventArgs e)
        {
            if (thongKeChiTietCongViec == null || thongKeChiTietCongViec.IsDisposed)
            {
                thongKeChiTietCongViec = new frmThongKeChiTietCongViec();
                thongKeChiTietCongViec.MdiParent = this;
                thongKeChiTietCongViec.Show();
            }
            else thongKeChiTietCongViec.Activate();
        }

        private void mnuThongKeHieuSuatLamViec_Click(object sender, EventArgs e)
        {
            if (thongKeHieuSuatLamViec == null || thongKeHieuSuatLamViec.IsDisposed)
            {
                thongKeHieuSuatLamViec = new frmThongKeLHieuSuatLamViec();
                thongKeHieuSuatLamViec.MdiParent = this;
                thongKeHieuSuatLamViec.Show();
            }
            else thongKeHieuSuatLamViec.Activate();
        }
    }
}
