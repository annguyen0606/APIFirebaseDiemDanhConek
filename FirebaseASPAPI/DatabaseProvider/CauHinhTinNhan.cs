namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHinhTinNhan")]
    public partial class CauHinhTinNhan
    {
        [Key]
        public int idMauTin { get; set; }

        [StringLength(30)]
        public string maLoaiTin { get; set; }

        public int? idCongTy { get; set; }

        public byte? sauSoNgay { get; set; }

        public byte? gioNhan { get; set; }

        public bool? dangHoatDong { get; set; }

        [StringLength(500)]
        public string noiDungTinNhan { get; set; }
    }
}
