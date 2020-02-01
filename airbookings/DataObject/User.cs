using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airbookings
{
    public class User
    {
        public string login;
        public string password;
        public string userType;
        public string email;
        public string name;
        public string sex;
        public string citizenship;
        public string city;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public User(string login, string password, string userType, string email, string name, string sex, string citizenship, string city)
        {
            this.login = login;
            this.password = password;
            this.userType = userType;
            this.email = email;
            this.name = name;
            this.sex = sex;
            this.citizenship = citizenship;
            this.city = city;
        }
    }
}
