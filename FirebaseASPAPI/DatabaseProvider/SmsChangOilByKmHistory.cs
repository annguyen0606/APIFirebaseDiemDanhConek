namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsChangOilByKmHistory")]
    public partial class SmsChangOilByKmHistory
    {
        [Key]
        public long HistId { get; set; }

        public long? IdKhachHang { get; set; }

        public int? Kilomet { get; set; }

        public DateTime? TimeSendSms { get; set; }

        public long? IdBaoDuong { get; set; }
    }
}
