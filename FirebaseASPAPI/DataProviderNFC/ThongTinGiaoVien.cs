namespace DataProviderNFC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinGiaoVien")]
    public partial class ThongTinGiaoVien
    {
        [Key]
        [StringLength(10)]
        public string magv { get; set; }

        [StringLength(30)]
        public string ten { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string sodienthoai { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        [StringLength(20)]
        public string password { get; set; }

        public int? port { get; set; }

        [StringLength(10)]
        public string malop { get; set; }

        public int? loaitaikhoan { get; set; }
    }
}
