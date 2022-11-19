using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
        [Required]
        public int? SubscriptionId { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string Name { get; set; }
        [Range(1000, 25000)]
        public int? Gigabyte { get; set; }
        [Required]
        [Range(30, 3000)]
        public int? Calls { get; set; }
        [Range(5, 35)]
        public int? Discount { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 20)]
        public string Notes { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(30, 1000)]
        public int? Price { get; set; }
    }
}
