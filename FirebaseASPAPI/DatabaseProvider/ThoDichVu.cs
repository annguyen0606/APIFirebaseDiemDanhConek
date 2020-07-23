namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThoDichVu")]
    public partial class ThoDichVu
    {
        [Key]
        public int IdTho { get; set; }

        [StringLength(10)]
        public string MaTho { get; set; }

        [StringLength(100)]
        public string tenTho { get; set; }

        public int? IdChucVu { get; set; }

        public int? IdBoPhan { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public DateTime? ngaySinh { get; set; }

        public long? SoPhut { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? TrangThai { get; set; }

        public int? IdCuaHang { get; set; }

        public int? TinhTrangLamViec { get; set; }
    }
}
