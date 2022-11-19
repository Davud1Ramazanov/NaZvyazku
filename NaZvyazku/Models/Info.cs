using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class Info
    {
        [Required]
        public int Id { get; set; }
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string FullName { get; set; }
        [Required]
        [StringLength (15, MinimumLength = 6)]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(25, MinimumLength = 10)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Range(1980, 2023)]
        public DateTime? DateReg { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 20)]
        public string Subscription { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 20)]
        public string Tariff { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(30, 1000)]
        public int? Amount { get; set; }
        public virtual User User { get; set; }
    }
}
