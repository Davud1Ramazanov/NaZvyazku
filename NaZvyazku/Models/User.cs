using System;
using System.Collections.Generic;

namespace NaZvyazku.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime? DateReg { get; set; }
        public int? RoleId { get; set; }
        public int? AuthorizationId { get; set; }

        public virtual Authorization Authorization { get; set; }
        public virtual Role Role { get; set; }
        public virtual PersonalArea User1 { get; set; }
        public virtual Info UserNavigation { get; set; }
    }
}
