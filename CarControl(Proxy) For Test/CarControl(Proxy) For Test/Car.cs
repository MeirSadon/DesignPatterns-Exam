using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarControl_Proxy__For_Test
{
    class Car : IController, IGasAndLocationService
    {
        public void ShowFuel()
        {
            Console.WriteLine($"Your Fuel Quantity On: {new Random().Next(250)}.");
        }

        public void ShowLocation()
        {
            Console.WriteLine($"Your Location Is: {new Random().Next(250)} On {new Random().Next(250)}.");
        }

        public void SlowDown()
        {
            Console.WriteLine("Brake Pressing");
        }

        public void StartDriving()
        {
            Console.WriteLine("Insert Into First Gear");
        }

        public void StopDriving()
        {
            Console.WriteLine("Brake Pressure Until Stopping");
        }

        public void Turbo()
        {
            Console.WriteLine("Gasssssssssss");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Signaling To The Left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Signaling To The Right.");
        }
    }
}
