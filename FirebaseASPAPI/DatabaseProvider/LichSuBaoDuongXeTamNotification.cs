namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuBaoDuongXeTamNotification")]
    public partial class LichSuBaoDuongXeTamNotification
    {
        public long id { get; set; }

        public long? IdKhachHang { get; set; }

        [StringLength(500)]
        public string TenKH { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string DienThoai { get; set; }

        [StringLength(350)]
        public string Diachi { get; set; }

        [StringLength(100)]
        public string TenXe { get; set; }

        [StringLength(50)]
        public string SoKhung { get; set; }

        [StringLength(50)]
        public string SoMay { get; set; }

        [StringLength(30)]
        public string BienSo { get; set; }

        [StringLength(50)]
        public string KhachDenTu { get; set; }

        [StringLength(10)]
        public string LoaiBaoDuong { get; set; }

        [StringLength(300)]
        public string idReader { get; set; }

        [StringLength(200)]
        public string idTag { get; set; }

        public long? idCongty { get; set; }

        public int? isRead { get; set; }

        public DateTime? timeRead { get; set; }

        public DateTime? timeInsert { get; set; }
    }
}
