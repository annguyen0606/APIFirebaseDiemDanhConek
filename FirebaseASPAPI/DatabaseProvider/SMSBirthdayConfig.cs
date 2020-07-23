namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSBirthdayConfig")]
    public partial class SMSBirthdayConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongTy { get; set; }

        public byte? GioNhan { get; set; }

        public byte? NhanTruocSoNgay { get; set; }

        public bool? DaNhan { get; set; }

        public bool? HoatDong { get; set; }
    }
}
