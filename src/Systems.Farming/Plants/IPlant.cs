using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface IPlant
    {
        bool IsGrowing { get; }
        bool IsHarvestable { get; }
        string PlantType { get; }

        void Plant(ISoil soil);
        IPlant Grow();
    }
}
