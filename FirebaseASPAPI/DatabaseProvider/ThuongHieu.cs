namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuongHieu")]
    public partial class ThuongHieu
    {
        [Key]
        [Column("ThuongHieu", Order = 0)]
        [StringLength(11)]
        public string ThuongHieu1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongTy { get; set; }

        public bool? Vina { get; set; }

        public virtual CongTy CongTy { get; set; }
    }
}
