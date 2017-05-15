using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface IPlant
    {
        bool IsGrowing { get; }
        bool IsHarvestable { get; }
        string Name { get; }
        PlantType Type { get; }

        void Plant(ISoil soil);
        void Uproot();
        IPlant Grow();
        IHarvestable Harvest();
    }
}
