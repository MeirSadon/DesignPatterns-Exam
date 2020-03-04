using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Flight__For_Test
{
    public class ThirdPartyZbang
    {
        public void AddFlight(Encrypted_Flight f)
        {
            Console.WriteLine("Zbang adding flight");
        }
        public void UpdateFlight(Encrypted_Flight f)
        {

        }
        public void RemoveFlight(Encrypted_Flight f)
        {

        }
    }
}
