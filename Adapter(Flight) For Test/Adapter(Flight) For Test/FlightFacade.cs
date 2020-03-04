using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Flight__For_Test
{
    public class FlightFacade : IFlightDao
    {
        public void AddFlight(Flight f)
        {
            Console.WriteLine($"new Flight: {f}");
        }

        public void RemoveFlight(Flight f)
        {
            Console.WriteLine($"Flight {f} Deleted");
        }

        public void UpdateFlight(Flight f)
        {
            Console.WriteLine($"Flight {f} Updated");
        }
    }
}
