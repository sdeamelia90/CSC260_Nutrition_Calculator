using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalculator
{

    public partial class NutritionCalculator : Form
    {
        public NutritionCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        Ingredient seasonedBeef = new Ingredient(70, 4, 2, 0, 15, 260, 3, 2, 0, 5);
        Ingredient cheddarCheese = new Ingredient(30, 2, 1, 0, 5, 50, 0, 0, 0, 2);
        Ingredient icebergLettuce = new Ingredient(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Ingredient tacoShell = new Ingredient(70, 3, 0, 0, 0, 0, 9, 1, 0, 1);
        Ingredient flourTortilla = new Ingredient(80, 2, 1, 0, 0, 190, 14, 1, 1, 2);
        Ingredient tomato = new Ingredient(0, 0, 0, 0, 0, 0, 0, 1, 0, 0);
        Ingredient sourCream = new Ingredient(20, 2, 1, 0, 5, 20, 2, 0, 1, 0);


        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectType.Items.Clear();
            if (SelectCategory.SelectedItem.ToString() == "Taco")
            {
                SelectType.Items.Add("Soft Taco");
                SelectType.Items.Add("Soft Taco Supreme");
                SelectType.Items.Add("Crunchy Taco");
                SelectType.Items.Add("Crunchy Taco Supreme");

            }
            else if (SelectCategory.SelectedItem.ToString() == "Beverage")
            {
                SelectType.Items.Add("BlueFreeze160z");
                SelectType.Items.Add("BlueFreeze20oz");
            }

            }


        public void SelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectType.SelectedItem.ToString() == "Soft Taco")
            {
                Taco SoftTaco = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, flourTortilla);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", SoftTaco.GetCalories(), SoftTaco.GetTotalFat(), SoftTaco.GetSaturatedFat(), SoftTaco.GetTransFat(),
                    SoftTaco.GetCholesterol(), SoftTaco.GetSodium(), SoftTaco.GetTotalCarbohydrates(), SoftTaco.GetDietaryFiber(), SoftTaco.GetSugars(), SoftTaco.GetProtein());
            }
            else if (SelectType.SelectedItem.ToString() == "Crunchy Taco")
            {
                Taco CrunchyTaco = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, tacoShell);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", CrunchyTaco.GetCalories(), CrunchyTaco.GetTotalFat(), CrunchyTaco.GetSaturatedFat(), CrunchyTaco.GetTransFat(),
                    CrunchyTaco.GetCholesterol(), CrunchyTaco.GetSodium(), CrunchyTaco.GetTotalCarbohydrates(), CrunchyTaco.GetDietaryFiber(), CrunchyTaco.GetSugars(), CrunchyTaco.GetProtein());
            }
            else if (SelectType.SelectedItem.ToString() == "Soft Taco Supreme")
            {
                Taco SoftTacoSupreme = new Taco(seasonedBeef, seasonedBeef, seasonedBeef, seasonedBeef, tomato, sourCream);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", SoftTacoSupreme.GetCalories(), SoftTacoSupreme.GetTotalFat(), SoftTacoSupreme.GetSaturatedFat(), SoftTacoSupreme.GetTransFat(),
                    SoftTacoSupreme.GetCholesterol(), SoftTacoSupreme.GetSodium(), SoftTacoSupreme.GetTotalCarbohydrates(), SoftTacoSupreme.GetDietaryFiber(), SoftTacoSupreme.GetSugars(), SoftTacoSupreme.GetProtein());
            }
            else if (SelectType.SelectedItem.ToString() == "Crunchy Taco Supreme")
            {
                Taco CrunchyTacoSupreme = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, flourTortilla, tomato, sourCream);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", CrunchyTacoSupreme.GetCalories(), CrunchyTacoSupreme.GetTotalFat(), CrunchyTacoSupreme.GetSaturatedFat(), CrunchyTacoSupreme.GetTransFat(),
                    CrunchyTacoSupreme.GetCholesterol(), CrunchyTacoSupreme.GetSodium(), CrunchyTacoSupreme.GetTotalCarbohydrates(), CrunchyTacoSupreme.GetDietaryFiber(), CrunchyTacoSupreme.GetSugars(), CrunchyTacoSupreme.GetProtein());
            }
            else if (SelectType.SelectedItem.ToString() == "BlueFreeze16oz")
            {
                Beverage BlueFreeze16oz = new Beverage(120, 35, 30, 30);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", BlueFreeze16oz.GetCalories(), BlueFreeze16oz.GetTotalFat(), BlueFreeze16oz.GetSaturatedFat(), BlueFreeze16oz.GetTransFat(),
                    BlueFreeze16oz.GetCholesterol(), BlueFreeze16oz.GetSodium(), BlueFreeze16oz.GetTotalCarbohydrates(), BlueFreeze16oz.GetDietaryFiber(), BlueFreeze16oz.GetSugars(), BlueFreeze16oz.GetProtein());

            }
        }

        public void displayNutritionFacts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
