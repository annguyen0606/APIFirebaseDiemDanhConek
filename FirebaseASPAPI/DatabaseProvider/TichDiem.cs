namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TichDiem")]
    public partial class TichDiem
    {
        [Key]
        public long idTichDiem { get; set; }

        public long? idCongty { get; set; }

        public long? tongDiem { get; set; }

        public long? diemConLai { get; set; }

        [StringLength(200)]
        public string loaiThe { get; set; }

        public DateTime? ngayTao { get; set; }

        [StringLength(50)]
        public string bienSo { get; set; }

        [StringLength(200)]
        public string soKhung { get; set; }

        [StringLength(200)]
        public string soMay { get; set; }

        public long? idKhachHang { get; set; }
    }
}
