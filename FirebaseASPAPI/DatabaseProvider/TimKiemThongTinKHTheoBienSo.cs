using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProvider
{
    [Table("TimKiemThongTinKHTheoBienSo")]
    public partial class TimKiemThongTinKHTheoBienSo
    {
        [Key]
        [StringLength(150)]
        public string TenXe { get; set; }
        [StringLength(150)]
        public string BienSo { get; set; }
        [StringLength(150)]
        public string SoNgay { get; set; }
        [StringLength(150)]
        public string TenKH { get; set; }
        [StringLength(150)]
        public string GioiTinh { get; set; }
        [StringLength(150)]
        public string NgaySinh { get; set; }
        [StringLength(150)]
        public string DienThoai { get; set; }
        [StringLength(150)]
        public string DiaChi { get; set; }
        [StringLength(150)]
        public string NgayMua { get; set; }


    }
}
