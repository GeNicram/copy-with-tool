﻿namespace CopyAndArchive
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
            this.textBoxTool = new System.Windows.Forms.TextBox();
            this.buttonTool = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSource = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tool";
            // 
            // textBoxTool
            // 
            this.textBoxTool.Location = new System.Drawing.Point(15, 25);
            this.textBoxTool.Name = "textBoxTool";
            this.textBoxTool.Size = new System.Drawing.Size(456, 20);
            this.textBoxTool.TabIndex = 1;
            // 
            // buttonTool
            // 
            this.buttonTool.Location = new System.Drawing.Point(477, 23);
            this.buttonTool.Name = "buttonTool";
            this.buttonTool.Size = new System.Drawing.Size(75, 23);
            this.buttonTool.TabIndex = 2;
            this.buttonTool.Text = "Select Tool";
            this.buttonTool.UseVisualStyleBackColor = true;
            this.buttonTool.Click += new System.EventHandler(this.buttonSelectFile);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(15, 64);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(456, 20);
            this.textBoxCommand.TabIndex = 3;
            this.textBoxCommand.Text = "{0} {1}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "explanation:\r\nadditional options:";
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(477, 143);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSource.TabIndex = 6;
            this.buttonSource.Text = "Select";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSelectDirectory);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Source directory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destination directory";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(15, 184);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(456, 20);
            this.textBoxDestination.TabIndex = 9;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(15, 145);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(456, 20);
            this.textBoxSource.TabIndex = 10;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(15, 223);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(456, 186);
            this.listBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Files to be copied with selected tool";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 415);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 14;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDestination
            // 
            this.buttonDestination.Location = new System.Drawing.Point(477, 182);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(75, 23);
            this.buttonDestination.TabIndex = 15;
            this.buttonDestination.Text = "Select";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.buttonSelectDirectory);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(96, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "{0} - source, {1} - destination\r\nd - use file directory, n - use file name, e - u" +
    "se file extension\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonDestination);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonTool);
            this.Controls.Add(this.textBoxTool);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTool;
        private System.Windows.Forms.Button buttonTool;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
    }
}

