using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NutritionForm nutriForm = new NutritionForm();
           
            if (bananaRadioButton.Checked)
                 {
                 nutriForm.foodTextBox.Text = "1 banana";
                 nutriForm.calorieTextBox.Text = "100";
                 nutriForm.fatTextBox.Text = "0.4";
                 nutriForm.carbTextBox.Text = "27";

                
                 }
             else if (popcornRadioButton.Checked)
                 {
                 nutriForm.foodTextBox.Text = "1 cup air-popped popcorn";
                 nutriForm.calorieTextBox.Text = "31";
                 nutriForm.fatTextBox.Text = "0.4";
                 nutriForm.carbTextBox.Text = "6";
                 }
             else if (muffinRadioButton.Checked)
                 {
                 nutriForm.foodTextBox.Text = "1 large blueberry muffin";
                 nutriForm.calorieTextBox.Text = "385";
                 nutriForm.fatTextBox.Text = "9";
                 nutriForm.carbTextBox.Text = "67";
                 }
            nutriForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
