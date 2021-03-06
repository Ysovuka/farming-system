﻿using System;
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
            IsGrowing = true;
        }

        public void Uproot()
        {
            _soil.Uproot();
            _soil = null;

            IsGrowing = false;
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
