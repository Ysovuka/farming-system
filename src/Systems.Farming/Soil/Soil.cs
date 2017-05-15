using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class Soil : ISoil
    {
        private IPlant _plant = null;

        public Soil()
        {

        }

        public bool IsOccupied { get { return _plant != null; } }

        public void Plant(IPlant plant)
        {
            _plant = plant;
        }
    }
}
