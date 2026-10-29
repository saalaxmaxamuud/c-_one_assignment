namespace payroll_withOvertime
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
            this.lblhours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.btbCalculate = new System.Windows.Forms.Button();
            this.btbClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(118, 33);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(164, 27);
            this.lblhours.TabIndex = 0;
            this.lblhours.Text = "Hourse Worked";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly pay Rate";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross Pay";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(327, 33);
            this.txtHours.Multiline = true;
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(213, 40);
            this.txtHours.TabIndex = 4;
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(327, 96);
            this.txtHourlyPay.Multiline = true;
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(213, 40);
            this.txtHourlyPay.TabIndex = 5;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrossPay.Location = new System.Drawing.Point(327, 149);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(213, 37);
            this.lblGrossPay.TabIndex = 6;
            // 
            // btbCalculate
            // 
            this.btbCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCalculate.Location = new System.Drawing.Point(109, 231);
            this.btbCalculate.Name = "btbCalculate";
            this.btbCalculate.Size = new System.Drawing.Size(194, 73);
            this.btbCalculate.TabIndex = 7;
            this.btbCalculate.Text = "&Calculate Gross Pay";
            this.btbCalculate.UseVisualStyleBackColor = true;
            this.btbCalculate.Click += new System.EventHandler(this.btbCalculate_Click);
            // 
            // btbClear
            // 
            this.btbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClear.Location = new System.Drawing.Point(354, 235);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(135, 65);
            this.btbClear.TabIndex = 8;
            this.btbClear.Text = "&Clear";
            this.btbClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbClear);
            this.Controls.Add(this.btbCalculate);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtHourlyPay;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Button btbCalculate;
        private System.Windows.Forms.Button btbClear;
        private System.Windows.Forms.Button button1;
    }
}

