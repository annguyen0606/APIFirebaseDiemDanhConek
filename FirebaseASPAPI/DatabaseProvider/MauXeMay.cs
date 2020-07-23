namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauXeMay")]
    public partial class MauXeMay
    {
        [Key]
        public int IdMauXe { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(250)]
        public string TenMauXe { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
