using System;
using System.Collections.Generic;
using System.Text;

namespace Airplanes.AbstractClasses
{
    public abstract class Airplane
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public abstract void Fly();
    }
}
