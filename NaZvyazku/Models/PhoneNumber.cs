using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class PhoneNumber
    {
        public PhoneNumber()
        {
            Authorizations = new HashSet<Authorization>();
        }

        public int PhoneNumberId { get; set; }
        public int? PhoneNum { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}
