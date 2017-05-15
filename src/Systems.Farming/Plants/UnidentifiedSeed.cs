using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class UnidentifiedSeed : ISeed
    {
        private ISoil _soil = null;
        private SeedBank _seedBank = null;

        public UnidentifiedSeed(SeedBank seedBank)
        {
            SeedType = "Unidentified Seed";
            _seedBank = seedBank;
        }

        public string PlantType { get { return SeedType; } }
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
            IPlant plant = _seedBank.Identify(this);
            plant.Plant(_soil);
            
            return plant.Grow();
        }
    }
}
