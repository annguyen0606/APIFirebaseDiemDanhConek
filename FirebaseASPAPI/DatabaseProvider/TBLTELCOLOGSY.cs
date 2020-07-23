namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLTELCOLOGSYS")]
    public partial class TBLTELCOLOGSY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [StringLength(500)]
        public string FILE_NAME { get; set; }

        public DateTime? TIMERUN { get; set; }
    }
}
