namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublishInvoice")]
    public partial class PublishInvoice
    {
        public int id { get; set; }

        public int? ComId { get; set; }

        public int? PublishID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? FromNo { get; set; }

        public decimal? ToNo { get; set; }

        public int? Status { get; set; }

        public decimal? CurrentNo { get; set; }

        [StringLength(6)]
        public string InvSerial { get; set; }

        [StringLength(2)]
        public string InvSerialPrefix { get; set; }

        [StringLength(3)]
        public string InvSerialSuffix { get; set; }

        public DateTime? StartDate { get; set; }

        public int? RegisterID { get; set; }

        [StringLength(50)]
        public string RegisterName { get; set; }

        [StringLength(12)]
        public string InvPattern { get; set; }

        [StringLength(200)]
        public string InvCateName { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(3)]
        public string SerialDivisionMark { get; set; }

        [StringLength(500)]
        public string UserNames { get; set; }
    }
}
