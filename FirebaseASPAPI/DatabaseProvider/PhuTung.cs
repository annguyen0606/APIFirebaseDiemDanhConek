namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuTung")]
    public partial class PhuTung
    {
        [Key]
        public long IdPT { get; set; }

        [StringLength(20)]
        public string MaPT { get; set; }

        [StringLength(250)]
        public string TenPT { get; set; }

        [StringLength(20)]
        public string DVT { get; set; }

        public double DonGia { get; set; }

        public int? SoLuong { get; set; }

        public double? TienCongTraChoTho { get; set; }

        public int? IdCongTy { get; set; }

        public int? IdKho { get; set; }

        public int? IdCongtyDoiTac { get; set; }

        [StringLength(20)]
        public string MaPT1 { get; set; }

        [StringLength(20)]
        public string MaThayThe { get; set; }

        [StringLength(250)]
        public string TenTiengAnh { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TgThem { get; set; }

        public int? NguongSoLuong { get; set; }

        [StringLength(50)]
        public string PositionKe { get; set; }

        [StringLength(50)]
        public string PositionTang { get; set; }

        [StringLength(50)]
        public string PositionO { get; set; }
    }
}
