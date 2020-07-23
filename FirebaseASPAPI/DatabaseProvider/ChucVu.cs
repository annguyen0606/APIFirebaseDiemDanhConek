namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucVu")]
    public partial class ChucVu
    {
        [Key]
        public long IdChucVu { get; set; }

        public long? IdCongty { get; set; }

        [StringLength(50)]
        public string TenChucVu { get; set; }

        [StringLength(150)]
        public string DienGiai { get; set; }

        public virtual CongTy CongTy { get; set; }
    }
}
