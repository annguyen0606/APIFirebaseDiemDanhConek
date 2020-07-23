namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHinhTichDiem")]
    public partial class CauHinhTichDiem
    {
        [Key]
        public long idCauHinhTD { get; set; }

        public long? idCongTy { get; set; }

        public long? soTien { get; set; }

        public long? soDiem { get; set; }

        public bool? guiTin { get; set; }

        public DateTime? ngayTao { get; set; }

        public DateTime? ngaySua { get; set; }
    }
}
