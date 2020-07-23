namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tinnhan_xedaban
    {
        public long id { get; set; }

        public long? smsid { get; set; }

        public long? idxedaban { get; set; }

        public long? idkhachhang { get; set; }
    }
}
