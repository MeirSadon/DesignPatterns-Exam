using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Flight__For_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight f = new Flight() { };
            FlyMe(new FlightAdapter(), f);
        }
        static void FlyMe(IFlightDao flightDao, Flight f)
        {
            flightDao.AddFlight(f);
            flightDao.RemoveFlight(f);
            flightDao.UpdateFlight(f);
        }
    }
}
