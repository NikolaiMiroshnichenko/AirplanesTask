using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Airplanes.Classes;
using Airplanes.Interfaces;

namespace Companies
{
    public class Company
    {
        private List<Airplane> _planes = new List<Airplane>();
        public void RegisterPlainToCompany (Airplane airplane)
        {
            _planes.Add(airplane);
        }
        public void UnregisterPlane(int id)
        {
            var entity = _planes.FirstOrDefault(item => item.Id == id);
            if (entity == null) { Console.WriteLine("Plane with input id doesnt exist"); }
        }
        public Airplane ProvidePlane (int id)
        {
            var entity = _planes.FirstOrDefault(item => item.Id == id);
            if (entity == null) { Console.WriteLine("Plane with input id doesnt exist"); }
            return entity;
        }

        public List<Airplane> GetListOfAirplanes()
        {
            return _planes;
        }
        public List<Airplane> SorteByCarrying()
        {
            return _planes.OrderBy(o => o.Carrying).ToList();
        }
        public List<Airplane> SorteByRange()
        {
            return _planes.OrderBy(o => o.Range).ToList();
        }
        public List<Airplane> SorteByFuelConsumption()
        {
            return _planes.OrderBy(o => o.FuelConsumption).ToList();
        }
    }
       
}

