using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Systems.Farming.Tests
{
    public class SoilTests
    {
        [Fact]
        public void IncreaseAcidityLevels()
        {
            ISoil soil = new Soil();
            soil.IncreaseAcidity(0.5f);

            Assert.Equal(6.5f, soil.PH);
        }

        [Fact]
        public void IncreaseAlkalineLevels()
        {
            ISoil soil = new Soil();
            soil.IncreaseAlkalinity(0.5f);

            Assert.Equal(7.5f, soil.PH);
        }

        [Fact]
        public void HydrateSoil()
        {
            ISoil soil = new Soil();
            soil.Hydrate(1.0f);

            Assert.Equal(1.0f, soil.SaturationPoint);
        }

        [Fact]
        public void DehydrateSoil()
        {
            ISoil soil = new Soil();
            soil.Hydrate(10.0f);
            soil.Dehydrate(1.0f);

            Assert.Equal(9.0f, soil.SaturationPoint);
        }
    }
}
