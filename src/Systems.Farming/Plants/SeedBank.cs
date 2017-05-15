using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class SeedBank
    {
        public IList<ISeed> _seeds = new List<ISeed>();

        public SeedBank()
        {

        }

        public void Add(string seedType)
        {
            _seeds.Add(new IdentifiedSeed(seedType));
        }

        public ISeed Identify(ISeed seed)
        {
            if (seed is IdentifiedSeed) return seed;

            Random random = new Random();            
            return _seeds[random.Next(_seeds.Count - 1)];
        }
    }
}
