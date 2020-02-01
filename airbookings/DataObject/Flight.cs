using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airbookings
{
    public class Flight
    {
        public string flight;
        public string departureAirport;
        public string departureCity;
        public string arrivalAirport;
        public string arrivalCity;
        public DateTime departureDate;
        public DateTime arrivalDate;
        public string airline;
        public int standart;
        public int extended;
        public int full;

        public Flight(string flight)
        {
            this.flight = flight;
        }
    }
}
