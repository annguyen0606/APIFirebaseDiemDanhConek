namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSTuyBienStore")]
    public partial class SMSTuyBienStore
    {
        [Key]
        public int IdSMSTuyBien { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(100)]
        public string smsType { get; set; }

        [StringLength(459)]
        public string SMS { get; set; }

        public byte? Countmes { get; set; }

        public byte? GioNhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }

        public DateTime? NgayDatLich { get; set; }
    }
}
