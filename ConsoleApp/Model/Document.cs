namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        public int Id { get; set; }

        public int ComId { get; set; }

        [Required]
        [StringLength(40)]
        public string InvId { get; set; }

        public int? Type { get; set; }

        [StringLength(2000)]
        public string Content { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(300)]
        public string FileUrl { get; set; }

        public int? CompanySigned { get; set; }

        public int? CustomerSigned { get; set; }
    }
}
