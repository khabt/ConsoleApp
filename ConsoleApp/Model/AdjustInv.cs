namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdjustInv")]
    public partial class AdjustInv
    {
        public int id { get; set; }

        public int? InvId { get; set; }

        public int? AdjustInvId { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Pattern { get; set; }

        public DateTime? ProcessDate { get; set; }

        public int? Status { get; set; }

        public int? ComID { get; set; }

        [StringLength(200)]
        public string Attachefile { get; set; }
    }
}
