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
            IPlant plant = new IdentifiedSeed("Carrot");
            plant.Plant(soil);

            Assert.True(soil.IsOccupied);
        }

        [Fact]
        public void GrowPlantInSoil()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("Carrot");
            plant.Plant(soil);
            plant = plant.Grow();

            Assert.True(plant.IsGrowing);
        }

        [Fact]
        public void GrowPlantStages()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("carrot");
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable

            Assert.True(plant.IsHarvestable);
        }
    }
}
