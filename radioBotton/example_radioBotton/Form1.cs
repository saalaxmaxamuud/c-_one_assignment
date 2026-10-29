using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_radioBotton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            // creating varibles
            String name, gender;
            string faculty = "";
            int age, validation;
            //validation of date
            if (int.TryParse(txtAge.Text, out validation))
            {
                //assigning variables to input user
                name = txtName.Text;
                age = int.Parse(txtAge.Text);
                // checking validation
                if (age > 18)//true
                {
                    // checking the gender
                    if (radioMale.Checked | radioFemale.Checked)
                    {
                        gender = "male\n";
                        listBox1.Items.Add(gender);
                        listBox1.Items.Clear();

                    }
                    else
                    {
                        gender = "female\n";
                        listBox1.Items.Add(gender);
                    }


                }
                else
                {
                    MessageBox.Show("please select on gender");
                }
                if (checkComputer.Checked & checkIt.Checked & checkBusiness.Checked)
                {
                    faculty += "computer\n" + "," + "It\n" + "Business";
                    listBox1.Items.Add(faculty + "\n");
                }
                else if (checkIt.Checked & checkBusiness.Checked)
                {
                    faculty += "It\n" + "," + "Business";
                    listBox1.Items.Add(faculty + "\n");
                }
                else if (checkComputer.Checked & checkBusiness.Checked)
                {
                    faculty += "computer\n" + "," + "Business";
                    listBox1.Items.Add(faculty + "\n");
                }
                else if (checkBusiness.Checked & checkIt.Checked)
                {
                    faculty += "It\n" + "," + "Business";
                    listBox1.Items.Add(faculty + "\n");
                }
                else
                {
                    MessageBox.Show("please select at least one faculty");
                }
            }
            else
            {
                MessageBox.Show("age only accept positive number");
            }
        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            listBox1.Text = string.Empty;
        }
    }
}
