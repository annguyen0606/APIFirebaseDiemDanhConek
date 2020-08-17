using DataProviderNFC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCIO
{
    public class NFCDBIO
    {
        NFCDB nfcDB = new NFCDB();
        public int InsertNopTien(String uid, String lop, String thang)
        {
            ThongTinNguoiThan thongTinNguoiThan = nfcDB.Database.SqlQuery<ThongTinNguoiThan>("Select *from dbo.ThongTinNguoiThan where uid = @UID and malop = @MaLop",
                new SqlParameter("@UID", uid),
                new SqlParameter("@MaLop", lop)).FirstOrDefault();
            return nfcDB.Database.ExecuteSqlCommand("Update dbo.ThongTinNopTien SET trangthai = '1' where mahs = @MaHs and malop = @MaLop and thang like @Thang",
                new SqlParameter("@MaHs",thongTinNguoiThan.mahs),
                new SqlParameter("@MaLop",lop),
                new SqlParameter("Thang","%"+thang+"%"));
        }
    }
}
