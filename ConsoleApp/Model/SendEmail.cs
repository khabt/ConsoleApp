namespace ConsoleApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SendEmail")]
    public partial class SendEmail
    {
        public Guid id { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(550)]
        public string CCEmail { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        [StringLength(100)]
        public string EmailFrom { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        public byte[] FileAttach { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        public int? Status { get; set; }

        public DateTime? SendedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        [StringLength(30)]
        public string InvToken { get; set; }

        [StringLength(200)]
        public string BodySms { get; set; }

        [StringLength(50)]
        public string SmsTitle { get; set; }

        public int? SmsStatus { get; set; }

        [StringLength(12)]
        public string Password { get; set; }

        [StringLength(200)]
        public string CusName { get; set; }

        [Column(TypeName = "ntext")]
        public string PlainBody { get; set; }
    }
}
