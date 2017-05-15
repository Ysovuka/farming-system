using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface ISeed : IPlant
    {
        string SeedType { get; }
    }
}
