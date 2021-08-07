using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator
{
    class Veggie: INutritionFacts
    {
        //implements list of Ingredient objects
        List<Ingredient> ingredientList = new List<Ingredient>();

        #region Constructors
        public Veggie(Ingredient ingred1)
        {
            ingredientList.Add(ingred1);
        }
        public Veggie(Ingredient ingred1, Ingredient ingred2)
        {
            ingredientList.Add(ingred1);
            ingredientList.Add(ingred2);
        }
        #endregion

        #region properties
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

        #region MacroMethods
        public int GetCalories()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                Calories = Calories + ingred.GetCalories();
            }
            return Calories;
        }

        public int GetTotalFat()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                TotalFat = TotalFat + ingred.GetTotalFat();
            }
            return TotalFat;
        }

        public int GetSaturatedFat()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                SaturatedFat = SaturatedFat + ingred.GetSaturatedFat();
            }
            return SaturatedFat;
        }
        public int GetTransFat()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                TransFat = TransFat + ingred.GetTransFat();
            }
            return TransFat;
        }
        public int GetCholesterol()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                Cholesterol = Cholesterol + ingred.GetCholesterol();
            }
            return Cholesterol;
        }
        public int GetSodium()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                Sodium = Sodium + ingred.GetSodium();
            }
            return Sodium;
        }
        public int GetTotalCarbohydrates()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                TotalCarbohydrates = TotalCarbohydrates + ingred.GetTotalCarbohydrates();
            }
            return TotalCarbohydrates;
        }
        public int GetDietaryFiber()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                DietaryFiber = DietaryFiber + ingred.GetDietaryFiber();
            }
            return DietaryFiber;
        }
        public int GetSugars()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                Sugars = Sugars + ingred.GetSugars();
            }
            return Sugars;
        }
        public int GetProtein()
        {
            foreach (Ingredient ingred in ingredientList)
            {
                Protein = Protein + ingred.GetProtein();
            }
            return Protein;
        }
        #endregion
    }
}
