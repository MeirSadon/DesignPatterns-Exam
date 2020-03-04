using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Flight__For_Test
{
    public class FlightAdapter : IFlightDao
    {
        ThirdPartyZbang thirdParty = new ThirdPartyZbang();

        public FlightAdapter()
        {
            
        }
        public void AddFlight(Flight f)
        {
            Encrypted_Flight ef = FlightAdapter.GetFlight(f); // turn Flight f --> Encrypted flight
            thirdParty.AddFlight(ef);
        }

        public void RemoveFlight(Flight f)
        {
            throw new NotImplementedException();
        }

        public void UpdateFlight(Flight f)
        {
            throw new NotImplementedException();
        }

        public static Encrypted_Flight GetFlight(Flight f)
        {
            return new Encrypted_Flight(f.FlightNumber, f.Tickets, f.AirlineName, f.Origin, f.Destination);
        }
    }
}
