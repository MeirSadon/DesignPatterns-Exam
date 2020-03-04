using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarControl_Proxy__For_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            IGasAndLocationService cp = new CarProxy();
            cp.ShowLocation();

        }
    }
}
