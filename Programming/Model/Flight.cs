using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Flight
    {
        private String DeparturePoint;
        private String Destination;
        private int FlightTime;
        public int flight_time
        {
            set
            {
                if (value > 0 && value < 800)
                {
                    FlightTime = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return FlightTime;
            }
        }

        public String destination
        {
            set
            {
                Destination = value;
            }
            get
            {
                return Destination;
            }
        }

        public String departure_point
        {
            set
            {
                DeparturePoint = value;
            }
            get
            {
                return DeparturePoint;
            }
        }

        public Flight()
        {

        }

        public Flight(String DeparturePoint , String Destination, int FlightTime)
        {
            this.departure_point = DeparturePoint;
            this.destination = Destination;
            this.flight_time = FlightTime;
        }
    }
}
