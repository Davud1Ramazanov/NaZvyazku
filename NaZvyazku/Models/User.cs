using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaZvyazku.Models
{
    public partial class User
    {
        [Required]
        public int Id { get; set; }
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Range(1985, 2023)]
        public DateTime? DateReg { get; set; }
        [Required]
        public int? RoleId { get; set; }
        [Required]
        public int? AuthorizationId { get; set; }
        public virtual Authorization Authorization { get; set; }
        public virtual Role Role { get; set; }
        public virtual PersonalArea User1 { get; set; }
        public virtual Info UserNavigation { get; set; }
    }
}
