using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Systems.Farming.Tests
{
    public class SoilTests
    {
        [Fact]
        public void PlantSeedInSoil()
        {
            ISoil soil = new Soil();
            ISeed seed = new IdentifiedSeed("Carrot");
            soil.Plant(seed);

            Assert.True(soil.IsOccupied);
        }

        [Fact]
        public void GrowPlantInSoil()
        {
            ISoil soil = new Soil();
            ISeed seed = new IdentifiedSeed("Carrot");
            soil.Plant(seed);
            soil.Grow();

            Assert.True(soil.IsGrowing);
        }
    }
}
