using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbCalculate_Click(object sender, EventArgs e)
        {
            //creating variables
            int quantity;
            decimal price;
            try
            {
              

                // valid input 
                //only accept valid number

                if (!int.TryParse(txtNumberOfPackages.Text, out quantity) ||
                    !decimal.TryParse(txtPricePackages.Text, out price) ||
                  // check quantity and price 
                  quantity<=0 || price<=0)

                {
                    MessageBox.Show("Enter valid quantity and price.");
                    return;
                }
                // calculate subtotal

                decimal subtotal = quantity * price;
                decimal discountRate;

                // check all 

                if (quantity >= 100)
                    
                    discountRate = 0.50m;

                else if (quantity >= 50)
                    discountRate = 0.40m;

                else if (quantity >= 20)
                
                    discountRate = 0.30m;
                else if (quantity >= 10)

                    discountRate = 0.20m;
                else
                    discountRate = 0m;
                // calculating the amount
                decimal discountAmount = subtotal * discountRate;
                decimal total = subtotal - discountAmount;

                purchaseResult.Items.Add(Text = " quality"+quantity.ToString());
                purchaseResult.Items.Add(Text = price.ToString());
                purchaseResult.Items.Add(Text = subtotal.ToString());
                purchaseResult.Items.Add(Text = discountRate.ToString());
                purchaseResult.Items.Add(Text = discountAmount.ToString());
                purchaseResult.Items.Add(Text = total.ToString());
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            

           
            purchaseResult.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

           
    

