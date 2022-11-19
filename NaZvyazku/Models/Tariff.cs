using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class Tariff
    {
        public int Id { get; set; }
        [Required]
        public int? TariffId { get; set; }
        [Required]
        [StringLength(25,MinimumLength = 10)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Device { get; set; }
        [Required]
        [Range(5, 50)]
        public int? Stock { get; set; }
        [Required]
        [Range(1000, 25000)]
        public int? Gigabyte { get; set; }
        [Required]
        [Range(30, 2000)]
        public int? Calls { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 20)]
        public string Notes { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(30, 1000)]
        public int? Price { get; set; }
    }
}
