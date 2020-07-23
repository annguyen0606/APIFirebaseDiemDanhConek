namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuTichDiem")]
    public partial class LichSuTichDiem
    {
        public long id { get; set; }

        public long idTichDiem { get; set; }

        public long? diem { get; set; }

        [StringLength(200)]
        public string loai { get; set; }

        public DateTime? ngayTao { get; set; }
    }
}
