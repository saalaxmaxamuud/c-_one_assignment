namespace Airline_Ticket_system
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBaggageWeights = new System.Windows.Forms.Label();
            this.lblNumberTickets = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBaggageWeights = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBusinessClass = new System.Windows.Forms.RadioButton();
            this.radioNormalClass = new System.Windows.Forms.RadioButton();
            this.radioFirstClass = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkAddTravel = new System.Windows.Forms.CheckBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.AirlineBookDetails = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblBaggageWeights);
            this.groupBox1.Controls.Add(this.lblNumberTickets);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtBaggageWeights);
            this.groupBox1.Controls.Add(this.txtTickets);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBaggageWeights
            // 
            this.lblBaggageWeights.AutoSize = true;
            this.lblBaggageWeights.Location = new System.Drawing.Point(80, 235);
            this.lblBaggageWeights.Name = "lblBaggageWeights";
            this.lblBaggageWeights.Size = new System.Drawing.Size(189, 25);
            this.lblBaggageWeights.TabIndex = 7;
            this.lblBaggageWeights.Text = "Baggage Weights ";
            // 
            // lblNumberTickets
            // 
            this.lblNumberTickets.AutoSize = true;
            this.lblNumberTickets.Location = new System.Drawing.Point(77, 171);
            this.lblNumberTickets.Name = "lblNumberTickets";
            this.lblNumberTickets.Size = new System.Drawing.Size(192, 25);
            this.lblNumberTickets.TabIndex = 6;
            this.lblNumberTickets.Text = "Number Of Tickets";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(109, 96);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(160, 25);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Passenger Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Passenger Name";
            // 
            // txtBaggageWeights
            // 
            this.txtBaggageWeights.Location = new System.Drawing.Point(292, 217);
            this.txtBaggageWeights.Multiline = true;
            this.txtBaggageWeights.Name = "txtBaggageWeights";
            this.txtBaggageWeights.Size = new System.Drawing.Size(272, 43);
            this.txtBaggageWeights.TabIndex = 3;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(292, 153);
            this.txtTickets.Multiline = true;
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(272, 43);
            this.txtTickets.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(292, 93);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(272, 43);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(292, 29);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 43);
            this.txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.radioBusinessClass);
            this.groupBox2.Controls.Add(this.radioNormalClass);
            this.groupBox2.Controls.Add(this.radioFirstClass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // radioBusinessClass
            // 
            this.radioBusinessClass.AutoSize = true;
            this.radioBusinessClass.Location = new System.Drawing.Point(369, 36);
            this.radioBusinessClass.Name = "radioBusinessClass";
            this.radioBusinessClass.Size = new System.Drawing.Size(161, 24);
            this.radioBusinessClass.TabIndex = 2;
            this.radioBusinessClass.TabStop = true;
            this.radioBusinessClass.Text = "Business  Class";
            this.radioBusinessClass.UseVisualStyleBackColor = true;
            // 
            // radioNormalClass
            // 
            this.radioNormalClass.AutoSize = true;
            this.radioNormalClass.Location = new System.Drawing.Point(183, 36);
            this.radioNormalClass.Name = "radioNormalClass";
            this.radioNormalClass.Size = new System.Drawing.Size(139, 24);
            this.radioNormalClass.TabIndex = 1;
            this.radioNormalClass.TabStop = true;
            this.radioNormalClass.Text = "Normal Class";
            this.radioNormalClass.UseVisualStyleBackColor = true;
            // 
            // radioFirstClass
            // 
            this.radioFirstClass.AutoSize = true;
            this.radioFirstClass.Location = new System.Drawing.Point(19, 36);
            this.radioFirstClass.Name = "radioFirstClass";
            this.radioFirstClass.Size = new System.Drawing.Size(119, 24);
            this.radioFirstClass.TabIndex = 0;
            this.radioFirstClass.TabStop = true;
            this.radioFirstClass.Text = "First Class";
            this.radioFirstClass.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Controls.Add(this.checkAddTravel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Options";
            // 
            // checkAddTravel
            // 
            this.checkAddTravel.AutoSize = true;
            this.checkAddTravel.Location = new System.Drawing.Point(66, 23);
            this.checkAddTravel.Name = "checkAddTravel";
            this.checkAddTravel.Size = new System.Drawing.Size(336, 24);
            this.checkAddTravel.TabIndex = 0;
            this.checkAddTravel.Text = "Add Travel Insurance ($25 per Ticket)";
            this.checkAddTravel.UseVisualStyleBackColor = true;
            // 
            // btCalculate
            // 
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCalculate.Location = new System.Drawing.Point(32, 503);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(105, 34);
            this.btCalculate.TabIndex = 3;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btClear.Location = new System.Drawing.Point(212, 503);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(105, 34);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btExit.Location = new System.Drawing.Point(438, 503);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(105, 34);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AirlineBookDetails
            // 
            this.AirlineBookDetails.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AirlineBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirlineBookDetails.FormattingEnabled = true;
            this.AirlineBookDetails.ItemHeight = 20;
            this.AirlineBookDetails.Location = new System.Drawing.Point(736, 42);
            this.AirlineBookDetails.Name = "AirlineBookDetails";
            this.AirlineBookDetails.Size = new System.Drawing.Size(315, 424);
            this.AirlineBookDetails.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 594);
            this.Controls.Add(this.AirlineBookDetails);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBaggageWeights;
        private System.Windows.Forms.Label lblNumberTickets;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBaggageWeights;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBusinessClass;
        private System.Windows.Forms.RadioButton radioNormalClass;
        private System.Windows.Forms.RadioButton radioFirstClass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkAddTravel;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListBox AirlineBookDetails;
    }
}

