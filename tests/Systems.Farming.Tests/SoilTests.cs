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

        [Fact]
        public void SterlizeSoil()
        {
            ISoil soil = new Soil();
            soil.Sterilize();

            Assert.Equal(0, soil.Nutrients.Count);
        }

        [Fact]
        public void ImproveNutrientInSoil()
        {
            ISoil soil = new Soil();
            INutrient nitrogen = new Nutrient("Nitrogen");
            soil.Absorb(nitrogen);

            Assert.True(soil.Nourishment(nitrogen) > 0);

            soil.Sterilize();
            INutrient phosphorus = new Nutrient("Phosphorus");
            soil.Absorb(phosphorus);

            Assert.True(soil.Nourishment(nitrogen) == 0);
        }
    }
}
