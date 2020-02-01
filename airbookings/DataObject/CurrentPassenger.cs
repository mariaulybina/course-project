using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airbookings
{
    static class CurrentPassenger//класс предназначен для автоматического заполнения информации о пассажире при покупке билета
    {
        public static int Id { get; set; }
        public static string Sex { get; set; }
        public static string Firstname { get; set; }
        public static string Midname { get; set; }
        public static string Lastname { get; set; }
        public static DateTime Birthday { get; set; }
        public static string Citizen { get; set; }
        public static string Passport { get; set; }
        public static string Email { get; set; }

        public static void SetPassengerInfo(Passenger passenger)
        {
            Id = passenger.id;
            Sex = passenger.sex;
            Firstname = passenger.firstname;
            Midname = passenger.midname;
            Lastname = passenger.lastname;
            Birthday = passenger.birthday;
            Citizen = passenger.citizen;
            Passport = passenger.passport;
            Email = passenger.email;
        }

        public static void UnsetPassengerInfo()
        {
            Id = 0;
            Sex = "";
            Firstname = "";
            Midname = "";
            Lastname = "";
            Birthday = DateTime.Now;
            Citizen = "";
            Passport ="";
            Email = "";
        }
    }
}
