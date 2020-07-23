namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        public long IdKhachHang { get; set; }

        public long? IdCongty { get; set; }

        [StringLength(50)]
        public string HoKH { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string DienThoai { get; set; }

        public long? MaNhomKH { get; set; }

        [StringLength(350)]
        public string Diachi { get; set; }

        public DateTime? NgayMua { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(50)]
        public string SoSBH { get; set; }

        [StringLength(50)]
        public string LoaiKH { get; set; }

        [StringLength(50)]
        public string KhachDenTu { get; set; }

        public bool? NhanTinThayDau { get; set; }

        public bool? ChiNhanTinThayDau { get; set; }

        [StringLength(200)]
        public string NgheNghiep { get; set; }

        public bool? NhanTinThayBugi { get; set; }

        public bool? NhanTinThayDauHopSo { get; set; }

        public bool? NhanTinThayDayDai { get; set; }

        public bool? NhanTinThaylocGio { get; set; }
    }
}
