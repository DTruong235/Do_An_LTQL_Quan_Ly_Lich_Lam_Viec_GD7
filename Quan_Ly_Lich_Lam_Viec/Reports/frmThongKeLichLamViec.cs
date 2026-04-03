using Microsoft.Reporting.WinForms;
using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Reports
{
    public partial class frmThongKeLichLamViec : Form
    {
        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        Quan_Li_Lich_Lam_Viec_DataSet.DanhSachLichLamViecDataTable dtLich = new Quan_Li_Lich_Lam_Viec_DataSet.DanhSachLichLamViecDataTable();
        public frmThongKeLichLamViec()
        {
            InitializeComponent();
        }

        private void frmThongKeLichLamViec_Load(object sender, EventArgs e)
        {
            try
            {
                var query = context.Lich_Lam_Viec.Select(r => new
                {
                    r.TieuDe,
                    r.ThoiGianBatDau,
                    r.ThoiGianKetThuc,
                    TenLoai = r.Loai_Cong_Viec.TenLoai,
                    TenDiaDiem = r.Dia_Diem.TenDiaDiem,
                    r.SoLuongDuKien
                }).ToList();

                dtLich.Clear();

                foreach (var item in query)
                {
                    dtLich.AddDanhSachLichLamViecRow(
                        item.TieuDe,
                        item.ThoiGianBatDau,
                        item.ThoiGianKetThuc,
                        item.TenLoai,
                        item.TenDiaDiem,
                        item.SoLuongDuKien
                    );
                }

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DanhSachLichLamViec", (DataTable)dtLich));
                string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", "rptThongKeLichLamViec.rdlc");
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
