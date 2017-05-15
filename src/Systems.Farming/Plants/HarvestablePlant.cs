using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class HarvestablePlant : IPlant
    {
        private ISoil _soil = null;

        public HarvestablePlant(string plantType)
        {
            PlantType = plantType;
        }

        public string PlantType { get; private set; }

        public bool IsGrowing { get; private set; }
        public bool IsHarvestable { get { return true; } }

        public void Plant(ISoil soil)
        {
            soil.Plant(this);

            _soil = soil;
            IsGrowing = false;
        }

        public IPlant Grow()
        {
            throw new NotImplementedException();
        }
    }
}
