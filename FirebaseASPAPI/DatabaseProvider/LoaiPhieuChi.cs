namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiPhieuChi")]
    public partial class LoaiPhieuChi
    {
        [Key]
        public long IdLoaiPhieuChi { get; set; }

        [StringLength(500)]
        public string TenLoaiPhieuChi { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
