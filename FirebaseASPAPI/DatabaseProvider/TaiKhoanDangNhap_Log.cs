namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TaiKhoanDangNhap_Log
    {
        [Key]
        public int IdLog { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? IdCongTy { get; set; }

        [StringLength(50)]
        public string IPadress { get; set; }

        [StringLength(200)]
        public string Host { get; set; }

        public DateTime? TimeLog { get; set; }

        public bool? TrangThai { get; set; }
    }
}
