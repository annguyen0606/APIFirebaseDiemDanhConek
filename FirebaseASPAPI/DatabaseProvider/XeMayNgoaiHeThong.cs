namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XeMayNgoaiHeThong")]
    public partial class XeMayNgoaiHeThong
    {
        [Key]
        [StringLength(50)]
        public string BienSo { get; set; }

        [StringLength(50)]
        public string SoMay { get; set; }

        [StringLength(50)]
        public string SoKhung { get; set; }

        public DateTime? NgayMua { get; set; }

        public long? IdKhachHang { get; set; }

        public long? IdCuaHang { get; set; }

        public long? Idcongty { get; set; }
    }
}
