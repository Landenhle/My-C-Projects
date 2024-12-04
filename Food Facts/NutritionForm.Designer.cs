namespace Food_Facts
{
    partial class NutritionForm
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.calorieTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.carbTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(53, 46);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(31, 13);
            this.foodLabel.TabIndex = 0;
            this.foodLabel.Text = "Food";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(53, 72);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(39, 13);
            this.caloriesLabel.TabIndex = 1;
            this.caloriesLabel.Text = "Calorie";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(53, 101);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(55, 13);
            this.fatLabel.TabIndex = 2;
            this.fatLabel.Text = "Fat Grams";
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Location = new System.Drawing.Point(53, 131);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(62, 13);
            this.carbLabel.TabIndex = 3;
            this.carbLabel.Text = "Carb Grams";
            // 
            // foodTextBox
            // 
            this.foodTextBox.Location = new System.Drawing.Point(131, 46);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodTextBox.TabIndex = 4;
            // 
            // calorieTextBox
            // 
            this.calorieTextBox.Location = new System.Drawing.Point(131, 72);
            this.calorieTextBox.Name = "calorieTextBox";
            this.calorieTextBox.Size = new System.Drawing.Size(100, 20);
            this.calorieTextBox.TabIndex = 5;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(131, 98);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatTextBox.TabIndex = 6;
            // 
            // carbTextBox
            // 
            this.carbTextBox.Location = new System.Drawing.Point(131, 124);
            this.carbTextBox.Name = "carbTextBox";
            this.carbTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carbTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.calorieTextBox);
            this.Controls.Add(this.foodTextBox);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.foodLabel);
            this.Name = "NutritionForm";
            this.Text = "NutritionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox calorieTextBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox foodTextBox;
        public System.Windows.Forms.TextBox fatTextBox;
        public System.Windows.Forms.TextBox carbTextBox;
        public System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label caloriesLabel;
        public System.Windows.Forms.Label fatLabel;
        public System.Windows.Forms.Label carbLabel;
    }
}