using Microsoft.EntityFrameworkCore;

namespace Quan_Ly_Lich_Lam_Viec.Data
{
    static class DataHelper
    {
        public static IQueryable<T> FilterByRole<T>(IQueryable<T> query, string memberName = "MaNhanVien") where T : class
        {
            //Nếu chưa đăng nhập hoặc là Quản lý (MaQuyen == 1) -> Trả về toàn bộ
            if (Program.CurrentUser == null || Program.CurrentUser.MaQuyen == 1)
            {
                return query;
            }

            //Nếu là Nhân viên (MaQuyen == 0) -> Lọc theo mã nhân viên đang đăng nhập
            int currentUserId = Program.CurrentUser.MaNhanVien;

            // Dùng LINQ động để lọc theo thuộc tính MaNhanVien
            return query.Where(item => EF.Property<int>(item, memberName) == currentUserId);
        }
    }
}
