namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessLog")]
    public partial class BusinessLog
    {
        public int id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime? Datetime { get; set; }

        public int? Type { get; set; }

        [Column(TypeName = "ntext")]
        public string Data { get; set; }

        public int? Comid { get; set; }
    }
}
