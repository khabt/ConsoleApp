namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutwardStock")]
    public partial class OutwardStock
    {
        public int Id { get; set; }

        public int? Version { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(5)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? No { get; set; }

        public int? OriginalNo { get; set; }

        [Column(TypeName = "ntext")]
        public string Data { get; set; }

        [StringLength(12)]
        public string Serial { get; set; }

        [StringLength(12)]
        public string Pattern { get; set; }

        public int? ComID { get; set; }

        [StringLength(150)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? PublishDate { get; set; }

        [StringLength(100)]
        public string InStocker { get; set; }

        [StringLength(100)]
        public string OutStocker { get; set; }

        [StringLength(50)]
        public string Shipper { get; set; }

        [StringLength(50)]
        public string ContractNo { get; set; }

        [StringLength(50)]
        public string Vehicle { get; set; }

        [StringLength(300)]
        public string OutWareHouse { get; set; }

        [StringLength(300)]
        public string InWareHouse { get; set; }

        public decimal? OriginalTotal { get; set; }

        public decimal? OriginalDiscount { get; set; }

        public decimal? OriginalAmount { get; set; }

        public decimal? VNDTotal { get; set; }

        public decimal? VNDDiscount { get; set; }

        public decimal? VNDAmount { get; set; }

        [StringLength(50)]
        public string FKey { get; set; }

        [StringLength(150)]
        public string AmountInWords { get; set; }

        public int? State { get; set; }

        public DateTime? ArisingDate { get; set; }

        [StringLength(1000)]
        public string ContentExtra { get; set; }

        [StringLength(1000)]
        public string Extra { get; set; }

        [StringLength(300)]
        public string ComExtra { get; set; }

        [StringLength(100)]
        public string PublishBy { get; set; }

        [StringLength(50)]
        public string CusCode { get; set; }

        [StringLength(20)]
        public string CusTaxCode { get; set; }

        [StringLength(200)]
        public string CusName { get; set; }
    }
}
