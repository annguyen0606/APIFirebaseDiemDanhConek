namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheTichDiemSpa")]
    public partial class TheTichDiemSpa
    {
        [Key]
        public long STT { get; set; }

        [StringLength(20)]
        public string UID { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        public long? TichDiem { get; set; }
    }
}
