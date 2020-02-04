﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Airplanes.Interfaces
{
    public interface IAirplane
    {
        int Id { get; set; }
        int Range { get; set; }
        int Carrying { get; set; }
        int FuelConsumption { get; set; }
        string Fly();
    }
}
