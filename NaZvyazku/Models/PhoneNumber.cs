using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class PhoneNumber
    {
        public PhoneNumber()
        {
            Authorizations = new HashSet<Authorization>();
        }
        [Key]
        public int PhoneNumberId { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Range(10, 15)]
        public int? PhoneNum { get; set; }

        public virtual ICollection<Authorization> Authorizations { get; set; }
    }
}
