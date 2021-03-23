
namespace Basic_Calculator
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
            this.one = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 59);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(105, 45);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 43);
            this.textBox1.TabIndex = 1;
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(123, 59);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(105, 45);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(123, 110);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(105, 45);
            this.five.TabIndex = 3;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 110);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(105, 45);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(234, 59);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(105, 45);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(345, 59);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(105, 45);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(234, 163);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(105, 45);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(123, 161);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(105, 45);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button8_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 161);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(105, 45);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(234, 110);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(105, 45);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(234, 212);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(105, 45);
            this.equals.TabIndex = 11;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(12, 212);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(105, 45);
            this.comma.TabIndex = 12;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(123, 212);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(105, 45);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(345, 161);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(105, 45);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(345, 212);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 45);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button15_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(345, 112);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(105, 45);
            this.times.TabIndex = 16;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.button16_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(456, 59);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(131, 198);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 330);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.times);
            this.Controls.Add(this.add);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button clear;
    }
}

