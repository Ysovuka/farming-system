using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class HarvestablePlant : IPlant
    {
        private ISoil _soil = null;

        public HarvestablePlant(string name, PlantType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; private set; }
        public PlantType Type { get; private set; }
        public bool IsGrowing { get; private set; }
        public bool IsHarvestable { get; private set; } = true;

        public float Hydration { get; private set; }
        public float Thirst { get; private set; }
        public bool IsThirsty { get { return Thirst >= 1; } }
        public void Drink()
        {
            if (Thirst >= 1)
            {
                _soil.Dehydrate(0.1f);
                Thirst -= 0.1f;
            }
        }

        public void Plant(ISoil soil)
        {
            soil.Plant(this);

            _soil = soil;
            IsGrowing = false;
        }

        public void Uproot()
        {
            _soil.Uproot();
            _soil = null;

            IsGrowing = false;
        }

        public IPlant Grow()
        {
            if (IsHarvestable)
                return new DeadPlant(Name, Type);

            return new VegativePlant(Name, Type);
        }

        public IHarvestable Harvest()
        {
            IsHarvestable = false;

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
