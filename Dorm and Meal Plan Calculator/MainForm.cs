using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalCosts sumCosts = new TotalCosts();
           
            double allenHall = 1500;
            double pikeHall = 1600;
            double farthingHall = 1800;
            double universitySuites = 2500;

            double twoMeals = 600;
            double fourteenMeals = 1200;
            double unlimitedMeals = 1700;

            try
            {
                if(allenRadioButton.Checked && startersRadioButton.Checked)
                {
                    double AHTM = allenHall + twoMeals;
                    sumCosts.textBox1.Text = AHTM.ToString("c");
                }else if(allenRadioButton.Checked && mainsRadioButton.Checked)
                {
                    double AHFM = allenHall + fourteenMeals;
                    sumCosts.textBox1.Text = AHFM.ToString("c");
                }else if(allenRadioButton.Checked && unlimitedRadioButton.Checked)
                {
                    double AHUM = allenHall + unlimitedMeals;
                    sumCosts.textBox1.Text = AHUM.ToString("c");
                }
                else if (pikeRadioButton.Checked && startersRadioButton.Checked)
                {
                    double PHTM = pikeHall + twoMeals;
                    sumCosts.textBox1.Text = PHTM.ToString("c");
                }
                else if (pikeRadioButton.Checked && mainsRadioButton.Checked)
                {
                    double PHFM = pikeHall + fourteenMeals;
                    sumCosts.textBox1.Text = PHFM.ToString("c");
                }
                else if (pikeRadioButton.Checked && unlimitedRadioButton.Checked)
                {
                    double PHUM = pikeHall + unlimitedMeals;
                    sumCosts.textBox1.Text = PHUM.ToString("c");
                }
                else if (farthingRadioButton.Checked && startersRadioButton.Checked)
                {
                    double FHTM = farthingHall + twoMeals;
                    sumCosts.textBox1.Text = FHTM.ToString("c");
                }
                else if (farthingRadioButton.Checked && mainsRadioButton.Checked)
                {
                    double FHFM = farthingHall + fourteenMeals;
                    sumCosts.textBox1.Text = FHFM.ToString("c");
                }
                else if (farthingRadioButton.Checked && unlimitedRadioButton.Checked)
                {
                    double FHUM = farthingHall + unlimitedMeals;
                    sumCosts.textBox1.Text = FHUM.ToString("c");
                }
                else if (suitesRadioButton.Checked && startersRadioButton.Checked)
                {
                    double USTM = universitySuites + twoMeals;
                    sumCosts.textBox1.Text = USTM.ToString("c");
                }
                else if (suitesRadioButton.Checked && mainsRadioButton.Checked)
                {
                    double USFM = universitySuites + fourteenMeals;
                    sumCosts.textBox1.Text = USFM.ToString("c");
                }
                else if (suitesRadioButton.Checked && unlimitedRadioButton.Checked)
                {
                    double USUM = universitySuites + unlimitedMeals;
                    sumCosts.textBox1.Text = USUM.ToString("c");
                }

                sumCosts.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Please ensure correct options are selected.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
