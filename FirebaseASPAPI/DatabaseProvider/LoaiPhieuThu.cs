namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiPhieuThu")]
    public partial class LoaiPhieuThu
    {
        [Key]
        public long IdLoaiPhieuThu { get; set; }

        [StringLength(250)]
        public string TenLoaiPhieuThu { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
