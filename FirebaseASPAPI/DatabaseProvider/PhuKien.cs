namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuKien")]
    public partial class PhuKien
    {
        [Key]
        public long IdPhuKien { get; set; }

        [StringLength(200)]
        public string TenPhuKien { get; set; }

        [StringLength(150)]
        public string DVT { get; set; }

        public int? IdCongTy { get; set; }
    }
}
