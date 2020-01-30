using System;
using System.Collections.Generic;
using System.Text;
using Airplanes.Interfaces;

namespace Airplanes.Classes
{
    public class PassengerPlane : Airplane
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public int PassengerCarrying { get; set; } 
        public void Fly()
        {
            Console.WriteLine("Flying like a passenger plane");
        }
    }
}
