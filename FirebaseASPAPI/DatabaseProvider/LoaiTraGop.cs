namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTraGop")]
    public partial class LoaiTraGop
    {
        [Key]
        [Column("LoaiTraGop")]
        public long LoaiTraGop1 { get; set; }

        [StringLength(250)]
        public string TenLoaiTraGop { get; set; }

        public int? ThoiHanTraGopToiDa { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
