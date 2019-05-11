namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublishTemp")]
    public partial class PublishTemp
    {
        public int id { get; set; }

        public int? PublishInvID { get; set; }

        [StringLength(200)]
        public string ComName { get; set; }

        [StringLength(20)]
        public string ComTaxCode { get; set; }

        [StringLength(300)]
        public string ComAddress { get; set; }

        [StringLength(40)]
        public string ComPhone { get; set; }

        [StringLength(50)]
        public string ComFax { get; set; }

        [StringLength(50)]
        public string ComBankNumber { get; set; }
    }
}
