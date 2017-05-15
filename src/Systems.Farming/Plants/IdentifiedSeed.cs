using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class IdentifiedSeed : ISeed
    {
        public IdentifiedSeed(string seedType)
        {
            SeedType = seedType;
        }

        public string SeedType { get; private set; }
    }
}
