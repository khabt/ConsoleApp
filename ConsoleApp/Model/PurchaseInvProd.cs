namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseInvProd")]
    public partial class PurchaseInvProd
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public decimal? Total { get; set; }

        public decimal? VATRate { get; set; }

        public decimal? VATAmount { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string Extra { get; set; }

        [StringLength(10)]
        public string ComID { get; set; }

        public int? PurchaseInvId { get; set; }

        [StringLength(40)]
        public string SupplierCode { get; set; }
    }
}
