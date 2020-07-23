namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SMSConfig")]
    public partial class SMSConfig
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdCongTy { get; set; }

        [StringLength(459)]
        public string SMS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Type { get; set; }

        public int? Active { get; set; }

        public int? Priority { get; set; }
    }
}
