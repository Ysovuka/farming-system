using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface ISoil
    {
        bool IsOccupied { get; }

        void Plant(ISeed seed);
    }
}
