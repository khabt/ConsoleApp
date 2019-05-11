namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATInvoice")]
    public partial class VATInvoice
    {
        public int id { get; set; }

        public int? InvCateID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public decimal? No { get; set; }

        [Column(TypeName = "ntext")]
        public string Data { get; set; }

        [StringLength(12)]
        public string Serial { get; set; }

        [StringLength(12)]
        public string Pattern { get; set; }

        public int? ComID { get; set; }

        [StringLength(200)]
        public string ComName { get; set; }

        [StringLength(50)]
        public string ComPhone { get; set; }

        [StringLength(300)]
        public string ComAddress { get; set; }

        [StringLength(20)]
        public string ComTaxCode { get; set; }

        [StringLength(150)]
        public string ComBankName { get; set; }

        [StringLength(50)]
        public string ComBankNo { get; set; }

        [StringLength(50)]
        public string CusCode { get; set; }

        [StringLength(400)]
        public string CusName { get; set; }

        [StringLength(200)]
        public string Buyer { get; set; }

        [StringLength(300)]
        public string CusAddress { get; set; }

        [StringLength(50)]
        public string CusPhone { get; set; }

        [StringLength(100)]
        public string CusBankName { get; set; }

        [StringLength(50)]
        public string CusBankNo { get; set; }

        [StringLength(20)]
        public string CusTaxCode { get; set; }

        public int? Type { get; set; }

        public int? Status { get; set; }

        [StringLength(150)]
        public string PaymentMethod { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? PublishDate { get; set; }

        public decimal? Total { get; set; }

        public double? VATRate { get; set; }

        public decimal? VATAmount { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string AmountInWords { get; set; }

        public int? PaymentStatus { get; set; }

        public int? Converted { get; set; }

        [StringLength(200)]
        public string KindOfService { get; set; }

        public int? CusSignStatus { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        [StringLength(50)]
        public string PublishBy { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [StringLength(2000)]
        public string Extra { get; set; }

        public DateTime? ArisingDate { get; set; }

        [StringLength(200)]
        public string ProcessInvNote { get; set; }

        [StringLength(100)]
        public string Fkey { get; set; }

        public decimal? GrossValue { get; set; }

        public decimal? VatAmount0 { get; set; }

        public decimal? GrossValue0 { get; set; }

        public decimal? VatAmount5 { get; set; }

        public decimal? GrossValue5 { get; set; }

        public decimal? VatAmount10 { get; set; }

        public decimal? GrossValue10 { get; set; }

        public bool? Certified { get; set; }

        [StringLength(32)]
        public string CertifiedID { get; set; }

        [StringLength(128)]
        public string CertifiedData { get; set; }

        [StringLength(50)]
        public string ComFax { get; set; }

        [StringLength(50)]
        public string MaBA { get; set; }

        [StringLength(50)]
        public string SoPT { get; set; }

        public int? InvType { get; set; }

        [StringLength(150)]
        public string ParentName { get; set; }

        public decimal? OtherFees { get; set; }

        public decimal? ExtraFees { get; set; }

        public decimal? ChangeFees { get; set; }

        public decimal? VATOther { get; set; }

        [StringLength(150)]
        public string PortalLink { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(50)]
        public string Ikey { get; set; }

        [StringLength(4)]
        public string CurrencyUnit { get; set; }

        public int? StoreId { get; set; }
    }
}
