namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblCongviec")]
    public partial class TblCongviec
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string CVNAME { get; set; }
    }
}
