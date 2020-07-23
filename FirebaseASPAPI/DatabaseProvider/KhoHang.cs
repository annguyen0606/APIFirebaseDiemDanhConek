namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoHang")]
    public partial class KhoHang
    {
        [Key]
        public long IdKho { get; set; }

        public long? IdCongTy { get; set; }

        public long? IdCuaHang { get; set; }

        [StringLength(50)]
        public string TenKho { get; set; }

        [StringLength(250)]
        public string DienGiai { get; set; }
    }
}
