namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATConversion")]
    public partial class VATConversion
    {
        public int id { get; set; }

        public int ComId { get; set; }

        [StringLength(100)]
        public string CKey { get; set; }

        public DateTime? ConvertedDate { get; set; }

        public int? InvoiceId { get; set; }

        [StringLength(100)]
        public string ConvertedBy { get; set; }
    }
}
