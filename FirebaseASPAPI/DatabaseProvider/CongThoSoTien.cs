namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongThoSoTien")]
    public partial class CongThoSoTien
    {
        [Key]
        public int IdCongThoTien { get; set; }

        public int? IdTho { get; set; }

        public double? TongTien { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? Thang { get; set; }

        [StringLength(4)]
        public string Nam { get; set; }

        public int? IdCongTy { get; set; }
    }
}
