namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTinNhan")]
    public partial class LoaiTinNhan
    {
        [Key]
        public int idLoaiTin { get; set; }

        [StringLength(30)]
        public string maLoaiTin { get; set; }

        [StringLength(50)]
        public string tenLoaiTin { get; set; }
    }
}
