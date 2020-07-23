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
        public KhachHang GetThongTinKHTheoBienSo(string bienSo, int idCongTy)
        {
            LichSuBaoDuongXe lichSuBaoDuongXe = mSSQLAutoCare.Database.SqlQuery<LichSuBaoDuongXe>("select top 1 * from LichSuBaoDuongXe WHERE IdCongTy = @idCongTy  and BienSo like @bienSo",
                new SqlParameter("@idCongTy", idCongTy),
                new SqlParameter("@bienSo", "%" + bienSo + "%")).FirstOrDefault();
            if(lichSuBaoDuongXe == null)
            {
                KhachHang khach = new KhachHang();
                khach.TenKH = "Nguoi La oi";
                return khach;
            }
            else
            {
                return mSSQLAutoCare.Database.SqlQuery<KhachHang>(
                        "select top 1 * from KhachHang WHERE IdKhachHang = @idKhachHang",
                        new SqlParameter("@idKhachHang", lichSuBaoDuongXe.IdKhachHang)).FirstOrDefault();
            }
        }
    }
}
