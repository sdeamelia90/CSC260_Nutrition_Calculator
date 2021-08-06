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

        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectType.Items.Clear();
            if (SelectCategory.SelectedItem == "Taco")
            {
                SelectType.Items.Add("Soft Taco");
                SelectType.Items.Add("Soft Taco Supreme");
                SelectType.Items.Add("Crunchy Taco");
                SelectType.Items.Add("Soft Taco Supreme");
                SelectType.Items.Add("Nachos Cheese Doritos Locos Taco");
                SelectType.Items.Add("Nachos Cheese Doritos Locos Taco Supreme");
                SelectType.Items.Add("Chalupa Supreme");
                SelectType.Items.Add("Cheesy Gordita Crunch");
            }
            /*
            else if (SelectCategory.SelectedItem == "Bowls")
            {
                SelectType.Items.Add("Power Menu Bowl");
                SelectType.Items.Add("Power Menu Bowl - Veggie");
            }
            else if (SelectCategory.SelectedItem == "Taco")
            {
                SelectType.Items.Add("Chalupa Supreme");
                SelectType.Items.Add("Cheesy Gordita Crunch");
                SelectType.Items.Add("Crunchy Taco");
                SelectType.Items.Add("Crunchy Taco Supreme");
                SelectType.Items.Add("Nacho Cheese Doritos Locos Taco");
                SelectType.Items.Add("Nacho Cheese Doritos Locos Taco Supreme");
                SelectType.Items.Add("Soft Taco");
                SelectType.Items.Add("Soft Taco Supreme");
            } */
            }


        private void SelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
