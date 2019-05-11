namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string BankAccountName { get; set; }

        [StringLength(150)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string BankNumber { get; set; }

        [StringLength(150)]
        public string ContactPerson { get; set; }

        [StringLength(512)]
        public string Descriptions { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(550)]
        public string CCEmail { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(150)]
        public string RepresentPerson { get; set; }

        [StringLength(20)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? ComID { get; set; }

        [StringLength(200)]
        public string SignatureImage { get; set; }

        public int? CusType { get; set; }

        [StringLength(100)]
        public string SerialCert { get; set; }

        public int? DeliverMethod { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(250)]
        public string Buyer { get; set; }

        [StringLength(500)]
        public string ExtraPhone { get; set; }
    }
}
