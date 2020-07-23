namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThoDichVu_GioViec
    {
        public int id { get; set; }

        public int? IdTho { get; set; }

        public int? IdGioViec { get; set; }

        public DateTime? NgaySuaChua { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        public long? IdBaoDuong { get; set; }
    }
}
