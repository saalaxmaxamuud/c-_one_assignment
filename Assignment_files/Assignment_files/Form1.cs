using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btWriteLines_Click(object sender, EventArgs e)
        {
            //creatingfiles
            StreamWriter lines;
            lines = File.CreateText("file.doc");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to jamhuuriya");
            lines.WriteLine("class ca244");
            lines.WriteLine("salaH MOHAMUD");
            MessageBox.Show("File successfully");
            //closing the lines
            lines.Close();
        }

        private void btreadLines_Click(object sender, EventArgs e)
        {
            reading.Items.Clear();
            if (File.Exists("file.doc"))
            {
                foreach (string line in File.ReadLines("file.doc"))
                {
                    reading.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }

        private void btLines_Click(object sender, EventArgs e)
        {
            reading.Items.Clear();
            if (File.Exists("file.doc"))
            {
                string[] lines = File.ReadAllLines("file.doc");

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

        private void btDeleteItems_Click(object sender, EventArgs e)
        {
            //  Delete file button delete files
            if (File.Exists("file.doc"))
            {
                File.Delete("file.doc");
                reading.Items.Clear();
                MessageBox.Show("Faylkii waa la tirtiray.");
            }
            else
            {
                MessageBox.Show("Fayl lama helin.");
            }

        }

        private void btDeleteFile_Click(object sender, EventArgs e)
        {
            reading.Items.Clear();
        }
    }
}
        
