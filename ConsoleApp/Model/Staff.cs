namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Division { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(30)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        public int? ComID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
