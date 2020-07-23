namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonNhapPhuTung")]
    public partial class HoaDonNhapPhuTung
    {
        [StringLength(50)]
        public string SoHoaDon { get; set; }

        [StringLength(50)]
        public string LoHang { get; set; }

        [StringLength(50)]
        public string IDNhanVien { get; set; }

        [StringLength(50)]
        public string IDNhaCungCap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string IdCuaHang { get; set; }

        [StringLength(50)]
        public string IDKieuNhap { get; set; }

        [StringLength(50)]
        public string IDCongTy { get; set; }

        public bool? DaNhanHoaDon { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDaTra { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        [Key]
        public long IDKey { get; set; }
    }
}
