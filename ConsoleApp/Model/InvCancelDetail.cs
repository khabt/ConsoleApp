namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvCancelDetail
    {
        public int id { get; set; }

        public int? InvCancelID { get; set; }

        [StringLength(200)]
        public string InvCancellation { get; set; }

        [StringLength(20)]
        public string InvPattern { get; set; }

        [StringLength(20)]
        public string InvSerial { get; set; }

        [StringLength(200)]
        public string InvCateName { get; set; }

        public int? InvCateID { get; set; }

        public decimal? FromNo { get; set; }

        public decimal? ToNo { get; set; }

        public int? Quantity { get; set; }
    }
}
