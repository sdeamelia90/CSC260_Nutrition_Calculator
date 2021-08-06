using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NutritionCalculator());

            Ingredient seasonedBeef = new Ingredient(70,4,2,0,15,260,3,2,0,5);
            Ingredient cheddarCheese = new Ingredient(30, 2, 1, 0, 5, 50, 0, 0, 0, 2);
            Ingredient icebergLettuce = new Ingredient(70, 3, 0, 0, 0, 5, 10, 1, 0, 1);
            Ingredient tacoShell = new Ingredient(70, 3, 0, 0, 0, 0, 9, 1, 0, 1);
            Ingredient flourTortilla = new Ingredient(80, 2, 1, 0, 0, 190, 14, 1, 1, 2);

            Beverage BlueFreezeSmall = new Beverage(120,35,30,30);

            Taco CrunchyTaco = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, tacoShell);
            Taco SoftTaco = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, flourTortilla);
        }
    }
}
