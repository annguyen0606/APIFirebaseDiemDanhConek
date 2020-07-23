namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LichSuBaoDuongXe_bkthangloi_20180409
    {
        [Key]
        public long IdBaoDuong { get; set; }

        public long? IdCuaHang { get; set; }

        public long? IdKhachHang { get; set; }

        public long? IdCongty { get; set; }

        [StringLength(250)]
        public string TenXe { get; set; }

        [StringLength(30)]
        public string BienSo { get; set; }

        [StringLength(30)]
        public string Sokhung { get; set; }

        [StringLength(30)]
        public string SoMay { get; set; }

        public DateTime? NgayBaoDuong { get; set; }

        public DateTime? NgayGiaoXe { get; set; }

        public int? SoLan { get; set; }

        public int? SoKm { get; set; }

        public bool? ThayDau { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(500)]
        public string YeuCauKH { get; set; }

        public int? IdThoDuyet { get; set; }

        public bool? XuatPT { get; set; }

        public bool? ThayDauMay { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string LoaiBaoDuong { get; set; }

        public bool? NhongXich { get; set; }

        public bool? LamMay { get; set; }

        public bool? isPrinted { get; set; }

        public bool? Type { get; set; }
    }
}
