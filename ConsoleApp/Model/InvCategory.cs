namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvCategory")]
    public partial class InvCategory
    {
        public int id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(20)]
        public string InvPattern { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsPub { get; set; }
    }
}
