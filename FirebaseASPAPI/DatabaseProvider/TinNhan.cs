namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinNhan")]
    public partial class TinNhan
    {
        [Key]
        public long smsid { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(459)]
        public string sms { get; set; }

        public byte? countmes { get; set; }

        [StringLength(11)]
        public string SenderName { get; set; }

        public bool? isUnicode { get; set; }

        public long? IdKhachHang { get; set; }

        [StringLength(30)]
        public string smstype { get; set; }

        public DateTime? timeSchedule { get; set; }

        public long? IdCongTy { get; set; }

        public int? IdSMSTuyBien { get; set; }
    }
}
