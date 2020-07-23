namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuChi")]
    public partial class PhieuChi
    {
        [Key]
        public long SoPhieuChi { get; set; }

        public long? IdLoaiPhieuChi { get; set; }

        [Column(TypeName = "money")]
        public decimal? SoTienChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHachToan { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(500)]
        public string NguoiNhan { get; set; }

        public long? IdNhaCungCap { get; set; }

        public long? IdNhanVien { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }

        public bool? DaNhanHang { get; set; }

        public long? IdCuaHang { get; set; }

        [StringLength(50)]
        public string SoHoaDon { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
