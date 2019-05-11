namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractAttach")]
    public partial class ContractAttach
    {
        public int Id { get; set; }

        public int? ContractId { get; set; }

        public int? ComId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(5)]
        public string Extension { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }
    }
}
