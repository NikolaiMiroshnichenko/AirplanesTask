using Airplanes.Interfaces;

namespace Airplanes.Classes
{
    public class SportPlane: IAirplane, ISportPlane
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public string  Fly()
        {
            return "Flying like a sport plane";
        }
        public string MakeAStunt()
        {
            return "Making unbelieveble stunt";
        }
    }
}
