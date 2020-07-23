namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioViec")]
    public partial class GioViec
    {
        [Key]
        public int IdGioViec { get; set; }

        [StringLength(100)]
        public string PhuLuc { get; set; }

        public int? SoPhut { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(10)]
        public string MaGioViec { get; set; }
    }
}
