namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonBanXe")]
    public partial class HoaDonBanXe
    {
        [StringLength(50)]
        public string SoHoaDonBanHang { get; set; }

        [Key]
        public int IdKey { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(50)]
        public string SoChungTu { get; set; }

        public long? IdKhachHang { get; set; }

        public int? IdNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayChungTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTaoHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHoachToan { get; set; }

        public int? IDCuaHang { get; set; }

        public int? IDKieuMua { get; set; }

        public bool? DaTraHoaDon { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienPhuThu { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienDaTra { get; set; }
    }
}
