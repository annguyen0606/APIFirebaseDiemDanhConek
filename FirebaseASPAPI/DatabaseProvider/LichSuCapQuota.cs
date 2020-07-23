namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuCapQuota")]
    public partial class LichSuCapQuota
    {
        public int id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? SoQuotaCap { get; set; }

        public DateTime? NgayCap { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(100)]
        public string TenMay { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
