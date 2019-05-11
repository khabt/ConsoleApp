namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvDeliver")]
    public partial class InvDeliver
    {
        public int id { get; set; }

        [StringLength(15)]
        public string Pattern { get; set; }

        [StringLength(15)]
        public string Serial { get; set; }

        public decimal? No { get; set; }

        public int? ComID { get; set; }

        [StringLength(50)]
        public string CusCode { get; set; }

        [StringLength(256)]
        public string CusName { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? SendDate { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public int? Status { get; set; }
    }
}
