namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuBaoDuongXe")]
    public partial class LichSuBaoDuongXe
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

        public DateTime? GIOVAOXE { get; set; }

        public int? TGDUKIEN { get; set; }

        public int? TTBAODUONG { get; set; }

        public DateTime? GIOHOANTHANH { get; set; }

        public int? CVIEC { get; set; }

        [StringLength(50)]
        public string BANNANG { get; set; }

        [StringLength(500)]
        public string KYTHUATVIEN { get; set; }

        public DateTime? NGAYKHIEUNAI { get; set; }

        [StringLength(500)]
        public string NOIDUNGKHIEUNAI { get; set; }

        [StringLength(500)]
        public string BIENPHAP { get; set; }

        [StringLength(500)]
        public string KETQUAKN { get; set; }

        [StringLength(300)]
        public string idReader { get; set; }

        [StringLength(200)]
        public string idTag { get; set; }

        [StringLength(500)]
        public string YeuCauKhachHang { get; set; }

        [StringLength(500)]
        public string TuVanSuaChua { get; set; }
    }
}
