namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongBao")]
    public partial class ThongBao
    {
        [Key]
        public long idThongBao { get; set; }

        public long idKhachHang { get; set; }

        public long? idXeDaBan { get; set; }

        [StringLength(1000)]
        public string noiDung { get; set; }

        public bool? isRead { get; set; }

        public DateTime? ngayTao { get; set; }
    }
}
