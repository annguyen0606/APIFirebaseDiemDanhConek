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
        public int InsertNopTien(String uid, String lop, String thang, String soTienNop, String maGiaoVien)
        {
            ThongTinNguoiThan thongTinNguoiThan = nfcDB.Database.SqlQuery<ThongTinNguoiThan>("Select *from dbo.ThongTinNguoiThan where uid = @UID and malop = @MaLop",
                new SqlParameter("@UID", uid),
                new SqlParameter("@MaLop", lop)).FirstOrDefault();
            ThongTinNopTien thongTinNopTien = nfcDB.Database.SqlQuery<ThongTinNopTien>("SELECT *FROM dbo.ThongTinNopTien where (mahs = @MaHs and malop = @MaLop and thang like @Thang and trangthai = '0') or (mahs = @MaHs and malop = @MaLop and thang like @Thang and trangthai = '2')",
                new SqlParameter("@MaHs", thongTinNguoiThan.mahs),
                new SqlParameter("@MaLop", lop),
                new SqlParameter("@Thang", "%" + thang + "%")).FirstOrDefault();
            if (thongTinNopTien != null)
            {
                int soDaDong = Int32.Parse(thongTinNopTien.sotienreal.Trim());
                int soTienSeNop = Int32.Parse(soTienNop);
                int soTienPhaiNop = Int32.Parse(thongTinNopTien.sotien.Trim());
                if(soTienSeNop >= soTienPhaiNop - soDaDong)
                {
                    int check = nfcDB.Database.ExecuteSqlCommand("Update dbo.ThongTinNopTien SET trangthai = '1', sotienreal = @SoTienReal, magv = @MaGV where mahs = @MaHs and malop = @MaLop and thang like @Thang",
                        new SqlParameter("@SoTienReal", (soDaDong + soTienSeNop).ToString()),
                        new SqlParameter("@MaHs", thongTinNguoiThan.mahs),
                        new SqlParameter("@MaLop", lop),
                        new SqlParameter("@MaGV",maGiaoVien),
                        new SqlParameter("Thang", "%" + thang + "%"));
                    if(check == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    int check = nfcDB.Database.ExecuteSqlCommand("Update dbo.ThongTinNopTien SET trangthai = '2', sotienreal = @SoTienReal, magv = @MaGV where mahs = @MaHs and malop = @MaLop and thang like @Thang",
                        new SqlParameter("@SoTienReal", (soDaDong + soTienSeNop).ToString()),
                        new SqlParameter("@MaHs", thongTinNguoiThan.mahs),
                        new SqlParameter("@MaLop", lop),
                        new SqlParameter("@MaGV", maGiaoVien),
                        new SqlParameter("Thang", "%" + thang + "%"));
                    if(check == 1)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
