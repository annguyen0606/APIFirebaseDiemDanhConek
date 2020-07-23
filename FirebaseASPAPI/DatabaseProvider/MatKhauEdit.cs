namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatKhauEdit")]
    public partial class MatKhauEdit
    {
        public long ID { get; set; }

        public string pass { get; set; }

        [StringLength(50)]
        public string privilege { get; set; }

        public long? IdCongty { get; set; }
    }
}
