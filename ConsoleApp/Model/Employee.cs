namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? ComId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateOfBirth { get; set; }

        public int? Sex { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(20)]
        public string IDNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? IDDateOfIssue { get; set; }

        [StringLength(200)]
        public string IDPlaceOfIssue { get; set; }

        [StringLength(15)]
        public string OfficePhone { get; set; }

        [StringLength(15)]
        public string CellPhone { get; set; }

        [StringLength(15)]
        public string HomePhone { get; set; }

        public bool? IsActivate { get; set; }
    }
}
