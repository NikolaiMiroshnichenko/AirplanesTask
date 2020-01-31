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
        public void RegisterPlainToCompany(IAirplane airplane)
        {
            _planes.Add(airplane);
        }
        public void UnregisterPlane(int id)
        {
            var entity = _planes.FirstOrDefault(item => item.Id == id);
            if (entity == null) { Console.WriteLine("Plane with input id doesnt exist"); }
        }
        public IAirplane ProvidePlane(int id)
        {
            var entity = _planes.FirstOrDefault(item => item.Id == id);
            if (entity == null) { Console.WriteLine("Plane with input id doesnt exist"); }
            return entity;
        }

        public List<IAirplane> GetListOfAirplanes()
        {
            return _planes;
        }
        public List<IAirplane> OrderByCarrying()
        {
            return _planes.OrderBy(o => o.Carrying).ToList();
        }
        public List<IAirplane> OrderByRange()
        {
            return _planes.OrderBy(o => o.Range).ToList();
        }
        public List<IAirplane> OrderByFuelConsumption()
        {
            return _planes.OrderBy(o => o.FuelConsumption).ToList();
        }
        public List<IAirplane> FiltrationByRange(int r1, int r2)
        {
            List<IAirplane> list = new List<IAirplane>();
            foreach (var item in _planes)
            {
                if (item == null)
                {
                    Console.WriteLine("There is not planes!");
                }
                else
                {
                    if ((item.Range >= r1) && (item.Range <= r2))
                    {
                        list.Add(item);
                    }
                }
            }
            return list;
        }
        public List<IAirplane> FiltrationByCarrying(int c1, int c2)
        {
            List<IAirplane> list = new List<IAirplane>();
            foreach (var item in _planes)
            {
                if (item == null)
                {
                    Console.WriteLine("There is not planes!");
                }
                else
                {
                    if ((item.Carrying >= c1) && (item.Carrying <= c2))
                    {
                        list.Add(item);
                    }
                }
            }
            return list;
        }
        public List<IAirplane> FiltrationByFuelConsumption(int fc1, int fc2)
        {
            List<IAirplane> list = new List<IAirplane>();
            foreach (var item in _planes)
            {
                if (item == null)
                {
                    Console.WriteLine("There is not planes!");
                }
                else
                {
                    if ((item.FuelConsumption >= fc1) && (item.FuelConsumption <= fc2))
                    {
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }

}

