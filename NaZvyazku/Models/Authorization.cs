using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class Authorization
    {
        public Authorization()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int AuthorizationId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? CreditCardId { get; set; }
        public int? PhoneNumberId { get; set; }

        public virtual CreditCard CreditCard { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
