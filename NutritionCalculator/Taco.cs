using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator
{
    public class Taco : INutritionFacts
    {
        List<Ingredient> ingredientList = new List<Ingredient>();

        public Taco()
        {

        }


        public Taco(Ingredient ingred1, Ingredient ingred2, Ingredient ingred3, Ingredient ingred4)
        {
            ingredientList.Add(ingred1);
            ingredientList.Add(ingred2);
            ingredientList.Add(ingred3);
            ingredientList.Add(ingred4);
        }
        public Taco(Ingredient ingred1, Ingredient ingred2, Ingredient ingred3, Ingredient ingred4, Ingredient ingred5, Ingredient ingred6)
        {
            ingredientList.Add(ingred1);
            ingredientList.Add(ingred2);
            ingredientList.Add(ingred3);
            ingredientList.Add(ingred4);
            ingredientList.Add(ingred5);
            ingredientList.Add(ingred6);
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
            foreach (Ingredient ingred in ingredientList) {
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
    }
}
