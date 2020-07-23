namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSKiemTraBaoDuongConfig")]
    public partial class SMSKiemTraBaoDuongConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongTy { get; set; }

        public byte? GioNhan { get; set; }

        public byte? NhanSauKhiBaoDuong { get; set; }
    }
}
