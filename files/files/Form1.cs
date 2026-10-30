using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            //creatingfiles
            StreamWriter lines;
            lines = File.CreateText(@"D:\c#\files");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to jamhuuriya");
            lines.WriteLine("class ca244");
            lines.WriteLine("salaH MOHAMUD");
            MessageBox.Show("File successfully");
            //closing the lines
            lines.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reading.Items.Clear();
            if (File.Exists(@"D:\c#\files"))
            {
                foreach (string line in File.ReadLines(@"D:\c#\files"))
                {
                    reading.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }

        }

        private void btreadLines_Click(object sender, EventArgs e)
        {
            reading.Items.Clear();
            if (File.Exists(@"D:\c#\files"))
            {
                string[] lines = File.ReadAllLines(@"D:\c#\files");

                foreach (string line in lines)
                {
                    reading.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\c#\files"))
            {
                if (reading.SelectedItem != null)

                {
                    string selectedItem = reading.SelectedItem.ToString();

                    var lines = File.ReadAllLines("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt").ToList();

                    if (lines.Remove(selectedItem))

                    {
                        File.WriteAllLines("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt", lines);

                        reading.Items.Remove(selectedItem);

                        MessageBox.Show("Item deleted successfully.");
                    }

                    else

                    {
                        MessageBox.Show("Item not found in the file.");
                    }
                }

                else

                {

                    MessageBox.Show("Please select an item to delete.");


                }
            }
            else
            {
                MessageBox.Show("path  not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { 

           //  Delete file button delete files
     if (File.Exists(@"D:\c#\files"))
            {
                File.Delete("myfile.doc");
                reading.Items.Clear();
                MessageBox.Show("Faylkii waa la tirtiray.");
            }
            else
            {
                MessageBox.Show("Fayl lama helin.");
            }

        }
    }
}
    