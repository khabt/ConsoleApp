namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        public int? ComID { get; set; }

        [StringLength(200)]
        public string NameProduct { get; set; }

        public decimal? Price { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public int? VATRate { get; set; }

        [StringLength(20)]
        public string GroupCode { get; set; }

        [StringLength(400)]
        public string Extra { get; set; }
    }
}
