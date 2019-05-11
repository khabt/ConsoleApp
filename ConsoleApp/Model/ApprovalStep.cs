namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApprovalStep")]
    public partial class ApprovalStep
    {
        public int Id { get; set; }

        public int? Position { get; set; }

        [StringLength(200)]
        public string Roles { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? WorkFlowId { get; set; }

        public int? InvId { get; set; }

        public int? StepState { get; set; }

        [StringLength(50)]
        public string ApprovedBy { get; set; }

        [StringLength(500)]
        public string Note { get; set; }
    }
}
