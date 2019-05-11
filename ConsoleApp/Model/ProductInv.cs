namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductInv")]
    public partial class ProductInv
    {
        public int? InvID { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        public decimal? Price { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public decimal? Total { get; set; }

        public double? VATRate { get; set; }

        public double? Discount { get; set; }

        public decimal? VATAmount { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? Amount { get; set; }

        public int? ProdType { get; set; }

        public int? IsSum { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(200)]
        public string Extra { get; set; }

        public int? ComID { get; set; }

        public int id { get; set; }
    }
}
