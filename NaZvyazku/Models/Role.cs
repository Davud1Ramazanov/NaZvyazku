using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Required]
        public int Id { get; set; }
        [Key]
        public int RolesId { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string Roles { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
