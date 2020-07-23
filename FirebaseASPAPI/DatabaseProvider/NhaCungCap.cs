namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [Key]
        public long IdNhaCungCap { get; set; }

        [StringLength(50)]
        public string TenNhaCungCap { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MaSoThue { get; set; }

        [StringLength(150)]
        public string NguoiDaiDien { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }
    }
}
