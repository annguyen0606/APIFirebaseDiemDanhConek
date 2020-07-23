namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CauHinhDauDoc_CongTy
    {
        public long id { get; set; }

        [StringLength(300)]
        public string idDauDoc { get; set; }

        public long? idCongty { get; set; }

        public DateTime? ngayTao { get; set; }

        [StringLength(10)]
        public string loai { get; set; }
    }
}
