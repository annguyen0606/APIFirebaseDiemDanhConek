namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiLapPhieu")]
    public partial class NguoiLapPhieu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdBaoDuong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string TenNguoiLapPhieu { get; set; }
    }
}
