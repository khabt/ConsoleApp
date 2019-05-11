namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userdata")]
    public partial class userdata
    {
        [Key]
        public int userid { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        public int? Type { get; set; }

        [Required]
        [StringLength(64)]
        public string password { get; set; }

        public int? PasswordFormat { get; set; }

        [StringLength(128)]
        public string PasswordSalt { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(256)]
        public string PasswordQuestion { get; set; }

        [StringLength(256)]
        public string PasswordAnswer { get; set; }

        public bool? IsApproved { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? FailedPassAttemptCount { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(150)]
        public string Serials { get; set; }

        public int? StoreId { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }
    }
}
