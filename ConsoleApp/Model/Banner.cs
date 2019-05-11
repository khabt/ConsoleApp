namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Banner
    {
        public int id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string NavigateUrl { get; set; }

        public int? Priority { get; set; }

        public bool? IsPub { get; set; }

        public int? Position { get; set; }

        public DateTime? FromDate { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public DateTime? ToDate { get; set; }

        [StringLength(250)]
        public string ImagePath { get; set; }
    }
}
