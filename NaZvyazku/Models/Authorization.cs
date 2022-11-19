using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class Authorization
    {
        public Authorization()
        {
            Users = new HashSet<User>();
        }

        [Required]
        public int Id { get; set; }
        [Key]
        public int AuthorizationId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(19, MinimumLength = 13)]
        public string Email { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 6)]
        public string Login { get; set; }
        [Required,DataType(DataType.Password), StringLength(15, MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        public int? CreditCardId { get; set; }
        [Required]
        public int? PhoneNumberId { get; set; }

        public virtual CreditCard CreditCard { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
