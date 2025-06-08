using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCRM.Models;
using Microsoft.EntityFrameworkCore;


namespace HotelCRM.Helpers
{
    public static class CurrentUserSession
    {
        public static User LoggedInUser { get; private set; }

        public static void SetCurrentUser(User user) => LoggedInUser = user;
        public static void ClearCurrentUser() => LoggedInUser = null;

        public static bool IsLoggedIn => LoggedInUser != null;
        public static bool IsAdmin => IsLoggedIn && LoggedInUser.Role == "Administrator";
        public static bool IsReceptionist => IsLoggedIn && LoggedInUser.Role == "Receptionist";
        public static bool IsHousekeeper => IsLoggedIn && LoggedInUser.Role == "Housekeeper";
        public static bool IsTechnician => IsLoggedIn && LoggedInUser.Role == "Technician";
    }
}
