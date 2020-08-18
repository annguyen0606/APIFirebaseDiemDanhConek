namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinNopTien")]
    public partial class ThongTinNopTien
    {
        [Key]
        public long stt { get; set; }

        [StringLength(10)]
        public string mahs { get; set; }

        [StringLength(10)]
        public string magv { get; set; }

        [Column(TypeName = "date")]
        public DateTime? thang { get; set; }

        [StringLength(10)]
        public string sotien { get; set; }

        [StringLength(10)]
        public string trangthai { get; set; }

        [StringLength(10)]
        public string malop { get; set; }

        [StringLength(10)]
        public string sotienreal { get; set; }
    }
}
