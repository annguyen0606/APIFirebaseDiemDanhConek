namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiNhanhNganHang")]
    public partial class ChiNhanhNganHang
    {
        [Key]
        public long IdChiNhanhNganHang { get; set; }

        [StringLength(50)]
        public string TenChiNhanh { get; set; }

        public long? IdNganHang { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }
    }
}
