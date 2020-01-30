using Airplanes.Classes;
using Airplanes.Interfaces;
using Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane plane1 = new CargoPlane {Id = 1, Carrying = 100, FuelConsumption = 25, Range = 40 };
            Airplane plane2 = new CargoPlane { Id = 2, Carrying = 140, FuelConsumption = 30, Range = 35 };
            Airplane plane3 = new PassengerPlane { Id = 3, Carrying = 70, FuelConsumption = 20, Range =50 };
            Airplane plane4 = new SportPlane { Id = 4, Carrying = 20, FuelConsumption = 10, Range = 20 };
            Company company = new Company();
            company.RegisterPlainToCompany(plane1);
            company.RegisterPlainToCompany(plane2);
            company.RegisterPlainToCompany(plane3);
            company.RegisterPlainToCompany(plane4);

            company.UnregisterPlane(5);            
            var list = company.SorteByRange();
            foreach (var t in list)
            {
                Console.WriteLine("Plane with Id " + t.Id);
            }

            Console.ReadKey();
        }
    }
}
