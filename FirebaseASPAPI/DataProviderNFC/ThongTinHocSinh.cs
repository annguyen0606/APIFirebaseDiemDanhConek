namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinHocSinh")]
    public partial class ThongTinHocSinh
    {
        [Key]
        [StringLength(10)]
        public string mahs { get; set; }

        [StringLength(30)]
        public string hoten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string malop { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string magv { get; set; }

        [Column(TypeName = "image")]
        public byte[] hinhanh { get; set; }
    }
}
