using System;
using System.Collections.Generic;
using System.Text;
using Airplanes.Classes;
using Airplanes.AbstractClasses;

namespace Companies
{
    public class Company
    {
        private List<Airplane> _planes;
        public void RegisterPlainToCompany (Airplane airplane)
        {
            _planes.Add(airplane);
        }
        public void UnregisterPlane(int id)
        {
            
        }
        public Airplane ProvidePlane (int id)
        {

        }
        public List <Airplane> GetListOfAirplanes ()
        {

        }
        public List<Airplane> SorteByCarrying()
        {

        }
        public List<Airplane> SorteByRange()
        {

        }
        public List<Airplane> SorteByFuelConsumption()
        {

        }
    }
}
