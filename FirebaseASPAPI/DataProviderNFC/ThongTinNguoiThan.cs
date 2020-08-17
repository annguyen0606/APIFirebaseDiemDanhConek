namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinNguoiThan")]
    public partial class ThongTinNguoiThan
    {
        [Key]
        [StringLength(16)]
        public string uid { get; set; }

        [StringLength(30)]
        public string hoten { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string quanhe { get; set; }

        [StringLength(10)]
        public string mahs { get; set; }

        [StringLength(10)]
        public string sodienthoai { get; set; }

        [StringLength(10)]
        public string malop { get; set; }

        [Column(TypeName = "image")]
        public byte[] hinhanh { get; set; }
    }
}
