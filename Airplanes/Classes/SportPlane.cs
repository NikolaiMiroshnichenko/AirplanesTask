using System;
using System.Collections.Generic;
using System.Text;
using Airplanes.Interfaces;

namespace Airplanes.Classes
{
    public class SportPlane: IAirplane
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public void Fly()
        {
            Console.WriteLine("Flying like a sport plane");
        }
        public void MakeAStunt()
        {
            Console.WriteLine("Making unbelieveble stunt");
        }
    }
}
