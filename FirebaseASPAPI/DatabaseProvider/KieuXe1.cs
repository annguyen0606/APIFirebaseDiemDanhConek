namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KieuXe1
    {
        [Key]
        public int IDKieuXe { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(250)]
        public string TenKieuXe { get; set; }
    }
}
