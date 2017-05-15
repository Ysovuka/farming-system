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

        public float PH { get; private set; } = 7.0f;

        public void IncreaseAcidity(float acidicLevel)
        {
            PH -= acidicLevel;
        }

        public void IncreaseAlkalinity(float alkalineLevel)
        {
            PH += alkalineLevel;
        }

        public float SaturationPoint { get; private set; } = 0.0f;

        public void Hydrate(float waterLevel)
        {
            SaturationPoint += waterLevel;
        }

        public void Dehydrate(float waterLevel)
        {
            SaturationPoint -= waterLevel;
        }

        public bool IsOccupied { get { return _plant != null; } }

        public void Plant(IPlant plant)
        {
            _plant = plant;
        }

        public void Uproot()
        {
            _plant = null;
        }
    }
}
