using System;
using System.Collections.Generic;
using System.Text;

namespace NaZvyazku.Controller
{
    public class Authorization
    {
        public int AuthorizationID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int CreditCardID { get; set; }
        public int PhoneNumberID { get; set; }

        public Authorization(int authorizationID, string fullName, string email, string login, string password, int creditCardID, int phoneNumberID)
        {
            AuthorizationID = authorizationID;
            FullName = fullName;
            Email = email;
            Login = login;
            Password = password;
            CreditCardID = creditCardID;
            PhoneNumberID = phoneNumberID;
        }
    }
}
