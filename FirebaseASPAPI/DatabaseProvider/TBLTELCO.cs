namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLTELCO")]
    public partial class TBLTELCO
    {
        [StringLength(500)]
        public string TransactionID { get; set; }

        [StringLength(50)]
        public string PortType { get; set; }

        [StringLength(50)]
        public string ActionType { get; set; }

        [Key]
        public decimal MSISDN { get; set; }

        [StringLength(50)]
        public string Route { get; set; }

        [StringLength(50)]
        public string Recipient { get; set; }

        [StringLength(50)]
        public string Donor { get; set; }

        [StringLength(50)]
        public string BlockHolder { get; set; }

        [StringLength(500)]
        public string Tdate { get; set; }
    }
}
