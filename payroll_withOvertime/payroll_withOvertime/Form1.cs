using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_withOvertime
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
            double hours_worked, pay_rate, GrossPay;
            double validation;

            // prvent exception data convarsion using try
            if (double.TryParse(txtHours.Text, out validation) & double.TryParse(txtHourlyPay.Text, out validation))
                {
                // assign variables
                hours_worked = double.Parse(txtHours.Text);
                pay_rate = double.Parse(txtHourlyPay.Text);

                // check validation
                if (hours_worked > 0 && pay_rate > 0)
                {
                    // calculate the gross pay
                    GrossPay = hours_worked * pay_rate;
                    lblGrossPay.Text = GrossPay.ToString("c");
                }
                else
                {
                    MessageBox.Show("hours worked or payrate");

                }


            }
            else
            {
                MessageBox.Show("txt");
            }
        }
    }
}
    

