namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Software_Update
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Software_Update()
        {
            Software_UpdateHistory = new HashSet<Software_UpdateHistory>();
        }

        [Key]
        public int SoftwareId { get; set; }

        [Required]
        [StringLength(50)]
        public string SWName { get; set; }

        [Required]
        [StringLength(50)]
        public string OldVersion { get; set; }

        [Required]
        [StringLength(50)]
        public string NewVersion { get; set; }

        [Column(TypeName = "ntext")]
        public string ChangeLogs { get; set; }

        [Required]
        [StringLength(500)]
        public string UpdateLocation { get; set; }

        [Required]
        [StringLength(50)]
        public string FileSize { get; set; }

        [StringLength(150)]
        public string md5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Software_UpdateHistory> Software_UpdateHistory { get; set; }
    }
}
