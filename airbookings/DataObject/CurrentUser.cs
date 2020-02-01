using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airbookings
{
    class CurrentUser
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string UserType { get; set; }
        public static string Email { get; set; }
        public static string Name { get; set; }
        public static string Sex { get; set; }
        public static string Citizenship { get; set; }
        public static string City { get; set; }

        public static void SetUserInfo(User user)
        {
            Login = user.login;
            Password = user.password;
            UserType = user.userType;
            Email = user.email;
            Name = user.name;
        }
    }
}
