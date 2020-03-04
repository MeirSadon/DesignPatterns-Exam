using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Flight__For_Test
{
    public class Encrypted_Flight
    {
        public int FlightNumber { get; set; }
        public int Tickets { get; set; }
        public string AirlineName { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int AllChars { get; set; }

        //public Encrypted_Flight()
        //{
        //    char[] airlineNameReverse = AirlineName.ToCharArray();
        //    Array.Reverse(airlineNameReverse);
        //    AirlineName = airlineNameReverse.ToString();
        //    char[] originReverse = Origin.ToCharArray();
        //    Array.Reverse(originReverse);
        //    Origin = originReverse.ToString();
        //    char[] destinationReverse = Destination.ToCharArray();
        //    Array.Reverse(destinationReverse);
        //    Destination = destinationReverse.ToString();
        //    AllChars = AirlineName.Length + Origin.Length + Destination.Length;
        //}
        public Encrypted_Flight(int flightNumber, int tickets, string airlineName, string origin, string destination)
        {
            FlightNumber = flightNumber;
            Tickets = tickets;
            char[] airlineNameReverse = airlineName.ToCharArray();
            Array.Reverse(airlineNameReverse);
            AirlineName = airlineNameReverse.ToString();
            char[] originReverse = Origin.ToCharArray();
            Array.Reverse(originReverse);
            Origin = originReverse.ToString();
            char[] destinationReverse = Destination.ToCharArray();
            Array.Reverse(destinationReverse);
            Destination = destinationReverse.ToString();
            AllChars = AirlineName.Length + Origin.Length + Destination.Length;
        }
    }
}
