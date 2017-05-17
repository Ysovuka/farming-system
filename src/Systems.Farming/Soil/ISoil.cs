using System;
using System.Collections.Generic;
using System.Text;

namespace Systems.Farming
{
    public interface ISoil
    {
        ICollection<INutrient> Nutrients { get; }
        void Sterilize();

        float PH { get; }
        void IncreaseAcidity(float acidicLevel);
        void IncreaseAlkalinity(float alkalineLevel);

        void Hydrate(float waterLevel);
        void Dehydrate(float waterLevel);
        float SaturationPoint { get; }

        bool IsOccupied { get; }
        void Plant(IPlant plant);
        void Uproot();
    }
}
