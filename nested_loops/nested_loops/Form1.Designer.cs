namespace nested_loops
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbDecision = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtYearsEX = new System.Windows.Forms.TextBox();
            this.btbCheckQualification = new System.Windows.Forms.Button();
            this.btbClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter years ex";
            // 
            // btbDecision
            // 
            this.btbDecision.AutoSize = true;
            this.btbDecision.Location = new System.Drawing.Point(338, 182);
            this.btbDecision.Name = "btbDecision";
            this.btbDecision.Size = new System.Drawing.Size(118, 20);
            this.btbDecision.TabIndex = 2;
            this.btbDecision.Text = "Decision rsult";
            // 
            // lblDecision
            // 
            this.lblDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecision.Location = new System.Drawing.Point(181, 234);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(423, 59);
            this.lblDecision.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(316, 41);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(230, 41);
            this.txtSalary.TabIndex = 4;
            // 
            // txtYearsEX
            // 
            this.txtYearsEX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearsEX.Location = new System.Drawing.Point(316, 103);
            this.txtYearsEX.Multiline = true;
            this.txtYearsEX.Name = "txtYearsEX";
            this.txtYearsEX.Size = new System.Drawing.Size(230, 41);
            this.txtYearsEX.TabIndex = 5;
            // 
            // btbCheckQualification
            // 
            this.btbCheckQualification.Location = new System.Drawing.Point(144, 321);
            this.btbCheckQualification.Name = "btbCheckQualification";
            this.btbCheckQualification.Size = new System.Drawing.Size(177, 55);
            this.btbCheckQualification.TabIndex = 6;
            this.btbCheckQualification.Text = "&CheckQaulification";
            this.btbCheckQualification.UseVisualStyleBackColor = true;
            this.btbCheckQualification.Click += new System.EventHandler(this.button1_Click);
            // 
            // btbClear
            // 
            this.btbClear.Location = new System.Drawing.Point(342, 330);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(140, 41);
            this.btbClear.TabIndex = 7;
            this.btbClear.Text = "&Clear";
            this.btbClear.UseVisualStyleBackColor = true;
            this.btbClear.Click += new System.EventHandler(this.btbClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btbClear);
            this.Controls.Add(this.btbCheckQualification);
            this.Controls.Add(this.txtYearsEX);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.btbDecision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btbDecision;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtYearsEX;
        private System.Windows.Forms.Button btbCheckQualification;
        private System.Windows.Forms.Button btbClear;
        private System.Windows.Forms.Button button3;
    }
}

