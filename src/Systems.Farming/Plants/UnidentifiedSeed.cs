﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class UnidentifiedSeed : ISeed
    {
        private ISoil _soil = null;

        public UnidentifiedSeed()
        {
            SeedType = "Unidentified Seed";
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
            throw new NotImplementedException();
        }
    }
}
