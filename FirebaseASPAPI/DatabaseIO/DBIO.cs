using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseIO
{
    public class DBIO
    {
        MSSQLAutoCare mSSQLAutoCare = new MSSQLAutoCare();
        public TimKiemThongTinKHTheoBienSo GetThongTinKHTheoBienSo(string bienSo, int idCongTy)
        {
            return mSSQLAutoCare.Database.SqlQuery<TimKiemThongTinKHTheoBienSo>(
                "select top 1 lsbdx.TenXe, lsbdx.BienSo, lsbdx.SoMay, kh.TenKH, kh.GioiTinh, kh.NgaySinh, kh.DienThoai, kh.Diachi, kh.NgayMua from LichSuBaoDuongXe lsbdx inner join KhachHang kh on lsbdx.IdKhachHang=kh.IdKhachHang WHERE lsbdx.IdCongTy = @idCongTy  and lsbdx.BienSo like @bienSo",
                new SqlParameter("@idCongTy", idCongTy),
                new SqlParameter("@bienSo", "%"+bienSo+"%")).FirstOrDefault();
        }
    }
}
