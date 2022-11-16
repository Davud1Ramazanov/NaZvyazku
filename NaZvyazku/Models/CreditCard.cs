using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class CreditCard
    {
        public CreditCard()
        {
            Authorizations = new HashSet<Authorization>();
        }

        public int CreditCardId { get; set; }
        public int? CardNumber { get; set; }
        public int? Cvv { get; set; }
        public int? DateCard { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}
