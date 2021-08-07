
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutritionCalculator));
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.displayNutritionFacts = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectCategory
            // 
            this.SelectCategory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCategory.ForeColor = System.Drawing.Color.Black;
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Taco",
            "Beverage",
            "Veggie"});
            this.SelectCategory.Location = new System.Drawing.Point(12, 88);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(121, 21);
            this.SelectCategory.TabIndex = 0;
            this.SelectCategory.SelectedIndexChanged += new System.EventHandler(this.SelectCategory_SelectedIndexChanged);
            // 
            // SelectType
            // 
            this.SelectType.BackColor = System.Drawing.Color.White;
            this.SelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectType.Enabled = false;
            this.SelectType.FormattingEnabled = true;
            this.SelectType.Location = new System.Drawing.Point(12, 162);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(121, 21);
            this.SelectType.TabIndex = 1;
            this.SelectType.SelectedIndexChanged += new System.EventHandler(this.SelectType_SelectedIndexChanged);
            // 
            // displayNutritionFacts
            // 
            this.displayNutritionFacts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.displayNutritionFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNutritionFacts.Location = new System.Drawing.Point(206, 88);
            this.displayNutritionFacts.Name = "displayNutritionFacts";
            this.displayNutritionFacts.ReadOnly = true;
            this.displayNutritionFacts.Size = new System.Drawing.Size(211, 211);
            this.displayNutritionFacts.TabIndex = 3;
            this.displayNutritionFacts.Text = "";
            this.displayNutritionFacts.TextChanged += new System.EventHandler(this.displayNutritionFacts_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(13, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Select Category";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(13, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Select Item";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(206, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Nutritional Facts";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Quantity.Enabled = false;
            this.Quantity.Location = new System.Drawing.Point(12, 238);
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Size = new System.Drawing.Size(120, 20);
            this.Quantity.TabIndex = 7;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(13, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Quantity";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NutritionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(486, 396);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.displayNutritionFacts);
            this.Controls.Add(this.SelectType);
            this.Controls.Add(this.SelectCategory);
            this.Name = "NutritionCalculator";
            this.Text = "NutritionCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.ComboBox SelectType;
        private System.Windows.Forms.RichTextBox displayNutritionFacts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.TextBox textBox4;
    }
}

