namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoGiaSuaChuaTam")]
    public partial class BaoGiaSuaChuaTam
    {
        [Key]
        public long IdBaoGia { get; set; }

        public long? IdKhachHang { get; set; }

        public long? IdBaoDuong { get; set; }

        public DateTime? NgayBaoGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTienVatTu { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTienCong { get; set; }

        [Column(TypeName = "money")]
        public decimal? VAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongSauVAT { get; set; }

        [StringLength(50)]
        public string CoVanDV { get; set; }

        [StringLength(50)]
        public string TruongPhongDV { get; set; }
    }
}
