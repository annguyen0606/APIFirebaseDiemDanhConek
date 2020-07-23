namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoXuat")]
    public partial class KhoXuat
    {
        [Key]
        public int IdXuatKho { get; set; }

        [StringLength(20)]
        public string MaPT { get; set; }

        [StringLength(250)]
        public string TenPT { get; set; }

        public int? SoLuong { get; set; }

        public DateTime? NgayXuat { get; set; }

        [StringLength(50)]
        public string LoaiXuat { get; set; }

        public int? IdKho { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        public long? IdBaoDuong { get; set; }

        public long? IdBaoDuongTam { get; set; }

        public long? IdPT { get; set; }
    }
}
