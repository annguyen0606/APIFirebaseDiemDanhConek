namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomKhachHang")]
    public partial class NhomKhachHang
    {
        [Key]
        public long MaNhomKH { get; set; }

        [StringLength(250)]
        public string TenNhomKH { get; set; }

        public long? IdCongty { get; set; }
    }
}
