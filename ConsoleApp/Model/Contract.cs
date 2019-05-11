namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int Id { get; set; }

        public int? ComId { get; set; }

        [StringLength(15)]
        public string ContractNo { get; set; }

        [StringLength(500)]
        public string Epitome { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SignDate { get; set; }

        public int? SignStatus { get; set; }

        [StringLength(10)]
        public string CurrencyType { get; set; }

        public decimal? Value { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? ExchangeValue { get; set; }

        public decimal? LiquidatedValue { get; set; }

        [StringLength(100)]
        public string ImplementingAgency { get; set; }

        public int? ExecutorId { get; set; }

        public bool? InvoicePublished { get; set; }

        [StringLength(20)]
        public string Pattern { get; set; }

        [StringLength(15)]
        public string Serial { get; set; }

        public int? InvoiceNo { get; set; }

        [StringLength(20)]
        public string CustomerCode { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string CustomerPhone { get; set; }

        [StringLength(50)]
        public string CustomerFax { get; set; }

        [StringLength(500)]
        public string CustomerAddress { get; set; }

        [StringLength(100)]
        public string CustomerRepresentative { get; set; }

        [StringLength(100)]
        public string CustomerPosition { get; set; }

        [StringLength(100)]
        public string CustomerBankAccount { get; set; }

        [StringLength(200)]
        public string CustomerBankName { get; set; }

        [StringLength(100)]
        public string CustomerTaxCode { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [StringLength(100)]
        public string ContactName { get; set; }

        [StringLength(20)]
        public string ContactPhone { get; set; }

        [StringLength(100)]
        public string ContactFax { get; set; }

        [StringLength(100)]
        public string ContactPosition { get; set; }

        [StringLength(100)]
        public string Signer { get; set; }

        public int? ContractState { get; set; }

        public int? ContractStatus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateStatus { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }
    }
}
