using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarControl_Proxy__For_Test
{
    class CarProxy : IGasAndLocationService
    {
        public void ShowFuel()
        {
            new Car().ShowFuel();
        }

        public void ShowLocation()
        {
            new Car().ShowLocation();
        }
    }
}
