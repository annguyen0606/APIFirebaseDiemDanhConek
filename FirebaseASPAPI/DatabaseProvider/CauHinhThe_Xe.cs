namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CauHinhThe_Xe
    {
        public long id { get; set; }

        [StringLength(300)]
        public string idTag { get; set; }

        [StringLength(50)]
        public string bienso { get; set; }

        [StringLength(100)]
        public string sokhung { get; set; }

        [StringLength(100)]
        public string somay { get; set; }

        public DateTime? ngayTao { get; set; }

        public long? idKhachHang { get; set; }

        [StringLength(50)]
        public string dienthoai { get; set; }

        public long? idCongty { get; set; }

        [StringLength(200)]
        public string tenXe { get; set; }
    }
}
