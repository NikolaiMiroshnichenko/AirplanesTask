using Airplanes.Interfaces;
using System.Collections.Generic;

namespace Companies
{
    public interface ICompany
    {
        void RegisterPlain(IAirplane airplane);

        string UnregisterPlane(int id);

        IAirplane ProvidePlane(int id);

        List<IAirplane> GetListOfAirplanes { get; }

        List<IAirplane> OrderByCarryingWeight();

        List<IAirplane> OrderByFlyingDistance();

        List<IAirplane> OrderByFuelConsumption();

        List<IAirplane> FiltrationByFlyingDistance(int distanceMin, int distanceMax);

        List<IAirplane> FiltrationByCarryingWeight(int crryingWeightMin, int caryingWeightMax);

        List<IAirplane> FiltrationByFuelConsumption(int fuelConsumptionMin, int fuelConsumptionMax);
    }
}
