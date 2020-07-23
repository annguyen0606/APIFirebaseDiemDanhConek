namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangXeMay")]
    public partial class HangXeMay
    {
        [Key]
        public long IdHangXe { get; set; }

        public long? Idcongty { get; set; }

        [StringLength(50)]
        public string TenHangXe { get; set; }
    }
}
