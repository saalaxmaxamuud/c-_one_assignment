namespace SoftwareSales
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
            this.txtNumberOfPackages = new System.Windows.Forms.TextBox();
            this.txtPricePackages = new System.Windows.Forms.TextBox();
            this.lblNumberOfPackages = new System.Windows.Forms.Label();
            this.lblPricePerPackages = new System.Windows.Forms.Label();
            this.btbCalculate = new System.Windows.Forms.Button();
            this.btbClear = new System.Windows.Forms.Button();
            this.btbExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchaseResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumberOfPackages
            // 
            this.txtNumberOfPackages.Location = new System.Drawing.Point(202, 25);
            this.txtNumberOfPackages.Multiline = true;
            this.txtNumberOfPackages.Name = "txtNumberOfPackages";
            this.txtNumberOfPackages.Size = new System.Drawing.Size(232, 51);
            this.txtNumberOfPackages.TabIndex = 0;
            // 
            // txtPricePackages
            // 
            this.txtPricePackages.Location = new System.Drawing.Point(202, 105);
            this.txtPricePackages.Multiline = true;
            this.txtPricePackages.Name = "txtPricePackages";
            this.txtPricePackages.Size = new System.Drawing.Size(232, 51);
            this.txtPricePackages.TabIndex = 1;
            // 
            // lblNumberOfPackages
            // 
            this.lblNumberOfPackages.AutoSize = true;
            this.lblNumberOfPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPackages.Location = new System.Drawing.Point(8, 41);
            this.lblNumberOfPackages.Name = "lblNumberOfPackages";
            this.lblNumberOfPackages.Size = new System.Drawing.Size(174, 20);
            this.lblNumberOfPackages.TabIndex = 2;
            this.lblNumberOfPackages.Text = "Number of packages";
            // 
            // lblPricePerPackages
            // 
            this.lblPricePerPackages.AutoSize = true;
            this.lblPricePerPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerPackages.Location = new System.Drawing.Point(6, 117);
            this.lblPricePerPackages.Name = "lblPricePerPackages";
            this.lblPricePerPackages.Size = new System.Drawing.Size(164, 20);
            this.lblPricePerPackages.TabIndex = 3;
            this.lblPricePerPackages.Text = "Price Per Packages";
            // 
            // btbCalculate
            // 
            this.btbCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCalculate.Location = new System.Drawing.Point(20, 243);
            this.btbCalculate.Name = "btbCalculate";
            this.btbCalculate.Size = new System.Drawing.Size(150, 51);
            this.btbCalculate.TabIndex = 4;
            this.btbCalculate.Text = "Calculate";
            this.btbCalculate.UseVisualStyleBackColor = true;
            this.btbCalculate.Click += new System.EventHandler(this.btbCalculate_Click);
            // 
            // btbClear
            // 
            this.btbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClear.Location = new System.Drawing.Point(221, 243);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(150, 51);
            this.btbClear.TabIndex = 5;
            this.btbClear.Text = "Clear";
            this.btbClear.UseVisualStyleBackColor = true;
            // 
            // btbExit
            // 
            this.btbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbExit.Location = new System.Drawing.Point(424, 243);
            this.btbExit.Name = "btbExit";
            this.btbExit.Size = new System.Drawing.Size(150, 51);
            this.btbExit.TabIndex = 6;
            this.btbExit.Text = "Exit";
            this.btbExit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumberOfPackages);
            this.groupBox1.Controls.Add(this.txtPricePackages);
            this.groupBox1.Controls.Add(this.lblPricePerPackages);
            this.groupBox1.Controls.Add(this.btbExit);
            this.groupBox1.Controls.Add(this.txtNumberOfPackages);
            this.groupBox1.Controls.Add(this.btbClear);
            this.groupBox1.Controls.Add(this.btbCalculate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 452);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase information";
            // 
            // purchaseResult
            // 
            this.purchaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseResult.FormattingEnabled = true;
            this.purchaseResult.ItemHeight = 20;
            this.purchaseResult.Location = new System.Drawing.Point(746, 12);
            this.purchaseResult.Name = "purchaseResult";
            this.purchaseResult.Size = new System.Drawing.Size(393, 424);
            this.purchaseResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 614);
            this.Controls.Add(this.purchaseResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfPackages;
        private System.Windows.Forms.TextBox txtPricePackages;
        private System.Windows.Forms.Label lblNumberOfPackages;
        private System.Windows.Forms.Label lblPricePerPackages;
        private System.Windows.Forms.Button btbCalculate;
        private System.Windows.Forms.Button btbClear;
        private System.Windows.Forms.Button btbExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox purchaseResult;
    }
}

