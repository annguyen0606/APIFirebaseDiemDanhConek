namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHangBaoDuongTruocKy")]
    public partial class KhachHangBaoDuongTruocKy
    {
        public int id { get; set; }

        public int? IdKhachHang { get; set; }

        public int? IdCongTy { get; set; }

        public int? IdBaoDuong { get; set; }

        public int? SoLan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBaoDuong { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }
    }
}
