namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDongTraGop")]
    public partial class HopDongTraGop
    {
        [StringLength(50)]
        public string SoHopDongTraGop { get; set; }

        public int? IdCongTy { get; set; }

        public int? ThoiGianTraGop { get; set; }

        public decimal? LaiSuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHenTra { get; set; }

        public long? IDNganHang { get; set; }

        public long? IDChiNhanh { get; set; }

        [StringLength(250)]
        public string NguoiDaiDien { get; set; }

        [StringLength(50)]
        public string SoHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLapHopDong { get; set; }

        [Column(TypeName = "money")]
        public decimal? SoTienTraGop { get; set; }

        [Column(TypeName = "money")]
        public decimal? SoTienThu { get; set; }

        public long? IdCuaHang { get; set; }

        public long? IdNhanVien { get; set; }

        [Key]
        public int IdKey { get; set; }
    }
}
