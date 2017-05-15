using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace Systems.Farming.Tests
{
    public class PlantTests
    {
        [Fact]
        public void PlantSeedInSoil()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("Carrot", PlantType.Vegetable);
            plant.Plant(soil);

            Assert.True(soil.IsOccupied);
        }

        [Fact]
        public void GrowIdentifiedSeed()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("Carrot", PlantType.Vegetable);
            plant.Plant(soil);
            plant = plant.Grow();

            Assert.True(plant.IsGrowing);
        }

        [Fact]
        public void GrowPlantStages()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("Carrot", PlantType.Vegetable);
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable

            Debug.WriteLine($"GrowPlantStages: Plant Type: {plant.Name}");
            Assert.True(plant.IsHarvestable);
        }

        [Fact]
        public void GrowUnidentifiedSeed()
        {
            SeedBank seedBank = new SeedBank();
            seedBank.Add("Carrot", PlantType.Vegetable);
            seedBank.Add("Dragonfruit", PlantType.Fruit);
            seedBank.Add("Squash", PlantType.Vegetable);

            ISoil soil = new Soil();
            IPlant plant = new UnidentifiedSeed(seedBank);
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable

            Debug.WriteLine($"GrowUnidentifiedSeed: Plant Type: {plant.Name}");
            Assert.True(plant.IsHarvestable);
        }

        [Fact]
        public void HarvestPlant()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("Carrot", PlantType.Vegetable);
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable

            IHarvestable product = plant.Harvest();

            Assert.Equal(typeof(Vegetable), product.GetType());
        }

        [Fact]
        public void PlantDies()
        {
            ISoil soil = new Soil();
            IPlant plant = new IdentifiedSeed("Carrot", PlantType.Vegetable);
            plant.Plant(soil);
            plant = plant.Grow(); // Seedling
            plant = plant.Grow(); // Vegetative
            plant = plant.Grow(); // Flowering
            plant = plant.Grow(); // Harvestable
            plant = plant.Grow(); // Dead

            Assert.Equal(typeof(DeadPlant), plant.GetType());
        }
    }
}
