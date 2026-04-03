using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeTienDoCongViec : Form
    {
        public frmThongKeTienDoCongViec()
        {
            InitializeComponent();
        }

        private void frmThongKeTienDoCongViec_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Quan_Li_Lich_Lam_DbContext())
                {
                    var data = db.Tien_Do_Cong_Viec
                         .Include(t => t.Lich_Lam_Viec)
                         .Select(t => new
                         {
                             TenLich = t.Lich_Lam_Viec.TieuDe,
                             PhanTram = t.PhanTramHoanThanh,
                             GhiChu = t.GhiChu,
                             Ngay = t.NgayCapNhat.ToString("dd/MM/yyyy HH:mm")
                         }).ToList();

                    var dt = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachTienDoCongViecDataTable();
                    foreach (var item in data)
                    {
                        dt.AddDanhSachTienDoCongViecRow(item.TenLich, item.PhanTram, item.GhiChu, item.Ngay);
                    }
                    reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachTienDoCongViec", (DataTable)dt));
                    //string rptPath = Path.Combine(Application.StartupPath, "Reports", "rptThongKeTienDoCongViec.rdlc");
                    string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeTienDoCongViec.rdlc");
                    rptPath = Path.GetFullPath(rptPath);
                    reportViewer.LocalReport.ReportPath = rptPath;
                    reportViewer.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
