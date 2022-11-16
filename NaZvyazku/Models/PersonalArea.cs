using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class PersonalArea
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public byte[] Avatar { get; set; }
        public int? TariffId { get; set; }
        public int? SubscriptionId { get; set; }
        public int? Cash { get; set; }
        public int? Gigabyte { get; set; }
        public DateTime? DateReg { get; set; }

        public virtual User User { get; set; }
    }
}
