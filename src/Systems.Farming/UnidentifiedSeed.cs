using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class UnidentifiedSeed : ISeed
    {
        public UnidentifiedSeed()
        {
            SeedType = "Unidentified Seed";
        }

        public string SeedType { get; private set; }
    }
}
