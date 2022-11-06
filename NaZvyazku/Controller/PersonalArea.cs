using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NaZvyazku.Controller
{
    public class PersonalArea
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public Image Avatar { get; set; }
        public int TariffID { get; set; }
        public int SubscriptionID { get; set; }
        public int Cash { get; set; }
        public int Gigabyte { get; set; }
        public DateTime DateReg { get; set; }

        public PersonalArea(int userId, string fullName, Image avatar, int tariffID, int subscriptionID, int cash, int gigabyte, DateTime dateReg)
        {
            UserId = userId;
            FullName = fullName;
            Avatar = avatar;
            TariffID = tariffID;
            SubscriptionID = subscriptionID;
            Cash = cash;
            Gigabyte = gigabyte;
            DateReg = dateReg;
        }
    }
}
