using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeLHieuSuatLamViec : Form
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachHieuSuatLamViecDataTable dtHieuSuat = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachHieuSuatLamViecDataTable();

        public frmThongKeLHieuSuatLamViec()
        {
            InitializeComponent();
        }

        private void frmThongKeLHieuSuatLamViec_Load(object sender, EventArgs e)
        {
            var thongKe = context.Nhan_Vien.Select(nv => new
            {
                nv.HoTen,
                // Đếm tổng tất cả đầu việc từ các phân công của nhân viên này
                TongViec = nv.Chi_Tiet_Phan_Cong.SelectMany(pc => pc.Chi_Tiet_Cong_Viec).Count(),
                // Đếm số việc đã tích chọn TrangThai = true
                ViecXong = nv.Chi_Tiet_Phan_Cong.SelectMany(pc => pc.Chi_Tiet_Cong_Viec).Count(t => t.TrangThai == true)
            }).ToList();

            dtHieuSuat.Clear();

            foreach (var item in thongKe)
            {
                double phanTram = item.TongViec > 0 ? (double)item.ViecXong / item.TongViec * 100 : 0;

                dtHieuSuat.AddDanhSachHieuSuatLamViecRow(
                    item.HoTen,
                    item.TongViec,
                    item.ViecXong,
                    Math.Round(phanTram, 2)
                    );
            }

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachHieuSuatLamViec", (DataTable)dtHieuSuat));
            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeHieuSuatLamViec.rdlc");
            rptPath = Path.GetFullPath(rptPath);
            reportViewer.LocalReport.ReportPath = rptPath;
            reportViewer.RefreshReport();
        }

    }
}
