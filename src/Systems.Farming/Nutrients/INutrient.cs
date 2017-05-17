using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface INutrient
    {
        string Name { get; }
        float Level { get; }

        void Absorb(float nutrientLevel);
        void Sterilize();
    }
}
