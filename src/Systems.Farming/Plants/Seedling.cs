using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class Seedling : IPlant
    {
        private ISoil _soil = null;

        public Seedling(string plantType)
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
            IPlant plant = new VegativePlant(PlantType);
            plant.Plant(_soil);

            return plant;
        }
    }
}
