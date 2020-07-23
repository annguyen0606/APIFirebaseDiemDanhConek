namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class xedaban_bk20180418
    {
        [Key]
        public long IdXeDaBan { get; set; }

        [StringLength(50)]
        public string TenXe { get; set; }

        [StringLength(30)]
        public string BienSo { get; set; }

        public DateTime? NgayBan { get; set; }

        public long? IdKhachHang { get; set; }

        public long? IdCongty { get; set; }

        public long? IdCuaHang { get; set; }

        [StringLength(30)]
        public string SoKhung { get; set; }

        [StringLength(30)]
        public string SoMay { get; set; }

        public byte? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? Dongia { get; set; }

        [StringLength(30)]
        public string Mauxe { get; set; }

        [StringLength(50)]
        public string LoaiKH { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(500)]
        public string LogTimeSent { get; set; }

        public int? IdLoaiXe { get; set; }
    }
}
