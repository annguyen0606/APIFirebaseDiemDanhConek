namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NganHang")]
    public partial class NganHang
    {
        [Key]
        public long IDNganHang { get; set; }

        [StringLength(250)]
        public string TenNganHang { get; set; }
    }
}
