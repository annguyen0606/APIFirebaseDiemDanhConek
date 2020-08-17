namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinTruong")]
    public partial class ThongTinTruong
    {
        [Key]
        [StringLength(10)]
        public string matruong { get; set; }

        [StringLength(50)]
        public string tentruong { get; set; }
    }
}
