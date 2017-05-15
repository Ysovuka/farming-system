using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public void GrowIdentifiedSeed()
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
            SeedBank seedBank = new SeedBank();
            seedBank.Add("Carrot");
            seedBank.Add("Dragonfruit");
            seedBank.Add("Squash");

            ISoil soil = new Soil();
            IPlant plant = seedBank.Identify(new IdentifiedSeed("Carrot"));
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable

            Debug.WriteLine($"GrowPlantStages: Plant Type: {plant.PlantType}");
            Assert.True(plant.IsHarvestable);
        }

        [Fact]
        public void GrowUnidentifiedSeed()
        {
            SeedBank seedBank = new SeedBank();
            seedBank.Add("Carrot");
            seedBank.Add("Dragonfruit");
            seedBank.Add("Squash");

            ISoil soil = new Soil();
            IPlant plant = new UnidentifiedSeed(seedBank);
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable

            Debug.WriteLine($"GrowUnidentifiedSeed: Plant Type: {plant.PlantType}");
            Assert.True(plant.IsHarvestable);
        }
    }
}
