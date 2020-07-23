namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauXe")]
    public partial class MauXe
    {
        [Key]
        public long IdMaMau { get; set; }

        public long? Idcongty { get; set; }

        [StringLength(50)]
        public string TenMau { get; set; }
    }
}
