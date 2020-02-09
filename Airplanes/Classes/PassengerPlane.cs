using Airplanes.Interfaces;

namespace Airplanes.Classes
{
    public class PassengerPlane : IAirplane
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public int PassengerCarrying { get; set; } 
        public string Fly()
        {
            return "Flying like a passenger plane";
        }
    }
}
