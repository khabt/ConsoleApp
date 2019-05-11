namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractProduct")]
    public partial class ContractProduct
    {
        public int Id { get; set; }

        public int? ComId { get; set; }

        public int? ContractId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public decimal? QuantityRequired { get; set; }

        public int? QuantityDelivered { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Total { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? Discount { get; set; }

        public double? VATRate { get; set; }

        public decimal? VATAmount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }
    }
}
