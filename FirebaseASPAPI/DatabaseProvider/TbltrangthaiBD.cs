namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TbltrangthaiBD")]
    public partial class TbltrangthaiBD
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string SNAME { get; set; }

        public int? ISACTIVE { get; set; }
    }
}
