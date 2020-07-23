namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KieuNhapXe")]
    public partial class KieuNhapXe
    {
        [Key]
        public long IdKieuNhapXe { get; set; }

        [StringLength(250)]
        public string TenKieuNhapXe { get; set; }
    }
}
