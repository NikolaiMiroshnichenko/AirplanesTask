using Airplanes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Companies
{
    public interface ICompany
    {
        void RegisterPlainToCompany(IAirplane airplane);
        void UnregisterPlane(int id);
        IAirplane ProvidePlane(int id);
        List<IAirplane> GetListOfAirplanes();
        List<IAirplane> OrderByCarrying();
        List<IAirplane> OrderByRange();
        List<IAirplane> OrderByFuelConsumption();
        List<IAirplane> FiltrationByRange(int r1, int r2);
        List<IAirplane> FiltrationByCarrying(int c1, int c2);
        List<IAirplane> FiltrationByFuelConsumption(int fc1, int fc2);
    }
}
