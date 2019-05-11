namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int Id { get; set; }

        public int? ComId { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int? Type { get; set; }

        [StringLength(100)]
        public string UserCode { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? IsSync { get; set; }
    }
}
