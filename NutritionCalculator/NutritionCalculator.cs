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

        #region Initilize Ingredient Objects
        Ingredient seasonedBeef = new Ingredient(70, 4, 2, 0, 15, 260, 3, 2, 0, 5);
        Ingredient cheddarCheese = new Ingredient(30, 2, 1, 0, 5, 50, 0, 0, 0, 2);
        Ingredient icebergLettuce = new Ingredient(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Ingredient tacoShell = new Ingredient(70, 3, 0, 0, 0, 0, 9, 1, 0, 1);
        Ingredient flourTortilla = new Ingredient(80, 2, 1, 0, 0, 190, 14, 1, 1, 2);
        Ingredient tomato = new Ingredient(0, 0, 0, 0, 0, 0, 0, 1, 0, 0);
        Ingredient sourCream = new Ingredient(20, 2, 1, 0, 5, 20, 2, 0, 1, 0);
        Ingredient blackBeans = new Ingredient(50, 1, 0, 0, 0, 135, 8, 3, 0, 2);
        #endregion

        //Fills the second combobox depending on user selection
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
                SelectType.Items.Add("BlueFreeze16oz");
                SelectType.Items.Add("BlueFreeze20oz");
            }
            else if (SelectCategory.SelectedItem.ToString() == "Veggie")
            {
                SelectType.Items.Add("Black Beans");
                SelectType.Items.Add("Cheesy Rollup");
            }
            SelectType.Enabled = true;
            }

        #region Form Methods
        //Fills the NutritionalFact textbox based on user input
        private void SelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectType.SelectedItem.ToString() == "Soft Taco")
            {
                Taco SoftTaco = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, flourTortilla);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", SoftTaco.GetCalories() * Quantity.Value, SoftTaco.GetTotalFat() * Quantity.Value, SoftTaco.GetSaturatedFat() * Quantity.Value,
                    SoftTaco.GetTransFat() * Quantity.Value, SoftTaco.GetCholesterol() * Quantity.Value, SoftTaco.GetSodium() * Quantity.Value, SoftTaco.GetTotalCarbohydrates() * Quantity.Value,
                    SoftTaco.GetDietaryFiber() * Quantity.Value, SoftTaco.GetSugars() * Quantity.Value, SoftTaco.GetProtein() * Quantity.Value);
            }
            else if (SelectType.SelectedItem.ToString() == "Crunchy Taco")
            {
                Taco CrunchyTaco = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, tacoShell);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", CrunchyTaco.GetCalories() * Quantity.Value, CrunchyTaco.GetTotalFat() * Quantity.Value, CrunchyTaco.GetSaturatedFat() * Quantity.Value,
                    CrunchyTaco.GetTransFat() * Quantity.Value, CrunchyTaco.GetCholesterol() * Quantity.Value, CrunchyTaco.GetSodium() * Quantity.Value, CrunchyTaco.GetTotalCarbohydrates() * Quantity.Value,
                    CrunchyTaco.GetDietaryFiber() * Quantity.Value, CrunchyTaco.GetSugars() * Quantity.Value, CrunchyTaco.GetProtein() * Quantity.Value);
            }
            else if (SelectType.SelectedItem.ToString() == "Soft Taco Supreme")
            {
                Taco SoftTacoSupreme = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, flourTortilla, tomato, sourCream);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", SoftTacoSupreme.GetCalories() * Quantity.Value, SoftTacoSupreme.GetTotalFat() * Quantity.Value, SoftTacoSupreme.GetSaturatedFat() * Quantity.Value,
                    SoftTacoSupreme.GetTransFat() * Quantity.Value, SoftTacoSupreme.GetCholesterol() * Quantity.Value, SoftTacoSupreme.GetSodium() * Quantity.Value, SoftTacoSupreme.GetTotalCarbohydrates(),
                    SoftTacoSupreme.GetDietaryFiber() * Quantity.Value, SoftTacoSupreme.GetSugars() * Quantity.Value, SoftTacoSupreme.GetProtein() * Quantity.Value);
            }
            else if (SelectType.SelectedItem.ToString() == "Crunchy Taco Supreme")
            {
                Taco CrunchyTacoSupreme = new Taco(seasonedBeef, cheddarCheese, icebergLettuce, flourTortilla, tomato, sourCream);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", CrunchyTacoSupreme.GetCalories() * Quantity.Value, CrunchyTacoSupreme.GetTotalFat() * Quantity.Value, CrunchyTacoSupreme.GetSaturatedFat() * Quantity.Value,
                    CrunchyTacoSupreme.GetTransFat() * Quantity.Value, CrunchyTacoSupreme.GetCholesterol() * Quantity.Value, CrunchyTacoSupreme.GetSodium() * Quantity.Value,
                    CrunchyTacoSupreme.GetTotalCarbohydrates() * Quantity.Value, CrunchyTacoSupreme.GetDietaryFiber() * Quantity.Value, CrunchyTacoSupreme.GetSugars() * Quantity.Value, CrunchyTacoSupreme.GetProtein() * Quantity.Value);
            }
            else if (SelectType.SelectedItem.ToString() == "BlueFreeze16oz")
            {
                Beverage BlueFreeze16oz = new Beverage(120, 35, 30, 30);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", BlueFreeze16oz.GetCalories() * Quantity.Value, BlueFreeze16oz.GetTotalFat() * Quantity.Value, BlueFreeze16oz.GetSaturatedFat() * Quantity.Value,
                    BlueFreeze16oz.GetTransFat() * Quantity.Value, BlueFreeze16oz.GetCholesterol() * Quantity.Value, BlueFreeze16oz.GetSodium() * Quantity.Value,
                    BlueFreeze16oz.GetTotalCarbohydrates() * Quantity.Value, BlueFreeze16oz.GetDietaryFiber() * Quantity.Value, BlueFreeze16oz.GetSugars() * Quantity.Value, BlueFreeze16oz.GetProtein() * Quantity.Value);

            }
            else if (SelectType.SelectedItem.ToString() == "BlueFreeze20oz")
            {
                Beverage BlueFreeze20oz = new Beverage(150, 40, 38, 38);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", BlueFreeze20oz.GetCalories() * Quantity.Value, BlueFreeze20oz.GetTotalFat() * Quantity.Value, BlueFreeze20oz.GetSaturatedFat() * Quantity.Value,
                    BlueFreeze20oz.GetTransFat() * Quantity.Value, BlueFreeze20oz.GetCholesterol() * Quantity.Value, BlueFreeze20oz.GetSodium() * Quantity.Value,
                    BlueFreeze20oz.GetTotalCarbohydrates() * Quantity.Value, BlueFreeze20oz.GetDietaryFiber() * Quantity.Value, BlueFreeze20oz.GetSugars() * Quantity.Value, BlueFreeze20oz.GetProtein() * Quantity.Value);
            }
            else if (SelectType.SelectedItem.ToString() == "Black Beans")
            {
                Veggie BlackBeans = new Veggie(blackBeans);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", blackBeans.GetCalories() * Quantity.Value, blackBeans.GetTotalFat() * Quantity.Value, blackBeans.GetSaturatedFat() * Quantity.Value,
                    blackBeans.GetTransFat() * Quantity.Value, blackBeans.GetCholesterol() * Quantity.Value, blackBeans.GetSodium() * Quantity.Value,
                    blackBeans.GetTotalCarbohydrates() * Quantity.Value, blackBeans.GetDietaryFiber() * Quantity.Value, blackBeans.GetSugars() * Quantity.Value, blackBeans.GetProtein() * Quantity.Value);
                Quantity.Enabled = true;
            }
            else if (SelectType.SelectedItem.ToString() == "Cheesy Rollup")
            {
                Veggie cheesyRollup = new Veggie(cheddarCheese, flourTortilla);
                displayNutritionFacts.Text = String.Format("Nutritional Facts: \nCalories: {0} \nTotal Fat: {1}\n" +
                    "Saturated Fat: {2}\nTrans Fat: {3}\nCholesterol: {4}\nSodium: {5}\nTotal Carbohydrates: {6}\nDietary Fiber: {7}\n" +
                    "Sugars: {8}\nProtein: {9   }\n", cheesyRollup.GetCalories() * Quantity.Value, cheesyRollup.GetTotalFat() * Quantity.Value, cheesyRollup.GetSaturatedFat() * Quantity.Value,
                    cheesyRollup.GetTransFat() * Quantity.Value, cheesyRollup.GetCholesterol() * Quantity.Value, cheesyRollup.GetSodium() * Quantity.Value,
                    cheesyRollup.GetTotalCarbohydrates() * Quantity.Value, cheesyRollup.GetDietaryFiber() * Quantity.Value, cheesyRollup.GetSugars() * Quantity.Value, cheesyRollup.GetProtein() * Quantity.Value);
                Quantity.Enabled = true;
            }
        }

        private void displayNutritionFacts_TextChanged(object sender, EventArgs e)
        {
            
        }

        // modify the NutritionalFacts Textbox reflecting change in quantity of items
        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            SelectType_SelectedIndexChanged(sender, e);
        }
        #endregion
    }
}
