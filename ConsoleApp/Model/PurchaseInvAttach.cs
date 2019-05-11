namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseInvAttach")]
    public partial class PurchaseInvAttach
    {
        public int Id { get; set; }

        public int PurchaseInvId { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
