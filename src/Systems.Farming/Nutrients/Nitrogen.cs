using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public class Nitrogen : INutrient
    {
        public Nitrogen()
        {
            Random random = new Random();
            Level = (float)random.NextDouble();
        }

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
