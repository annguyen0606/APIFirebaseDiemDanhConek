namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoGiaPhuTung")]
    public partial class BaoGiaPhuTung
    {
        [Key]
        public long IdBaoGiaPhuTung { get; set; }

        public long IdBaoGia { get; set; }

        public int? IdPhuTung { get; set; }

        public long? IdKho { get; set; }

        [StringLength(50)]
        public string MaPT { get; set; }

        [StringLength(150)]
        public string TenPT { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public bool? DaThucHien { get; set; }

        public virtual BaoGiaSuaChua BaoGiaSuaChua { get; set; }
    }
}
