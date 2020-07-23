namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuanDoanXeTam")]
    public partial class ChuanDoanXeTam
    {
        [Key]
        public int IdChuanDoan { get; set; }

        public int? SoKm { get; set; }

        public int? ApSuat { get; set; }

        [StringLength(50)]
        public string GocDanhLua { get; set; }

        public int? TocDoKhongTai { get; set; }

        public int? TocDoToanTai { get; set; }

        [StringLength(150)]
        public string PhoiKhi { get; set; }

        [StringLength(150)]
        public string TruyenLuc { get; set; }

        [StringLength(150)]
        public string Dien { get; set; }

        [StringLength(150)]
        public string KhungSuonGiamSoc { get; set; }

        [StringLength(250)]
        public string Khac { get; set; }

        public int? IdBaoDuong { get; set; }
    }
}
