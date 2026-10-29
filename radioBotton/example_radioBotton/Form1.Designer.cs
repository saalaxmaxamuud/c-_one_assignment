namespace example_radioBotton
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
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBusiness = new System.Windows.Forms.CheckBox();
            this.checkIt = new System.Windows.Forms.CheckBox();
            this.checkComputer = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btbClose = new System.Windows.Forms.Button();
            this.btbClear = new System.Windows.Forms.Button();
            this.btbSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.Location = new System.Drawing.Point(449, 242);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(88, 24);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.Location = new System.Drawing.Point(273, 243);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(104, 24);
            this.radioMale.TabIndex = 4;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(238, 143);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(223, 39);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Enter Age";
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(238, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(223, 39);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter Name";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(467, 132);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(233, 50);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(467, 46);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 50);
            this.txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBusiness);
            this.groupBox2.Controls.Add(this.checkIt);
            this.groupBox2.Controls.Add(this.checkComputer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(152, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "choose faculty";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBusiness
            // 
            this.checkBusiness.AutoSize = true;
            this.checkBusiness.Location = new System.Drawing.Point(459, 48);
            this.checkBusiness.Name = "checkBusiness";
            this.checkBusiness.Size = new System.Drawing.Size(108, 24);
            this.checkBusiness.TabIndex = 2;
            this.checkBusiness.Text = "Business";
            this.checkBusiness.UseVisualStyleBackColor = true;
            // 
            // checkIt
            // 
            this.checkIt.AutoSize = true;
            this.checkIt.Location = new System.Drawing.Point(254, 48);
            this.checkIt.Name = "checkIt";
            this.checkIt.Size = new System.Drawing.Size(51, 24);
            this.checkIt.TabIndex = 1;
            this.checkIt.Text = "IT";
            this.checkIt.UseVisualStyleBackColor = true;
            // 
            // checkComputer
            // 
            this.checkComputer.AutoSize = true;
            this.checkComputer.Location = new System.Drawing.Point(31, 48);
            this.checkComputer.Name = "checkComputer";
            this.checkComputer.Size = new System.Drawing.Size(110, 24);
            this.checkComputer.TabIndex = 0;
            this.checkComputer.Text = "computer";
            this.checkComputer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btbClose);
            this.groupBox3.Controls.Add(this.btbClear);
            this.groupBox3.Controls.Add(this.btbSave);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(83, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btbClose
            // 
            this.btbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClose.Location = new System.Drawing.Point(528, 60);
            this.btbClose.Name = "btbClose";
            this.btbClose.Size = new System.Drawing.Size(116, 44);
            this.btbClose.TabIndex = 2;
            this.btbClose.Text = "Close";
            this.btbClose.UseVisualStyleBackColor = true;
            // 
            // btbClear
            // 
            this.btbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClear.Location = new System.Drawing.Point(238, 60);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(116, 44);
            this.btbClear.TabIndex = 1;
            this.btbClear.Text = "Clear";
            this.btbClear.UseVisualStyleBackColor = true;
            this.btbClear.Click += new System.EventHandler(this.btbClear_Click);
            // 
            // btbSave
            // 
            this.btbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSave.Location = new System.Drawing.Point(51, 60);
            this.btbSave.Name = "btbSave";
            this.btbSave.Size = new System.Drawing.Size(116, 44);
            this.btbSave.TabIndex = 0;
            this.btbSave.Text = "Save As";
            this.btbSave.UseVisualStyleBackColor = true;
            this.btbSave.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(924, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 631);
            this.Controls.Add(this.listBox1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBusiness;
        private System.Windows.Forms.CheckBox checkIt;
        private System.Windows.Forms.CheckBox checkComputer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btbSave;
        private System.Windows.Forms.Button btbClose;
        private System.Windows.Forms.Button btbClear;
        private System.Windows.Forms.ListBox listBox1;
    }
}

