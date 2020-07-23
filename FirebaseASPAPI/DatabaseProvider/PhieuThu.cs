namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThu")]
    public partial class PhieuThu
    {
        [Key]
        public long IdPhieuThu { get; set; }

        public long? IdLoaiPhieuThu { get; set; }

        [Column(TypeName = "money")]
        public decimal? SoTienThu { get; set; }

        [StringLength(50)]
        public string SoHoaDon { get; set; }

        [StringLength(50)]
        public string SoHopDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHachToan { get; set; }

        public int? IdCongTy { get; set; }

        public long? IdNhanVien { get; set; }

        public long? IdCuaHang { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IdKey { get; set; }

        public bool? DangKiem { get; set; }

        public bool? SoBaoHanh { get; set; }
    }
}
