using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class FloweringPlant : IPlant
    {
        private ISoil _soil = null;
        public FloweringPlant(string name, PlantType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; private set; }
        public PlantType Type { get; private set; }
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
            IPlant plant = new HarvestablePlant(Name, Type);
            plant.Plant(_soil);

            return plant;
        }
        
        public IHarvestable Harvest()
        {
            throw new NotImplementedException();
        }
    }
}
