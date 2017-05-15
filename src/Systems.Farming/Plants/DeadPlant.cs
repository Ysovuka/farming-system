using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class DeadPlant : IPlant
    {
        private ISoil _soil = null;

        public DeadPlant(string name, PlantType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; private set; }
        public PlantType Type { get; private set; }
        public bool IsGrowing { get; private set; }
        public bool IsHarvestable { get { return true; } }

        public void Plant(ISoil soil)
        {
            soil.Plant(this);

            _soil = soil;
            IsGrowing = false;
        }

        public IPlant Grow()
        {
            throw new NotImplementedException();
        }

        public IHarvestable Harvest()
        {
            switch (Type)
            {
                case PlantType.Unidentified:
                    return null;

                case PlantType.Fruit:
                    return new Fruit(Name);

                case PlantType.Vegetable:
                default:
                    return new Vegetable(Name);
            }
        }
    }
}
