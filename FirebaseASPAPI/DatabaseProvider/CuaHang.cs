namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuaHang")]
    public partial class CuaHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuaHang()
        {
            XeCuaHangs = new HashSet<XeCuaHang>();
        }

        [Key]
        public long IdCuaHang { get; set; }

        public long? IdCongTy { get; set; }

        [StringLength(50)]
        public string TenCuaHang { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string TenNguoiDaiDien { get; set; }

        public virtual CongTy CongTy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XeCuaHang> XeCuaHangs { get; set; }
    }
}
