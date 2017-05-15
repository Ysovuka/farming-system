using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface ISoil
    {
        void IncreaseAcidity(float acidicLevel);

        bool IsOccupied { get; }
        float PH { get; }
        void Plant(IPlant seed);
    }
}
