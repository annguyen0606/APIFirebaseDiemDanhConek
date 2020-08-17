namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinLop")]
    public partial class ThongTinLop
    {
        [Key]
        [StringLength(10)]
        public string malop { get; set; }

        [StringLength(10)]
        public string matruong { get; set; }

        [StringLength(20)]
        public string tenlop { get; set; }
    }
}
