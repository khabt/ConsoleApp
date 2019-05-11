namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordsInv")]
    public partial class RecordsInv
    {
        public int id { get; set; }

        [StringLength(20)]
        public string InvPattern { get; set; }

        public int? Status { get; set; }

        [StringLength(500)]
        public string AccordingTo { get; set; }

        [StringLength(200)]
        public string RecordCreationInfor { get; set; }

        [StringLength(200)]
        public string RepresentA { get; set; }

        [StringLength(200)]
        public string RepresentB { get; set; }

        [StringLength(100)]
        public string Confirmation { get; set; }

        public int? AdjustId { get; set; }

        [StringLength(100)]
        public string Reason { get; set; }

        [StringLength(100)]
        public string Commitment { get; set; }

        [StringLength(250)]
        public string Path { get; set; }
    }
}
