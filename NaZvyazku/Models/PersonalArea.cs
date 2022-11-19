using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace NaZvyazku.Models
{
    public partial class PersonalArea
    {
        [Required]
        public int Id { get; set; }
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string FullName { get; set; }
        public byte[] Avatar { get; set; }
        [Required]
        public int? TariffId { get; set; }
        [Required]
        public int? SubscriptionId { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(30, 1000)]
        public int? Cash { get; set; }
        [Required]
        [Range(1000, 250000)]
        public int? Gigabyte { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Range(1985, 2023)]
        public DateTime? DateReg { get; set; }

        public virtual User User { get; set; }
    }
}
