namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductOStock")]
    public partial class ProductOStock
    {
        public int? OutwardStockTicketId { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public decimal? Discount { get; set; }

        public decimal? InQuantity { get; set; }

        public decimal? OutQuantity { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(200)]
        public string Extra { get; set; }

        public int? IsSum { get; set; }

        public decimal? Total { get; set; }

        public decimal? Amount { get; set; }

        public int Id { get; set; }
    }
}
