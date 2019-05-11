namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Publish")]
    public partial class Publish
    {
        public int id { get; set; }

        public int? ComID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(200)]
        public string ComName { get; set; }

        [StringLength(300)]
        public string ComAddress { get; set; }

        [StringLength(50)]
        public string ComPhone { get; set; }

        [StringLength(20)]
        public string ComTaxCode { get; set; }

        [StringLength(150)]
        public string RepresentPerson { get; set; }

        public int? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? PublishDate { get; set; }

        [StringLength(50)]
        public string TaxAuthorityCode { get; set; }

        [StringLength(200)]
        public string TaxAuthorityName { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(300)]
        public string Delimiter { get; set; }
    }
}
