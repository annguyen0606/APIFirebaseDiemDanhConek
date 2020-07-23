namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Software_UpdateHistory
    {
        [Key]
        public long UpdateHisId { get; set; }

        public int SoftwareId { get; set; }

        public long CompanyId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string OldVersion { get; set; }

        [Required]
        [StringLength(50)]
        public string NewVersion { get; set; }

        public virtual Software_Update Software_Update { get; set; }
    }
}
