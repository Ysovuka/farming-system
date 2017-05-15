using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class Fruit : IHarvestable
    {

        public Fruit(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
