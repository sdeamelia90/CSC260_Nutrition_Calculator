using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator
{
    public class Ingredient: INutritionFacts
    {
        public Ingredient(int calories, int totalFat, int saturatedFat, int transFat, int cholestrol, int sodium, int totalCarbohydrates, int dietaryFiber, int sugars, int protein)
        {
            this.calories = Calories;
            this.totalFat = TotalFat;
            this.saturatedFat = SaturatedFat;
            this.cholesterol = Cholesterol;
            this.sodium = Sodium;
            this.totalCarbohydrates = TotalCarbohydrates;
            this.dietaryFiber = DietaryFiber;
            this.sugars = Sugars;
            this.protein = Protein;
        }

        public Ingredient()
        {

        }

        int calories;
        int totalFat;
        int saturatedFat;
        int transFat;
        int cholesterol;
        int sodium;
        int totalCarbohydrates;
        int dietaryFiber;
        int sugars;
        int protein;

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
            return this.calories;
        }
        public int GetTotalFat()
        {
            return this.totalFat;

        }
        public int GetSaturatedFat()
        {
            return this.saturatedFat;

        }
        public int GetTransFat()
        {
            return this.transFat;
        }
        public int GetCholesterol()
        {
            return this.cholesterol;
        }
        public int GetSodium()
        {
            return this.sodium;
        }
        public int GetTotalCarbohydrates()
        {
            return this.totalCarbohydrates;
        }
        public int GetDietaryFiber()
        {
            return this.dietaryFiber;
        }
        public int GetSugars()
        {
            return this.sugars;
        }
        public int GetProtein()
        {
            return this.protein;
        }
        #endregion
    }
}
