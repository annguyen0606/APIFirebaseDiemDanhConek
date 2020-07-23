namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonNhapXe")]
    public partial class HoaDonNhapXe
    {
        [Required]
        [StringLength(50)]
        public string SoHoaDonNhap { get; set; }

        public long? IDNhaCungCap { get; set; }

        public long? IDNhanVienTaoPhieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHoaDon { get; set; }

        public bool? DaNhanHoaDon { get; set; }

        public int IdCongTy { get; set; }

        public long? IdKieuNhapXe { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string SoChungTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayChungTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHachToan { get; set; }

        [StringLength(50)]
        public string LoHang { get; set; }

        public long? IDCuaHang { get; set; }

        [Key]
        public int IDkey { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDaTra { get; set; }
    }
}
