namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongTy")]
    public partial class CongTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongTy()
        {
            BoPhans = new HashSet<BoPhan>();
            ChucVus = new HashSet<ChucVu>();
            CongtyDoitacs = new HashSet<CongtyDoitac>();
            CuaHangs = new HashSet<CuaHang>();
            ThuongHieux = new HashSet<ThuongHieu>();
        }

        [Key]
        public long IdCongTy { get; set; }

        [StringLength(50)]
        public string TenCongTy { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string DienThoaiBan { get; set; }

        [Required]
        [StringLength(150)]
        public string SecretKey { get; set; }

        public int? QuotaProvider { get; set; }

        public int? QuotaRemain { get; set; }

        public int? SoTienNhanTinBaoDuong { get; set; }

        [StringLength(50)]
        public string GoiPhanMem { get; set; }

        [StringLength(50)]
        public string TenLapPhieu { get; set; }

        [StringLength(50)]
        public string TenQuanLy { get; set; }

        public bool? IsYamaha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoPhan> BoPhans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChucVu> ChucVus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongtyDoitac> CongtyDoitacs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuaHang> CuaHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuongHieu> ThuongHieux { get; set; }
    }
}
