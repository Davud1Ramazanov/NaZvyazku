using System;
using System.Collections.Generic;
using System.Text;

namespace NaZvyazku.Controller
{
    public class Role
    {
        public int RolesId { get; set; }
        public string Roles { get; set; }

        public Role(int rolesId, string roles)
        {
            RolesId = rolesId;
            Roles = roles;
        }
    }
}
