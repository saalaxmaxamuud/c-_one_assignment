namespace Assignment_files
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
            this.btDeleteFile = new System.Windows.Forms.Button();
            this.btDeleteItems = new System.Windows.Forms.Button();
            this.btLines = new System.Windows.Forms.Button();
            this.btreadLines = new System.Windows.Forms.Button();
            this.reading = new System.Windows.Forms.ListBox();
            this.btWriteLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDeleteFile
            // 
            this.btDeleteFile.Location = new System.Drawing.Point(309, 211);
            this.btDeleteFile.Name = "btDeleteFile";
            this.btDeleteFile.Size = new System.Drawing.Size(125, 78);
            this.btDeleteFile.TabIndex = 11;
            this.btDeleteFile.Text = "delete the files";
            this.btDeleteFile.UseVisualStyleBackColor = true;
            this.btDeleteFile.Click += new System.EventHandler(this.btDeleteFile_Click);
            // 
            // btDeleteItems
            // 
            this.btDeleteItems.Location = new System.Drawing.Point(309, 102);
            this.btDeleteItems.Name = "btDeleteItems";
            this.btDeleteItems.Size = new System.Drawing.Size(125, 78);
            this.btDeleteItems.TabIndex = 10;
            this.btDeleteItems.Text = "delete the items";
            this.btDeleteItems.UseVisualStyleBackColor = true;
            this.btDeleteItems.Click += new System.EventHandler(this.btDeleteItems_Click);
            // 
            // btLines
            // 
            this.btLines.Location = new System.Drawing.Point(80, 293);
            this.btLines.Name = "btLines";
            this.btLines.Size = new System.Drawing.Size(175, 73);
            this.btLines.TabIndex = 9;
            this.btLines.Text = "readlines";
            this.btLines.UseVisualStyleBackColor = true;
            this.btLines.Click += new System.EventHandler(this.btLines_Click);
            // 
            // btreadLines
            // 
            this.btreadLines.Location = new System.Drawing.Point(80, 184);
            this.btreadLines.Name = "btreadLines";
            this.btreadLines.Size = new System.Drawing.Size(175, 73);
            this.btreadLines.TabIndex = 8;
            this.btreadLines.Text = "readAllines";
            this.btreadLines.UseVisualStyleBackColor = true;
            this.btreadLines.Click += new System.EventHandler(this.btreadLines_Click);
            // 
            // reading
            // 
            this.reading.FormattingEnabled = true;
            this.reading.ItemHeight = 20;
            this.reading.Location = new System.Drawing.Point(471, 102);
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(249, 264);
            this.reading.TabIndex = 7;
            // 
            // btWriteLines
            // 
            this.btWriteLines.Location = new System.Drawing.Point(93, 84);
            this.btWriteLines.Name = "btWriteLines";
            this.btWriteLines.Size = new System.Drawing.Size(162, 74);
            this.btWriteLines.TabIndex = 6;
            this.btWriteLines.Text = "WriteLine";
            this.btWriteLines.UseVisualStyleBackColor = true;
            this.btWriteLines.Click += new System.EventHandler(this.btWriteLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 522);
            this.Controls.Add(this.btDeleteFile);
            this.Controls.Add(this.btDeleteItems);
            this.Controls.Add(this.btLines);
            this.Controls.Add(this.btreadLines);
            this.Controls.Add(this.reading);
            this.Controls.Add(this.btWriteLines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDeleteFile;
        private System.Windows.Forms.Button btDeleteItems;
        private System.Windows.Forms.Button btLines;
        private System.Windows.Forms.Button btreadLines;
        private System.Windows.Forms.ListBox reading;
        private System.Windows.Forms.Button btWriteLines;
    }
}

