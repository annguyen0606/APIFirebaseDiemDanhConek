namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoNhap")]
    public partial class KhoNhap
    {
        [Key]
        public int IdNhapKho { get; set; }

        public int? IdPT { get; set; }

        [StringLength(20)]
        public string MaPT { get; set; }

        [StringLength(250)]
        public string TenPT { get; set; }

        public int? SoLuong { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(50)]
        public string LoaiNhap { get; set; }

        public int? IdKho { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }
    }
}
