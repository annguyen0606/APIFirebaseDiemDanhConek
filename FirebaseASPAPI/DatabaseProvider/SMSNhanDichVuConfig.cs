namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSNhanDichVuConfig")]
    public partial class SMSNhanDichVuConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongTy { get; set; }

        public byte? GioNhan { get; set; }

        public int? NhanSauSoThang { get; set; }

        public bool? DaNhan { get; set; }

        public bool? HoatDong { get; set; }
    }
}
