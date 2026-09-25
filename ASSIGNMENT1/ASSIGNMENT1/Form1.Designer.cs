namespace ASSIGNMENT1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDayofWeek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTmonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdayOfMonth = new System.Windows.Forms.TextBox();
            this.lblDayOFmonth = new System.Windows.Forms.Label();
            this.TXTyear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.LBLoutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDayofWeek
            // 
            this.txtDayofWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDayofWeek.Location = new System.Drawing.Point(319, 21);
            this.txtDayofWeek.Multiline = true;
            this.txtDayofWeek.Name = "txtDayofWeek";
            this.txtDayofWeek.Size = new System.Drawing.Size(280, 39);
            this.txtDayofWeek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "enter  day of week";
            // 
            // TXTmonth
            // 
            this.TXTmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTmonth.Location = new System.Drawing.Point(319, 80);
            this.TXTmonth.Multiline = true;
            this.TXTmonth.Name = "TXTmonth";
            this.TXTmonth.Size = new System.Drawing.Size(280, 44);
            this.TXTmonth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "enter the name of month";
            // 
            // txtdayOfMonth
            // 
            this.txtdayOfMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayOfMonth.Location = new System.Drawing.Point(319, 151);
            this.txtdayOfMonth.Multiline = true;
            this.txtdayOfMonth.Name = "txtdayOfMonth";
            this.txtdayOfMonth.Size = new System.Drawing.Size(280, 49);
            this.txtdayOfMonth.TabIndex = 4;
            // 
            // lblDayOFmonth
            // 
            this.lblDayOFmonth.AutoSize = true;
            this.lblDayOFmonth.Location = new System.Drawing.Point(165, 180);
            this.lblDayOFmonth.Name = "lblDayOFmonth";
            this.lblDayOFmonth.Size = new System.Drawing.Size(142, 20);
            this.lblDayOFmonth.TabIndex = 5;
            this.lblDayOFmonth.Text = "enter day of month";
            // 
            // TXTyear
            // 
            this.TXTyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTyear.Location = new System.Drawing.Point(319, 244);
            this.TXTyear.Multiline = true;
            this.TXTyear.Name = "TXTyear";
            this.TXTyear.Size = new System.Drawing.Size(292, 40);
            this.TXTyear.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(165, 264);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(80, 20);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "enetr year";
            // 
            // LBLoutput
            // 
            this.LBLoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLoutput.Location = new System.Drawing.Point(223, 340);
            this.LBLoutput.Name = "LBLoutput";
            this.LBLoutput.Size = new System.Drawing.Size(344, 55);
            this.LBLoutput.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "showData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(403, 442);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 41);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(649, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "exit Button";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 670);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBLoutput);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.TXTyear);
            this.Controls.Add(this.lblDayOFmonth);
            this.Controls.Add(this.txtdayOfMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTmonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDayofWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDayofWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTmonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdayOfMonth;
        private System.Windows.Forms.Label lblDayOFmonth;
        private System.Windows.Forms.TextBox TXTyear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label LBLoutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button3;
    }
}

