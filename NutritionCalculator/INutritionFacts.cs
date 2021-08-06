using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator
{
    interface INutritionFacts
    {
        int Calories { get; set; }
        int TotalFat { get; set; }
        int SaturatedFat { get; set; }
        int TransFat { get; set; }
        int Cholesterol { get; set; }
        int Sodium { get; set; }
        int TotalCarbohydrates { get; set; }
        int DietaryFiber { get; set; }
        int Sugars { get; set; }
        int Protein { get; set; }

        int GetCalories();
        int GetTotalFat();
        int GetSaturatedFat();
        int GetTransFat();
        int GetCholesterol();
        int GetSodium();
        int GetTotalCarbohydrates();
        int GetDietaryFiber();
        int GetSugars();
        int GetProtein();




    }


}
