using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeChiTietCongViec : Form
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachChiTietCongViecDataTable dtChiTiet = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachChiTietCongViecDataTable();
        public frmThongKeChiTietCongViec()
        {
            InitializeComponent();
        }

        private void frmThongKeChiTietCongViec_Load(object sender, EventArgs e)
        {
            try
            {
                var query = context.Chi_Tiet_Cong_Viecs.Select(c => new
                {
                    HoTen = c.Chi_Tiet_Phan_Cong.Nhan_Vien.HoTen,
                    TieuDeLich = c.Chi_Tiet_Phan_Cong.Lich_Lam_Viec.TieuDe,
                    c.TenDauViec,
                    c.TrangThai
                }).ToList();

                dtChiTiet.Clear();

                foreach (var item in query)
                {
                    dtChiTiet.AddDanhSachChiTietCongViecRow(
                        item.HoTen,
                        item.TieuDeLich,
                        item.TenDauViec,
                        item.TrangThai ? "Đã hoàn thành" : "Chưa hoàn thành" // Chuyển bool sang chữ
                    );
                }
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DanhSachChiTietCongViec", (DataTable)dtChiTiet));
                string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeChiTietCongViec.rdlc");
                rptPath = Path.GetFullPath(rptPath);
                reportViewer.LocalReport.ReportPath = rptPath;
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }
    }
}
