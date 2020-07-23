namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SMSMoiThayDauMay_Config
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongty { get; set; }

        public byte? GioNhan { get; set; }

        public int? NhanSauSoNgay { get; set; }

        public bool? active { get; set; }
    }
}
