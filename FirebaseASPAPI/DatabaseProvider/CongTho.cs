namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongTho")]
    public partial class CongTho
    {
        [Key]
        public int IdCongTho { get; set; }

        public int? IdTho { get; set; }

        public int? p5 { get; set; }

        public int? p10 { get; set; }

        public int? p20 { get; set; }

        public int? p30 { get; set; }

        public int? p40 { get; set; }

        public int? p50 { get; set; }

        public int? p60 { get; set; }

        public int? p70 { get; set; }

        public int? p80 { get; set; }

        public int? p90 { get; set; }

        public int? p100 { get; set; }

        public int? p110 { get; set; }

        public int? p120 { get; set; }

        public long? TongGio { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [StringLength(2)]
        public string Thang { get; set; }

        [StringLength(4)]
        public string Nam { get; set; }

        public int? IdCongTy { get; set; }
    }
}
