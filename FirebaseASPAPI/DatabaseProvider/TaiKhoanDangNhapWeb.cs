namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanDangNhapWeb")]
    public partial class TaiKhoanDangNhapWeb
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Pass { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(50)]
        public string PhanQuyen { get; set; }

        public DateTime? NgayCapNhatPass { get; set; }
    }
}
