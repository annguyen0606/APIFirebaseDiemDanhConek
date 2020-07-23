namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuXuatKhoNgoai")]
    public partial class LichSuXuatKhoNgoai
    {
        [Key]
        public long IdXuatKho { get; set; }

        public int? IdCongTy { get; set; }

        public int? IdCuaHang { get; set; }

        public int? IdKhoXuat { get; set; }

        public DateTime? NgayXuat { get; set; }

        public int? TrangThaiXuat { get; set; }

        public DateTime? NgayTaoPhieu { get; set; }

        [StringLength(250)]
        public string TenCongTyNhan { get; set; }
    }
}
