namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanDangNhap")]
    public partial class TaiKhoanDangNhap
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(500)]
        public string Pass { get; set; }

        public long IdNhanVien { get; set; }

        [StringLength(50)]
        public string Quyen { get; set; }

        public long? IdCongTy { get; set; }
    }
}
