using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator
{
    public class Ingredient: INutritionFacts
    {
        public Ingredient(int calories, int totalFat, int saturatedFat, int transFat, int cholesterol, int sodium, int totalCarbohydrates, int dietaryFiber, int sugars, int protein)
        {
            this.Calories = calories;
            this.TotalFat = totalFat;
            this.SaturatedFat = saturatedFat;
            this.Cholesterol = cholesterol;
            this.Sodium = sodium;
            this.TotalCarbohydrates = totalCarbohydrates;
            this.DietaryFiber = dietaryFiber;
            this.Sugars = sugars;
            this.Protein = protein;
        }

        #region MacroProperties
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
        #endregion

        #region ReturnMacronutrients
        public int GetCalories()
        {
            return this.Calories;
        }
        public int GetTotalFat()
        {
            return this.TotalFat;

        }
        public int GetSaturatedFat()
        {
            return this.SaturatedFat;

        }
        public int GetTransFat()
        {
            return this.TransFat;
        }
        public int GetCholesterol()
        {
            return this.Cholesterol;
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
            return this.Protein;
        }
        #endregion
    }
}
