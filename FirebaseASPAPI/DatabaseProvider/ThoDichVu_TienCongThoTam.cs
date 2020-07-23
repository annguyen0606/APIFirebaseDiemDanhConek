namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThoDichVu_TienCongThoTam
    {
        public int? IdTho { get; set; }

        public int? IdTienCong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySuaChua { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        public int? IdBaoDuong { get; set; }

        [StringLength(250)]
        public string NoiDungBD { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienCong { get; set; }

        [StringLength(50)]
        public string MaTho { get; set; }

        [StringLength(250)]
        public string TenTho { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienKhachTra { get; set; }

        public long Id { get; set; }

        [StringLength(20)]
        public string PhanTramTrietKhau { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienTrietKhau { get; set; }
    }
}
