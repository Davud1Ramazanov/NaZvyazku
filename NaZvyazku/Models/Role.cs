using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int RolesId { get; set; }
        public string Roles { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
