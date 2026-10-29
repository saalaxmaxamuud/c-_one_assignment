namespace Fat_percentage_calculator
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
            this.txtColories = new System.Windows.Forms.TextBox();
            this.lblColories = new System.Windows.Forms.Label();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.checkLowFat = new System.Windows.Forms.CheckBox();
            this.btbCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblPerc);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblPercentage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btbCalculate);
            this.groupBox1.Controls.Add(this.checkLowFat);
            this.groupBox1.Controls.Add(this.lblFat);
            this.groupBox1.Controls.Add(this.txtFat);
            this.groupBox1.Controls.Add(this.lblColories);
            this.groupBox1.Controls.Add(this.txtColories);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fat Percentage calculator";
            // 
            // txtColories
            // 
            this.txtColories.Location = new System.Drawing.Point(217, 58);
            this.txtColories.Multiline = true;
            this.txtColories.Name = "txtColories";
            this.txtColories.Size = new System.Drawing.Size(244, 39);
            this.txtColories.TabIndex = 0;
            // 
            // lblColories
            // 
            this.lblColories.AutoSize = true;
            this.lblColories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColories.Location = new System.Drawing.Point(-1, 65);
            this.lblColories.Name = "lblColories";
            this.lblColories.Size = new System.Drawing.Size(208, 32);
            this.lblColories.TabIndex = 1;
            this.lblColories.Text = "Enter Colories";
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(217, 114);
            this.txtFat.Multiline = true;
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(244, 39);
            this.txtFat.TabIndex = 2;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.Location = new System.Drawing.Point(40, 120);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(139, 32);
            this.lblFat.TabIndex = 3;
            this.lblFat.Text = "Enter Fat";
            // 
            // checkLowFat
            // 
            this.checkLowFat.AutoSize = true;
            this.checkLowFat.Location = new System.Drawing.Point(161, 186);
            this.checkLowFat.Name = "checkLowFat";
            this.checkLowFat.Size = new System.Drawing.Size(154, 41);
            this.checkLowFat.TabIndex = 4;
            this.checkLowFat.Text = "Low fat";
            this.checkLowFat.UseVisualStyleBackColor = true;
            // 
            // btbCalculate
            // 
            this.btbCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCalculate.Location = new System.Drawing.Point(27, 257);
            this.btbCalculate.Name = "btbCalculate";
            this.btbCalculate.Size = new System.Drawing.Size(180, 43);
            this.btbCalculate.TabIndex = 5;
            this.btbCalculate.Text = "Calculate";
            this.btbCalculate.UseVisualStyleBackColor = true;
            this.btbCalculate.Click += new System.EventHandler(this.btbCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "number of color";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(22, 388);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(174, 25);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Text = "percentage of fat";
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Location = new System.Drawing.Point(323, 317);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(489, 44);
            this.lblNumber.TabIndex = 8;
            // 
            // lblPerc
            // 
            this.lblPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerc.Location = new System.Drawing.Point(323, 388);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(489, 39);
            this.lblPerc.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(597, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(296, 112);
            this.lblResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.Label lblColories;
        private System.Windows.Forms.TextBox txtColories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbCalculate;
        private System.Windows.Forms.CheckBox checkLowFat;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Label lblResult;
    }
}

