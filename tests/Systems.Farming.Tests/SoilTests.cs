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
    }
}
