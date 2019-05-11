namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("role")]
    public partial class role
    {
        public int roleid { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(50)]
        public string GroupId { get; set; }

        public bool? IsSysAdmin { get; set; }
    }
}
