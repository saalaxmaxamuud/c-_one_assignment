using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating variable and declaring

            String dayOfWeek;
            String nameOfMonth;
            String numericDayOfMonth;
            String year;
            dayOfWeek = txtDayofWeek.Text;
            nameOfMonth = TXTmonth.Text;
            numericDayOfMonth = txtdayOfMonth.Text;
            year = TXTyear.Text;

            //concatenation of all

            LBLoutput.Text = dayOfWeek + " " + nameOfMonth + " " + numericDayOfMonth + " " + year;

         
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            //how to clear

            txtDayofWeek.Text = String.Empty;
            txtdayOfMonth.Text = String.Empty;
            TXTmonth.Text = string.Empty;
            TXTyear.Text = string.Empty;
            LBLoutput.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close fucntion 

            this.Close();

        }
    }
}
