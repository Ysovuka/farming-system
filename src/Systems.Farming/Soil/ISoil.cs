using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface ISoil
    {
        bool IsGrowing { get; }
        bool IsOccupied { get; }

        void Grow();
        void Plant(ISeed seed);
    }
}
