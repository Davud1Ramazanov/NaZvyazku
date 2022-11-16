using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class Tariff
    {
        public int Id { get; set; }
        public int? TariffId { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public int? Stock { get; set; }
        public int? Gigabyte { get; set; }
        public int? Calls { get; set; }
        public string Notes { get; set; }
        public int? Price { get; set; }
    }
}
