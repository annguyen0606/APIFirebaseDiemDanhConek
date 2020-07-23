namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public long IdNhanVien { get; set; }

        public long? IdCuaHang { get; set; }

        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public long? IdChucVu { get; set; }

        public long? IdBoPhan { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public DateTime? NgaySinh { get; set; }

        public long? Idcongty { get; set; }
    }
}
