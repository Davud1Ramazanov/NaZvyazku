using System;
using System.Collections.Generic;
using System.Text;

namespace NaZvyazku.Controller
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public DateTime DateReg { get; set; }
        public int RoleID { get; set; }
        public int AuthorizationID { get; set; }    

        public User(int UserId, string Fullname, DateTime datereg, int RoleId, int AuthorizationId)
        {
            UserID = UserId;
            FullName = Fullname;
            DateReg = datereg;
            RoleID = RoleId;
            AuthorizationID = AuthorizationId;
        }
    }
}
