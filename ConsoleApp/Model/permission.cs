namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("permission")]
    public partial class permission
    {
        public int permissionid { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(150)]
        public string Description { get; set; }
    }
}
