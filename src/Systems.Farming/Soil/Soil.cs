using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class Soil : ISoil
    {
        private ISeed _plant = null;

        public Soil()
        {

        }
        
        public bool IsGrowing { get; private set; }
        public bool IsOccupied { get { return _plant != null; } }

        public void Plant(ISeed seed)
        {
            _plant = seed;
        }

        public void Grow()
        {
            IsGrowing = true;
        }
    }
}
