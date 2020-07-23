namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoGiaCongThoTam")]
    public partial class BaoGiaCongThoTam
    {
        [Key]
        public long IdBaoGiaCongTho { get; set; }

        public long? IdBaoGia { get; set; }

        public int? IdTienCong { get; set; }

        [StringLength(150)]
        public string NoiDungCV { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienCong { get; set; }

        [StringLength(150)]
        public string GhiChu { get; set; }

        public bool? DaThucHien { get; set; }
    }
}
