namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvCertify")]
    public partial class InvCertify
    {
        public int id { get; set; }

        public int? InvId { get; set; }

        public int? Status { get; set; }

        public int? Type { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public decimal? No { get; set; }

        public int? ComId { get; set; }

        [StringLength(20)]
        public string Serial { get; set; }

        [StringLength(20)]
        public string Pattern { get; set; }
    }
}
