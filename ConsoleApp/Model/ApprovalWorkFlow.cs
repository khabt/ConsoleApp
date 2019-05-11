namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApprovalWorkFlow")]
    public partial class ApprovalWorkFlow
    {
        public int Id { get; set; }

        public int? ComId { get; set; }

        public int? InvId { get; set; }

        public int? WorkFlowState { get; set; }
    }
}
