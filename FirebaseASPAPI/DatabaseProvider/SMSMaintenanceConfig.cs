namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSMaintenanceConfig")]
    public partial class SMSMaintenanceConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongTy { get; set; }

        public byte? GioNhan { get; set; }

        public byte? NhanTruocSoNgay { get; set; }

        public bool? DaNhan { get; set; }

        public string ThangNhan { get; set; }

        public bool? NhanLai { get; set; }

        public int? SauSoNgay { get; set; }

        public bool? HoatDong { get; set; }
    }
}
