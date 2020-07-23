namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiXe")]
    public partial class LoaiXe
    {
        [Key]
        public int IdLoaiXe { get; set; }

        [StringLength(250)]
        public string TenLoaiXe { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }
    }
}
