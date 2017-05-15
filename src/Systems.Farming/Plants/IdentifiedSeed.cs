using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class IdentifiedSeed : ISeed
    {
        private ISoil _soil = null;
        public IdentifiedSeed(string seedType)
        {
            SeedType = seedType;
        }

        public string PlantType { get { return $"{SeedType} Seed"; } }
        public string SeedType { get; private set; }

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
            IPlant plant = new Seedling(SeedType);
            plant.Plant(_soil);

            return plant;
        }
    }
}
