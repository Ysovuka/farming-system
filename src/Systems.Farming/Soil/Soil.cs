using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Systems.Farming
{
    public class Soil : ISoil
    {
        private IPlant _plant = null;

        public Soil()
        {

        }

        public IList<INutrient> Nutrients { get; } = new List<INutrient>();
        
        public void Absorb(INutrient nutrient)
        {
            INutrient nourishment = Nutrients.FirstOrDefault(n => n.GetType() == nutrient.GetType());

            if (nourishment != null)
            {
                Nutrients.Remove(nourishment);
                nourishment.Absorb(nutrient.Level);

                Nutrients.Add(nourishment);
            }
            else
            {
                Nutrients.Add(nutrient);
            }            
        }

        public float Nourishment(INutrient nutrient)
        {
            return Nutrients.FirstOrDefault(n => n.GetType() == nutrient.GetType())?.Level
                ?? 0;
        }

        public void Sterilize()
        {
            foreach(INutrient nutrient in Nutrients)
            {
                nutrient.Sterilize();
            }

            Nutrients.Clear();
        }


        public float PH { get; private set; } = 7.0f;

        public void IncreaseAcidity(float acidicLevel)
        {
            PH -= acidicLevel;
        }

        public void IncreaseAlkalinity(float alkalineLevel)
        {
            PH += alkalineLevel;
        }


        public float SaturationPoint { get; private set; } = 0.0f;

        public void Hydrate(float waterLevel)
        {
            SaturationPoint += waterLevel;
        }

        public void Dehydrate(float waterLevel)
        {
            SaturationPoint -= waterLevel;
        }


        public bool IsOccupied { get { return _plant != null; } }

        public void Plant(IPlant plant)
        {
            _plant = plant;
        }

        public void Uproot()
        {
            _plant = null;
        }
    }
}
