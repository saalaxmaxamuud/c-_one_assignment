using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // creating variables 

            String foodName1;
            double price1;
            string foodName2;
            double price2;

            try
            {
                // getting values
                foodName1 = txtfoodName1.Text;
                price1 = double.Parse(txtPriceFood1.Text);
                foodName2 = txtFoodName2.Text;
                price2 = double.Parse(txtPriceFood2.Text);

                // calculate total
                double subTotal = price1 + price2;

                // salex taxt
                double salexText = subTotal / 100;


                // calculate total amount

                double TotalAmount = subTotal + salexText;

                double tipsAmount = subTotal * salexText / 100;

                // display result of output

              
                txtSalextText.Text = salexText.ToString("C");
                txtTotalAmount.Text = TotalAmount.ToString("c");
                txtTipsAmount.Text = tipsAmount.ToString("c");

            }
            catch
            {
                MessageBox.Show(" invalid data try again");
            }

        }
    }
}
