namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiHoaDOn")]
    public partial class LoaiHoaDOn
    {
        [Key]
        public long IDLoaiHoaDon { get; set; }

        [StringLength(250)]
        public string TenLoaiHoaDon { get; set; }
    }
}
