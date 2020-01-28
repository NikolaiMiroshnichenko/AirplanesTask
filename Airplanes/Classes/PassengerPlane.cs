using System;
using System.Collections.Generic;
using System.Text;

namespace Airplanes.Classes
{
    public class PassengerPlane
    {
        public int PassengerCarrying { get; set; } 
        public void Fly()
        {
            Console.WriteLine("Flying like a passenger plane");
        }
    }
}
