using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class Info
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime? DateReg { get; set; }
        public string Subscription { get; set; }
        public string Tariff { get; set; }
        public int? Amount { get; set; }

        public virtual User User { get; set; }
    }
}
