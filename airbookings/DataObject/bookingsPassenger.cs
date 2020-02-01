using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airbookings
{
    public class BookingPassenger
    {
        public int id;
        public string sex;
        public string firstname;
        public string midname;
        public string lastname;
        public DateTime birthday;
        public string citizen;
        public string passport;
        public string email;

        public BookingPassenger() { }
        public BookingPassenger(int id, string sex, string firstname, string midname, string lastname, DateTime birthday, string citizen, string passport, string email)
        {
            this.id = id;
            this.sex = sex;
            this.firstname = firstname;
            this.midname = midname;
            this.lastname = lastname;
            this.midname = midname;
            this.birthday = birthday;
            this.citizen = citizen;
            this.passport = passport;
            this.email = email;
        }
    }
}
