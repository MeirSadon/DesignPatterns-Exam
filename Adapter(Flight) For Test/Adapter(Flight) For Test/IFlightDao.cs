using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Flight__For_Test
{
    public interface IFlightDao
    {
        void AddFlight(Flight f);
        void UpdateFlight(Flight f);    
        void RemoveFlight(Flight f);
    }
}
