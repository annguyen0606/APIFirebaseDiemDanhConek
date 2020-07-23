namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDiaChiKhachHang")]
    public partial class tblDiaChiKhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdKhachHang { get; set; }

        [StringLength(100)]
        public string SoNha { get; set; }

        [StringLength(200)]
        public string Phuong_Xa { get; set; }

        [StringLength(200)]
        public string Quan_Huyen { get; set; }

        [StringLength(100)]
        public string Tinh { get; set; }
    }
}
