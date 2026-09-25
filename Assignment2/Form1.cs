using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowinfo_Click(object sender, EventArgs e)

        {
            // creating variable 

            string studentName;
            //String studentID;
            string Department;
            //string semester;
            studentName = txtName.Text;
            int studentID = int.Parse(txtStudentid.Text);

            Department = txtDepartment.Text;
          int  semester = int.Parse(txtsemester.Text);

            // contatenation of all student information
            lblOutput.Text = studentName + "," + studentID + "," + Department + "," + semester;

        

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //how to clear output

            txtName.Text = string.Empty;
            txtStudentid.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtsemester.Text = string.Empty;
            lblOutput.Text = string.Empty;
        }
    }
}
