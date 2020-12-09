namespace ComplexNumberCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.realTextBox1 = new System.Windows.Forms.TextBox();
            this.realLabel1 = new System.Windows.Forms.Label();
            this.operatorButton1 = new System.Windows.Forms.Button();
            this.imaginaryTextBox1 = new System.Windows.Forms.TextBox();
            this.imaginaryLabel1 = new System.Windows.Forms.Label();
            this.realLabel2 = new System.Windows.Forms.Label();
            this.realTextBox2 = new System.Windows.Forms.TextBox();
            this.operatorButton2 = new System.Windows.Forms.Button();
            this.imaginaryTextBox2 = new System.Windows.Forms.TextBox();
            this.imaginaryLabel2 = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.imaginaryAnswerTextBox = new System.Windows.Forms.TextBox();
            this.realAnswerTextBox = new System.Windows.Forms.TextBox();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Label();
            this.operatorAnswerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(282, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItem2.Text = "About";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItem3.Text = "Exit";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem4.Text = "Help";
            // 
            // realTextBox1
            // 
            this.realTextBox1.Location = new System.Drawing.Point(11, 61);
            this.realTextBox1.Name = "realTextBox1";
            this.realTextBox1.Size = new System.Drawing.Size(95, 27);
            this.realTextBox1.TabIndex = 1;
            this.realTextBox1.Text = "0.0";
            this.realTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // realLabel1
            // 
            this.realLabel1.AutoSize = true;
            this.realLabel1.Location = new System.Drawing.Point(11, 37);
            this.realLabel1.Name = "realLabel1";
            this.realLabel1.Size = new System.Drawing.Size(96, 20);
            this.realLabel1.TabIndex = 2;
            this.realLabel1.Text = "Real Number";
            this.realLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operatorButton1
            // 
            this.operatorButton1.Location = new System.Drawing.Point(120, 60);
            this.operatorButton1.Name = "operatorButton1";
            this.operatorButton1.Size = new System.Drawing.Size(42, 29);
            this.operatorButton1.TabIndex = 3;
            this.operatorButton1.Text = "+";
            this.operatorButton1.UseVisualStyleBackColor = true;
            // 
            // imaginaryTextBox1
            // 
            this.imaginaryTextBox1.Location = new System.Drawing.Point(174, 61);
            this.imaginaryTextBox1.Name = "imaginaryTextBox1";
            this.imaginaryTextBox1.Size = new System.Drawing.Size(95, 27);
            this.imaginaryTextBox1.TabIndex = 1;
            this.imaginaryTextBox1.Text = "0.0i";
            this.imaginaryTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imaginaryLabel1
            // 
            this.imaginaryLabel1.AutoSize = true;
            this.imaginaryLabel1.Location = new System.Drawing.Point(185, 37);
            this.imaginaryLabel1.Name = "imaginaryLabel1";
            this.imaginaryLabel1.Size = new System.Drawing.Size(75, 20);
            this.imaginaryLabel1.TabIndex = 2;
            this.imaginaryLabel1.Text = "Imaginary";
            this.imaginaryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realLabel2
            // 
            this.realLabel2.AutoSize = true;
            this.realLabel2.Location = new System.Drawing.Point(11, 103);
            this.realLabel2.Name = "realLabel2";
            this.realLabel2.Size = new System.Drawing.Size(96, 20);
            this.realLabel2.TabIndex = 2;
            this.realLabel2.Text = "Real Number";
            this.realLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realTextBox2
            // 
            this.realTextBox2.Location = new System.Drawing.Point(11, 125);
            this.realTextBox2.Name = "realTextBox2";
            this.realTextBox2.Size = new System.Drawing.Size(95, 27);
            this.realTextBox2.TabIndex = 1;
            this.realTextBox2.Text = "0.0";
            this.realTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operatorButton2
            // 
            this.operatorButton2.Location = new System.Drawing.Point(120, 125);
            this.operatorButton2.Name = "operatorButton2";
            this.operatorButton2.Size = new System.Drawing.Size(42, 29);
            this.operatorButton2.TabIndex = 3;
            this.operatorButton2.Text = "+";
            this.operatorButton2.UseVisualStyleBackColor = true;
            // 
            // imaginaryTextBox2
            // 
            this.imaginaryTextBox2.Location = new System.Drawing.Point(174, 125);
            this.imaginaryTextBox2.Name = "imaginaryTextBox2";
            this.imaginaryTextBox2.Size = new System.Drawing.Size(95, 27);
            this.imaginaryTextBox2.TabIndex = 1;
            this.imaginaryTextBox2.Text = "0.0i";
            this.imaginaryTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imaginaryLabel2
            // 
            this.imaginaryLabel2.AutoSize = true;
            this.imaginaryLabel2.Location = new System.Drawing.Point(185, 103);
            this.imaginaryLabel2.Name = "imaginaryLabel2";
            this.imaginaryLabel2.Size = new System.Drawing.Size(75, 20);
            this.imaginaryLabel2.TabIndex = 2;
            this.imaginaryLabel2.Text = "Imaginary";
            this.imaginaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(11, 176);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(258, 3);
            this.divider.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(174, 196);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 29);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(11, 196);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(94, 29);
            this.operatorButton.TabIndex = 5;
            this.operatorButton.Text = "Operator";
            this.operatorButton.UseVisualStyleBackColor = true;
            // 
            // imaginaryAnswerTextBox
            // 
            this.imaginaryAnswerTextBox.Location = new System.Drawing.Point(174, 264);
            this.imaginaryAnswerTextBox.Name = "imaginaryAnswerTextBox";
            this.imaginaryAnswerTextBox.ReadOnly = true;
            this.imaginaryAnswerTextBox.Size = new System.Drawing.Size(95, 27);
            this.imaginaryAnswerTextBox.TabIndex = 1;
            this.imaginaryAnswerTextBox.Text = "0.0i";
            this.imaginaryAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // realAnswerTextBox
            // 
            this.realAnswerTextBox.Location = new System.Drawing.Point(11, 264);
            this.realAnswerTextBox.Name = "realAnswerTextBox";
            this.realAnswerTextBox.ReadOnly = true;
            this.realAnswerTextBox.Size = new System.Drawing.Size(95, 27);
            this.realAnswerTextBox.TabIndex = 1;
            this.realAnswerTextBox.Text = "0.0";
            this.realAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.operatorLabel.Location = new System.Drawing.Point(123, 187);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(36, 37);
            this.operatorLabel.TabIndex = 6;
            this.operatorLabel.Text = "+";
            this.operatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider2.Location = new System.Drawing.Point(10, 243);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(258, 3);
            this.divider2.TabIndex = 4;
            // 
            // operatorAnswerTextBox
            // 
            this.operatorAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operatorAnswerTextBox.Location = new System.Drawing.Point(115, 264);
            this.operatorAnswerTextBox.Name = "operatorAnswerTextBox";
            this.operatorAnswerTextBox.ReadOnly = true;
            this.operatorAnswerTextBox.Size = new System.Drawing.Size(53, 27);
            this.operatorAnswerTextBox.TabIndex = 7;
            this.operatorAnswerTextBox.Text = "+";
            this.operatorAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 303);
            this.Controls.Add(this.operatorAnswerTextBox);
            this.Controls.Add(this.divider2);
            this.Controls.Add(this.operatorLabel);
            this.Controls.Add(this.realAnswerTextBox);
            this.Controls.Add(this.imaginaryAnswerTextBox);
            this.Controls.Add(this.operatorButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.imaginaryLabel2);
            this.Controls.Add(this.imaginaryTextBox2);
            this.Controls.Add(this.operatorButton2);
            this.Controls.Add(this.realTextBox2);
            this.Controls.Add(this.realLabel2);
            this.Controls.Add(this.imaginaryLabel1);
            this.Controls.Add(this.imaginaryTextBox1);
            this.Controls.Add(this.operatorButton1);
            this.Controls.Add(this.realLabel1);
            this.Controls.Add(this.realTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Complex Calc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox realTextBox1;
        private System.Windows.Forms.Label realLabel1;
        private System.Windows.Forms.Button operatorButton1;
        private System.Windows.Forms.TextBox imaginaryTextBox1;
        private System.Windows.Forms.Label imaginaryLabel1;
        private System.Windows.Forms.Label realLabel2;
        private System.Windows.Forms.TextBox realTextBox2;
        private System.Windows.Forms.Button operatorButton2;
        private System.Windows.Forms.TextBox imaginaryTextBox2;
        private System.Windows.Forms.Label imaginaryLabel2;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.TextBox imaginaryAnswerTextBox;
        private System.Windows.Forms.TextBox realAnswerTextBox;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Label divider2;
        private System.Windows.Forms.TextBox operatorAnswerTextBox;
    }
}

