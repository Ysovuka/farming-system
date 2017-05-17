using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public sealed class Nutrient : INutrient
    {
        public Nutrient(string nutrientName)
        {
            Random random = new Random();
            Level = (float)random.NextDouble();

            Name = nutrientName;
        }

        public string Name { get; private set; }

        public float Level { get; private set; }

        public void Absorb(float nutrientLevel)
        {
            Level += nutrientLevel;
        }

        public void Sterilize()
        {
            Level = 0;
        }
    }
}
