using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string number1 = string.Empty;
        string number2 = string.Empty;
        char op;
        double answer = 0.0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //number 1
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input; 
        }

        private void button2_Click_1(object sender, EventArgs e) //number 2
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e) //number 3
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e) //number 4
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e) //number 5
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e) //number 6
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e) //number 7
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e) //number 8
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e) //number 9
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e) //number 0
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void comma_Click(object sender, EventArgs e) //comma
        {
            this.textBox1.Text = "";
            input += ",";
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e) //times operator
        {
            number1 = input;
            op = '*';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e) //plus operator
        {
            number1 = input;
            op = '+';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e) //divide operator
        {
            number1 = input;
            op = '/';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e) //minus operator
        {
            number1 = input;
            op = '-';
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e) //clear
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.number1 = string.Empty;
            this.number2 = string.Empty;
        }

     
        private void equals_Click(object sender, EventArgs e) //equals
        {
            number2 = input;
            double num1, num2;
            double.TryParse(number1, out num1);
            double.TryParse(number2, out num2);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.number1 = string.Empty;
            this.number2 = string.Empty;
            if(op == '+')
            {
                answer = num1 + num2;
                textBox1.Text = answer.ToString();
            }
            else if(op == '-')
            {
                answer = num1 - num2;
                textBox1.Text = answer.ToString();
            }
            else if(op == '*')
            {
                answer = num1 * num2;
                textBox1.Text = answer.ToString();
            }
            else if(op == '/')
            {
                if(num2 != 0)
                {
                    answer = num1 / num2;
                    textBox1.Text = answer.ToString();
                }
                else
                {
                    textBox1.Text = "Error Can't Divide by Zero!!";
                }
            }
        }
    }
}
