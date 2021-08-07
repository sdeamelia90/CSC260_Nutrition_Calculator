using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator
{
    class Beverage: INutritionFacts
    {
        public int TOTALFAT = 0;
        public int SATURATEDFAT = 0;
        public int TRANSFAT = 0;
        public int CHOLESTEROL = 0;
        public int DIETARYFIBER = 0;
        public int PROTEIN = 0;
        
        public Beverage(int calories, int sodium, int totalCarbohydrates, int sugars)
        {
            this.Calories = calories;
            this.Sodium = sodium;
            this.TotalCarbohydrates = totalCarbohydrates;
            this.Sugars = sugars;
        }

        public int Calories { get; set; }
        public int TotalFat { get; set; }
        public int SaturatedFat { get; set; }
        public int TransFat { get; set; }
        public int Cholesterol { get; set; }
        public int Sodium { get; set; }
        public int TotalCarbohydrates { get; set; }
        public int DietaryFiber { get; set; }
        public int Sugars { get; set; }
        public int Protein { get; set; }

        public int GetCalories() {
            return this.Calories;
        }
        public int GetTotalFat()
        {
            return this.TOTALFAT;
        }
        public int GetSaturatedFat()
        {
            return this.SATURATEDFAT;
        }
        public int GetTransFat()
        {
            return this.TRANSFAT;
        }
        public int GetCholesterol()
        {
            return this.CHOLESTEROL;
        }
        public int GetSodium()
        {
            return this.Sodium;
        }
        public int GetTotalCarbohydrates()
        {
            return this.TotalCarbohydrates;
        }
        public int GetDietaryFiber()
        {
            return this.DietaryFiber;
        }
        public int GetSugars()
        {
            return this.Sugars;
        }
        public int GetProtein()
        {
            return this.PROTEIN;
        }
    }


}
