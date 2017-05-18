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
            Name = "Unidentified Seed";
            _seedBank = seedBank;
        }

        public string Name { get; private set; }
        public PlantType Type { get { return PlantType.Unidentified; } }

        public bool IsGrowing { get; private set; }
        public bool IsHarvestable { get { return false; } }

        public float Hydration { get; private set; }
        public float Thirst { get; private set; }
        public bool IsThirsty { get; private set; }
        public void Drink()
        {
            if (Thirst >= 1)
            {
                _soil.Dehydrate(0.1f);
                Thirst -= 0.1f;
            }
        }

        public void Plant(ISoil soil)
        {
            soil.Plant(this);

            _soil = soil;
            IsGrowing = true;
        }

        public void Uproot()
        {
            _soil.Uproot();
            _soil = null;

            IsGrowing = false;
        }

        public IPlant Grow()
        {
            IPlant plant = _seedBank.Identify(this);
            plant.Plant(_soil);
            
            return plant.Grow();
        }

        public IHarvestable Harvest()
        {
            throw new NotImplementedException();
        }
    }
}
