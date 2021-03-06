﻿using Airplanes.Interfaces;

namespace Airplanes.Classes
{
    public class CargoPlane: IAirplane
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public string Fly()
        {
            return "Flying like a cargo plane";
        }
    }
}
