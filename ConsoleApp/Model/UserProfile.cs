namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        [Key]
        public int ProfileID { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string PropertyName { get; set; }

        [Column(TypeName = "ntext")]
        public string PropertyValuesString { get; set; }

        [Column(TypeName = "image")]
        public byte[] PropertyValuesBinary { get; set; }

        public DateTime? LastUpdateDate { get; set; }
    }
}
