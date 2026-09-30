namespace Assignment3
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
            this.txtfoodName1 = new System.Windows.Forms.TextBox();
            this.txtPriceFood1 = new System.Windows.Forms.TextBox();
            this.txtFoodName2 = new System.Windows.Forms.TextBox();
            this.txtPriceFood2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFoodName1 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblNamefood2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.txtSalextText = new System.Windows.Forms.TextBox();
            this.txtTipsAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtfoodName1
            // 
            this.txtfoodName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfoodName1.Location = new System.Drawing.Point(397, 12);
            this.txtfoodName1.Multiline = true;
            this.txtfoodName1.Name = "txtfoodName1";
            this.txtfoodName1.Size = new System.Drawing.Size(370, 59);
            this.txtfoodName1.TabIndex = 0;
            // 
            // txtPriceFood1
            // 
            this.txtPriceFood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceFood1.Location = new System.Drawing.Point(397, 115);
            this.txtPriceFood1.Multiline = true;
            this.txtPriceFood1.Name = "txtPriceFood1";
            this.txtPriceFood1.Size = new System.Drawing.Size(370, 59);
            this.txtPriceFood1.TabIndex = 1;
            // 
            // txtFoodName2
            // 
            this.txtFoodName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodName2.Location = new System.Drawing.Point(397, 243);
            this.txtFoodName2.Multiline = true;
            this.txtFoodName2.Name = "txtFoodName2";
            this.txtFoodName2.Size = new System.Drawing.Size(370, 59);
            this.txtFoodName2.TabIndex = 2;
            // 
            // txtPriceFood2
            // 
            this.txtPriceFood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceFood2.Location = new System.Drawing.Point(397, 357);
            this.txtPriceFood2.Multiline = true;
            this.txtPriceFood2.Name = "txtPriceFood2";
            this.txtPriceFood2.Size = new System.Drawing.Size(370, 59);
            this.txtPriceFood2.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(192, 447);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(195, 56);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "calculate the price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFoodName1
            // 
            this.lblFoodName1.Location = new System.Drawing.Point(131, 16);
            this.lblFoodName1.Name = "lblFoodName1";
            this.lblFoodName1.Size = new System.Drawing.Size(237, 55);
            this.lblFoodName1.TabIndex = 5;
            this.lblFoodName1.Text = "Enter name food 1";
            // 
            // lblPrice1
            // 
            this.lblPrice1.Location = new System.Drawing.Point(131, 119);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(237, 55);
            this.lblPrice1.TabIndex = 6;
            this.lblPrice1.Text = "Enter name price 1";
            // 
            // lblNamefood2
            // 
            this.lblNamefood2.Location = new System.Drawing.Point(115, 247);
            this.lblNamefood2.Name = "lblNamefood2";
            this.lblNamefood2.Size = new System.Drawing.Size(237, 55);
            this.lblNamefood2.TabIndex = 7;
            this.lblNamefood2.Text = "Enter name food 2";
            // 
            // lblPrice2
            // 
            this.lblPrice2.Location = new System.Drawing.Point(115, 370);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(237, 55);
            this.lblPrice2.TabIndex = 8;
            this.lblPrice2.Text = "Enter name price 2";
            // 
            // txtSalextText
            // 
            this.txtSalextText.Location = new System.Drawing.Point(525, 432);
            this.txtSalextText.Multiline = true;
            this.txtSalextText.Name = "txtSalextText";
            this.txtSalextText.Size = new System.Drawing.Size(173, 56);
            this.txtSalextText.TabIndex = 9;
            // 
            // txtTipsAmount
            // 
            this.txtTipsAmount.Location = new System.Drawing.Point(525, 507);
            this.txtTipsAmount.Multiline = true;
            this.txtTipsAmount.Name = "txtTipsAmount";
            this.txtTipsAmount.Size = new System.Drawing.Size(173, 41);
            this.txtTipsAmount.TabIndex = 10;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(525, 581);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(173, 41);
            this.txtTotalAmount.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 646);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtTipsAmount);
            this.Controls.Add(this.txtSalextText);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblNamefood2);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblFoodName1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceFood2);
            this.Controls.Add(this.txtFoodName2);
            this.Controls.Add(this.txtPriceFood1);
            this.Controls.Add(this.txtfoodName1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfoodName1;
        private System.Windows.Forms.TextBox txtPriceFood1;
        private System.Windows.Forms.TextBox txtFoodName2;
        private System.Windows.Forms.TextBox txtPriceFood2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFoodName1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblNamefood2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.TextBox txtSalextText;
        private System.Windows.Forms.TextBox txtTipsAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
    }
}

