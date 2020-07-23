namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoPhan")]
    public partial class BoPhan
    {
        [Key]
        public long IdBoPhan { get; set; }

        [StringLength(50)]
        public string TenBoPhan { get; set; }

        public long? IdCongTy { get; set; }

        public virtual CongTy CongTy { get; set; }
    }
}
