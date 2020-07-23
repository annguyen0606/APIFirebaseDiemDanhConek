namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongtyDoitac")]
    public partial class CongtyDoitac
    {
        [Key]
        public long IdCongtyDoitac { get; set; }

        [StringLength(50)]
        public string TenContyDoitac { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public long? IdCongty { get; set; }

        [StringLength(20)]
        public string Masothue { get; set; }

        [StringLength(50)]
        public string TaiKhoanNganHang { get; set; }

        [StringLength(50)]
        public string TenNguoiDaiDien { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public virtual CongTy CongTy { get; set; }
    }
}
