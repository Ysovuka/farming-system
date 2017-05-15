using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class VegativePlant : IPlant
    {
        private ISoil _soil = null;

        public VegativePlant(string plantType)
        {
            PlantType = plantType;
        }

        public string PlantType { get; private set; }

        public bool IsGrowing { get; private set; }
        public bool IsHarvestable { get { return false; } }

        public void Plant(ISoil soil)
        {
            soil.Plant(this);

            _soil = soil;
            IsGrowing = true;
        }

        public IPlant Grow()
        {
            IPlant plant = new FloweringPlant(PlantType);
            plant.Plant(_soil);

            return plant;
        }

    }
}
