namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TienCongTho")]
    public partial class TienCongTho
    {
        [Key]
        public int IdTienCong { get; set; }

        [StringLength(50)]
        public string MaBD { get; set; }

        [StringLength(200)]
        public string NoiDungBD { get; set; }

        public double? TienCong { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }
    }
}
