using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public int? SubscriptionId { get; set; }
        public string Name { get; set; }
        public int? Gigabyte { get; set; }
        public int? Calls { get; set; }
        public int? Discount { get; set; }
        public string Notes { get; set; }
        public int? Price { get; set; }
    }
}
