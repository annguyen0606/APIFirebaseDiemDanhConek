namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XeCuaHang")]
    public partial class XeCuaHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IdXeCuaHang { get; set; }

        public long? IdXe { get; set; }

        public long? IdCuaHang { get; set; }

        [StringLength(30)]
        public string SoMay { get; set; }

        [StringLength(30)]
        public string SoKhung { get; set; }

        public long? GiaNhap { get; set; }

        public long? IdCongty { get; set; }

        public virtual CuaHang CuaHang { get; set; }
    }
}
