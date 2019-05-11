namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Decision")]
    public partial class Decision
    {
        public int id { get; set; }

        [StringLength(200)]
        public string DecisionName { get; set; }

        [StringLength(10)]
        public string DecisionNo { get; set; }

        public int? ComID { get; set; }

        [StringLength(200)]
        public string ParentCompany { get; set; }

        [StringLength(200)]
        public string ComName { get; set; }

        [StringLength(300)]
        public string ComAddress { get; set; }

        [Column(TypeName = "ntext")]
        public string Requester { get; set; }

        [StringLength(200)]
        public string Director { get; set; }

        [Column(TypeName = "ntext")]
        public string SystemName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string SoftApplication { get; set; }

        [StringLength(200)]
        public string ListInvPattern { get; set; }

        [Column(TypeName = "ntext")]
        public string Purpose { get; set; }

        [Column(TypeName = "ntext")]
        public string Workflow { get; set; }

        [Column(TypeName = "ntext")]
        public string Responsibility { get; set; }

        [Column(TypeName = "ntext")]
        public string EffectiveDate { get; set; }

        [StringLength(500)]
        public string EffectDate { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(20)]
        public string TaxCode { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? Status { get; set; }

        [StringLength(1000)]
        public string TechDepartment { get; set; }

        [StringLength(500)]
        public string Destination { get; set; }
    }
}
