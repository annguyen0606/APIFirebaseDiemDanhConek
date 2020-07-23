namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoGiaSuaChua")]
    public partial class BaoGiaSuaChua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaoGiaSuaChua()
        {
            BaoGiaCongThoes = new HashSet<BaoGiaCongTho>();
            BaoGiaPhuTungs = new HashSet<BaoGiaPhuTung>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoGiaCongTho> BaoGiaCongThoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoGiaPhuTung> BaoGiaPhuTungs { get; set; }
    }
}
