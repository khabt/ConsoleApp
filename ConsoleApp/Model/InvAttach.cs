namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvAttach")]
    public partial class InvAttach
    {
        public int Id { get; set; }

        public int ComID { get; set; }

        public int InvId { get; set; }

        [StringLength(300)]
        public string FilePath { get; set; }

        public DateTime UploadDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        public int? Signed { get; set; }
    }
}
