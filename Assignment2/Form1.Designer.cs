namespace Assignment2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentid = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnShowinfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(676, 21);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(406, 54);
            this.txtName.TabIndex = 0;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Location = new System.Drawing.Point(676, 177);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(406, 54);
            this.txtDepartment.TabIndex = 1;
            // 
            // txtStudentid
            // 
            this.txtStudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentid.Location = new System.Drawing.Point(676, 95);
            this.txtStudentid.Multiline = true;
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(406, 54);
            this.txtStudentid.TabIndex = 2;
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Location = new System.Drawing.Point(676, 256);
            this.txtsemester.Multiline = true;
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(406, 54);
            this.txtsemester.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(438, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(203, 41);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Enter the student name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStudentid
            // 
            this.lblStudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentid.Location = new System.Drawing.Point(438, 108);
            this.lblStudentid.Name = "lblStudentid";
            this.lblStudentid.Size = new System.Drawing.Size(203, 41);
            this.lblStudentid.TabIndex = 5;
            this.lblStudentid.Text = "Enter the student ID";
            // 
            // lblSemester
            // 
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(438, 269);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(203, 41);
            this.lblSemester.TabIndex = 6;
            this.lblSemester.Text = "Enter the semester";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(438, 190);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(203, 41);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Enter the department";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(438, 377);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(644, 70);
            this.lblOutput.TabIndex = 8;
            // 
            // btnShowinfo
            // 
            this.btnShowinfo.Location = new System.Drawing.Point(442, 483);
            this.btnShowinfo.Name = "btnShowinfo";
            this.btnShowinfo.Size = new System.Drawing.Size(221, 48);
            this.btnShowinfo.TabIndex = 9;
            this.btnShowinfo.Text = "show information";
            this.btnShowinfo.UseVisualStyleBackColor = true;
            this.btnShowinfo.Click += new System.EventHandler(this.btnShowinfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(718, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 60);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(961, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 655);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowinfo);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblStudentid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtStudentid);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtStudentid;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentid;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnShowinfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

