namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SendSm
    {
        public int Id { get; set; }

        public int? ComID { get; set; }

        [StringLength(50)]
        public string InvKey { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(300)]
        public string SmsBody { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? SendDate { get; set; }

        public int? Status { get; set; }
    }
}
