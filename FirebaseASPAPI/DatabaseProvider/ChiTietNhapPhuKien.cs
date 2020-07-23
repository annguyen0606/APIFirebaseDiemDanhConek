namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietNhapPhuKien")]
    public partial class ChiTietNhapPhuKien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoHoaDonNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdPhuKien { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal ThanhTien { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCongTy { get; set; }

        public int? IdKey { get; set; }
    }
}
