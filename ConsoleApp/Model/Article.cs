namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(256)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string Data { get; set; }

        public int? Priority { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string UserCreate { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string UserModified { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateFinish { get; set; }

        public int? ComId { get; set; }

        public bool? IsPub { get; set; }

        public bool? HotYN { get; set; }

        [StringLength(128)]
        public string UrlName { get; set; }
    }
}
