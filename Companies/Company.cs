using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Airplanes.Classes;
using Airplanes.Interfaces;

namespace Companies
{
    public class Company : ICompany
    {
        private List<IAirplane> _planes = new List<IAirplane>();

        public void RegisterPlain(IAirplane airplane)
        {
            _planes.Add(airplane);
        }

        public string UnregisterPlane(int id)
        {
            var entity = _planes.FirstOrDefault(item => item.Id == id);
            if (entity == null)
            {
                return "There is no plain with this Id!";
            }
            else
            {
                _planes.Remove(entity);
                return "Plain successfully unregistred";
            }
        }
        public IAirplane ProvidePlane(int id)
        {
            var entity = _planes.FirstOrDefault(item => item.Id == id);
            return entity;
        }

        public List<IAirplane> GetListOfAirplanes { get { return _planes; } }

        public List<IAirplane> OrderByCarryingWeight()
        {
            return _planes.OrderBy(o => o.Carrying).ToList();
        }

        public List<IAirplane> OrderByFlyingDistance()
        {
            return _planes.OrderBy(o => o.Range).ToList();
        }

        public List<IAirplane> OrderByFuelConsumption()
        {
            return _planes.OrderBy(o => o.FuelConsumption).ToList();
        }

        public List<IAirplane> FiltrationByFlyingDistance(int flyingDistance1, int flyingDistance2)
        {
            List<IAirplane> list = new List<IAirplane>();
            foreach (var item in _planes)
            {
                if ((item.Range >= flyingDistance1) && (item.Range <= flyingDistance2))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<IAirplane> FiltrationByCarryingWeight(int carryingWeight1, int carryingWeight2)
        {
            List<IAirplane> list = new List<IAirplane>();
            foreach (var item in _planes)
            {
                if ((item.Carrying >= carryingWeight1) && (item.Carrying <= carryingWeight2))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<IAirplane> FiltrationByFuelConsumption(int fuelConsumption1, int fuelConsumption2)
        {
            List<IAirplane> list = new List<IAirplane>();
            foreach (var item in _planes)
            {
                if ((item.FuelConsumption >= fuelConsumption1) && (item.FuelConsumption <= fuelConsumption2))
                {
                    list.Add(item);
                }
            }

            return list;
        }
    }

}

