namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseInvoice")]
    public partial class PurchaseInvoice
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string EnterpriseName { get; set; }

        public DateTime? ArisingDate { get; set; }

        [StringLength(20)]
        public string Pattern { get; set; }

        [StringLength(10)]
        public string Serial { get; set; }

        public int? InvoiceNo { get; set; }

        public decimal? Total { get; set; }

        [StringLength(100)]
        public string Supplier { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ComId { get; set; }

        [StringLength(20)]
        public string TaxCode { get; set; }

        [StringLength(20)]
        public string Currency { get; set; }

        public int? Type { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool? Payment { get; set; }
    }
}
