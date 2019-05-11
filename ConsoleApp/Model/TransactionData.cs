namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionData")]
    public partial class TransactionData
    {
        public Guid id { get; set; }

        [StringLength(12)]
        public string InvPattern { get; set; }

        [StringLength(12)]
        public string InvSerial { get; set; }

        public byte[] Data { get; set; }

        [StringLength(500)]
        public string Messages { get; set; }

        public byte[] CompleteResult { get; set; }

        public byte[] FailResult { get; set; }

        public int? Status { get; set; }

        public int? ComID { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? TypeTrans { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        [StringLength(500)]
        public string AttachedFile { get; set; }

        [StringLength(100)]
        public string NoRange { get; set; }

        [StringLength(20)]
        public string BillTime { get; set; }

        public int? TranLock { get; set; }
    }
}
