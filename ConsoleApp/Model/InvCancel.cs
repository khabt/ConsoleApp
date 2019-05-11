namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvCancel")]
    public partial class InvCancel
    {
        public int id { get; set; }

        public int? ComID { get; set; }

        [StringLength(200)]
        public string ComName { get; set; }

        [StringLength(256)]
        public string ComAddress { get; set; }

        [StringLength(150)]
        public string ComPrepared { get; set; }

        [StringLength(150)]
        public string ComRepresent { get; set; }

        [StringLength(256)]
        public string Method { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public int? Hour { get; set; }

        public int? Minute { get; set; }

        public DateTime? PublishDate { get; set; }

        public DateTime? CancelDate { get; set; }

        [StringLength(20)]
        public string ComTaxCode { get; set; }
    }
}
