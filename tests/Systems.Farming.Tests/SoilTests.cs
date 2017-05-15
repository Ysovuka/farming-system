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

            Assert.Equal(7.5f, soil.PH);
        }
    }
}
