namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuDatPhuTung")]
    public partial class LichSuDatPhuTung
    {
        [Key]
        public long IdXuatKho { get; set; }

        public int? IdCuaHangXuat { get; set; }

        public int? IdCongTyXuat { get; set; }

        public int? IdCongTyNhan { get; set; }

        public int? IdCuaHangNhan { get; set; }

        public DateTime? NgayDat { get; set; }

        public DateTime? NgayXuat { get; set; }

        public int? TrangThaiXacNhan { get; set; }

        public int? IdKho { get; set; }
    }
}
