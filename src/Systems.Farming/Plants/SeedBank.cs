using System;
using System.Collections.Generic;

namespace Systems.Farming
{
    public class SeedBank
    {
        public IList<ISeed> _seeds = new List<ISeed>();

        public SeedBank()
        {

        }

        public void Add(string name, PlantType type)
        {
            _seeds.Add(new IdentifiedSeed(name, type));
        }

        public ISeed Identify(ISeed seed)
        {
            if (seed is IdentifiedSeed) return seed;
            

            Random random = new Random((int)DateTime.UtcNow.Ticks);            
            return _seeds[random.Next(_seeds.Count - 1)];
        }
    }
}
