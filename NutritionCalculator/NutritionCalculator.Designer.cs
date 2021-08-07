
namespace NutritionCalculator
{
    partial class NutritionCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.displayNutritionFacts = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SelectCategory
            // 
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Select Category",
            "Taco",
            "Beverage"});
            this.SelectCategory.Location = new System.Drawing.Point(12, 88);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(121, 21);
            this.SelectCategory.TabIndex = 0;
            this.SelectCategory.SelectedIndexChanged += new System.EventHandler(this.SelectCategory_SelectedIndexChanged);
            // 
            // SelectType
            // 
            this.SelectType.FormattingEnabled = true;
            this.SelectType.Location = new System.Drawing.Point(12, 162);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(121, 21);
            this.SelectType.TabIndex = 1;
            this.SelectType.SelectedIndexChanged += new System.EventHandler(this.SelectType_SelectedIndexChanged);
            // 
            // displayNutritionFacts
            // 
            this.displayNutritionFacts.Location = new System.Drawing.Point(542, 38);
            this.displayNutritionFacts.Name = "displayNutritionFacts";
            this.displayNutritionFacts.Size = new System.Drawing.Size(211, 350);
            this.displayNutritionFacts.TabIndex = 3;
            this.displayNutritionFacts.Text = "";
            this.displayNutritionFacts.TextChanged += new System.EventHandler(this.displayNutritionFacts_TextChanged);
            // 
            // NutritionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayNutritionFacts);
            this.Controls.Add(this.SelectType);
            this.Controls.Add(this.SelectCategory);
            this.Name = "NutritionCalculator";
            this.Text = "NutritionCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.ComboBox SelectType;
        private System.Windows.Forms.RichTextBox displayNutritionFacts;
    }
}

