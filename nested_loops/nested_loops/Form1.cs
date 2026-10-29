using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nested_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating variables
            double salary, years;
            try
            {
                // assignin variables
                salary = double.Parse(txtSalary.Text);
                years = double.Parse(txtYearsEX.Text);

                // checking qualification using decision structure
                if (salary > 300)// true or false
                {
                    // checking years of exe
                    if (years >= 2)// true or false
                    {
                        lblDecision.Text = "qualify on loan salary and exp";
                    }
                    else
                    {
                        MessageBox.Show("musharkaga makugu filno");

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("invalid number");
            }
        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            txtSalary.Text = string.Empty;
            txtYearsEX.Text = string.Empty;
            lblDecision.Text = string.Empty;
            
           
        }
    }
}
