using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class CreditCard
    {
        public CreditCard()
        {
            Authorizations = new HashSet<Authorization>();
        }
        [Key]
        public int CreditCardId { get; set; }
        [Required]
        [DataType(DataType.CreditCard)]
        [Range(13, 19)]
        public int? CardNumber { get; set; }
        [Required]
        [Range (3,5)]
        public int? Cvv { get; set; }
        [Required]
        [DataType (DataType.DateTime)]
        [Range (1980,2023)]
        public int? DateCard { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}
