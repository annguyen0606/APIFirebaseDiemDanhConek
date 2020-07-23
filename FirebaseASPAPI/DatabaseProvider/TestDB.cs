namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestDB")]
    public partial class TestDB
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }
    }
}
