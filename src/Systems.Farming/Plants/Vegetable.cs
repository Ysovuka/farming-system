using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class Vegetable : IHarvestable
    {

        public Vegetable(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
