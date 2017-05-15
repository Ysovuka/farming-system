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

        public void IncreaseAcidity(float acidicLevel)
        {
            PH -= acidicLevel;
        }

        public void IncreaseAlkalinity(float alkalineLevel)
        {
            PH += alkalineLevel;
        }

        public bool IsOccupied { get { return _plant != null; } }

        public float PH { get; private set; } = 7.0f;

        public void Plant(IPlant plant)
        {
            _plant = plant;
        }
    }
}
