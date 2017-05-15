using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface ISoil
    {
        void IncreaseAcidity(float acidicLevel);
        void IncreaseAlkalinity(float alkalineLevel);

        bool IsOccupied { get; }
        float PH { get; }
        void Plant(IPlant plant);
        void Uproot();
    }
}
