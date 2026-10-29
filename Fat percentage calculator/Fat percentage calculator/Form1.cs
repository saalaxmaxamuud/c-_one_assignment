using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fat_percentage_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbCalculate_Click(object sender, EventArgs e)
        {
            // create variables
            double calories, fatGrams;
            try
            {
             

                if (double.TryParse(txtColories.Text, out calories) &&
                    double.TryParse(txtFat.Text, out fatGrams) &&
                    calories > 0 && fatGrams >= 0)
                {
                    double caloriesFromFat = fatGrams * 9;
                    if (caloriesFromFat > calories)
                    {
                        MessageBox.Show("Fat calories cannot be greater than total calories.");
                        checkLowFat.Checked = false;
                        return;
                    }
                    double percentage = (caloriesFromFat / calories) * 100;

                    lblNumber.Text = "Calories from Fat: " + caloriesFromFat;
                    lblPercentage.Text = "Percentage of Fat: " + percentage.ToString("F2") + "%";


                    if (percentage < 30)
                    {
                        lblNumber.Text += "\nThis food is low in fat.";
                        checkLowFat.Checked = true;
                    }
                    else
                    {
                        lblNumber.Text += "\nThis food is not low in fat.";
                        checkLowFat.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("sogali valid number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
