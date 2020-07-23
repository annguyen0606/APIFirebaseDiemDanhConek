namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuotaRemainByDay")]
    public partial class QuotaRemainByDay
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int account_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string login_name { get; set; }

        [StringLength(200)]
        public string sender_name { get; set; }

        public int? quota_qc_remain { get; set; }

        public int? quota_cskh_remain { get; set; }

        public int? quota_cskh_use { get; set; }

        public int? quota_qc_use { get; set; }

        [StringLength(50)]
        public string sms_type { get; set; }

        public DateTime? time { get; set; }

        [StringLength(50)]
        public string responsed_code { get; set; }

        public DateTime? create_date { get; set; }
    }
}
