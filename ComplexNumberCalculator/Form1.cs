using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumberCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            realTextBox1.Click += realTextBox1_Click;
            realTextBox2.Click += realTextBox2_Click;
            imaginaryTextBox1.Click += imaginaryTextBox1_Click;
            imaginaryTextBox2.Click += imaginaryTextBox2_Click;

            imaginaryTextBox1.TextChanged += imaginaryTextBox1_TextChanged;
            imaginaryTextBox2.TextChanged += imaginaryTextBox2_TextChanged;

            operatorButton1.Click += operatorButton1_Click;
            operatorButton2.Click += operatorButton2_Click;

            operatorButton.Click += operatorButton_Click;

            calculateButton.Click += calculateButton_Click;

            toolStripMenuItem2.Click += aboutMenuItem_Click;
            toolStripMenuItem3.Click += exitMenuItem_Click;
            toolStripMenuItem4.Click += helpMenuItem_Click;
        }
        ComplexArithmetic complexArithmetic = new ComplexArithmetic();

        private void realTextBox1_Click(object sender, EventArgs e)
        {
            realTextBox1.Text = "";
        }
        private void realTextBox2_Click(object sender, EventArgs e)
        {
            realTextBox2.Text = "";
        }
        private void imaginaryTextBox1_Click(object sender, EventArgs e)
        {
            imaginaryTextBox1.Text = "i";
        }
        private void imaginaryTextBox2_Click(object sender, EventArgs e)
        {
            imaginaryTextBox2.Text = "i";
        }

        private void imaginaryTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void imaginaryTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operatorButton1_Click(object sender, EventArgs e)
        {
            if(operatorButton1.Text == "+")
            {
                operatorButton1.Text = "-";
            }
            else if(operatorButton1.Text == "-")
            {
                operatorButton1.Text = "+";
            }
        }

        private void operatorButton2_Click(object sender, EventArgs e)
        {
            if (operatorButton2.Text == "+")
            {
                operatorButton2.Text = "-";
            }
            else if (operatorButton2.Text == "-")
            {
                operatorButton2.Text = "+";
            }
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            if(operatorLabel.Text == "+")
            {
                operatorLabel.Text = "-";
            }
            else if(operatorLabel.Text == "-")
            {
                operatorLabel.Text = "*";
            }
            else if(operatorLabel.Text == "*")
            {
                operatorLabel.Text = "/";
            }
            else if(operatorLabel.Text == "/")
            {
                operatorLabel.Text = "+";
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string r1 = realTextBox1.Text;
            string i1 = imaginaryTextBox1.Text;
            string r2 = realTextBox2.Text;
            string i2 = imaginaryTextBox2.Text;

            var charsToRemove = new string[] { "i", " " };
            foreach(var c in charsToRemove)
            {
                i1 = i1.Replace(c, string.Empty);
                i2 = i2.Replace(c, string.Empty);
            }
            try
            {
                double.TryParse(r1, out double realNumber1);
                double.TryParse(i1, out double imaginaryNumber1);
                double.TryParse(r2, out double realNumber2);
                double.TryParse(i2, out double imaginaryNumber2);

                if(operatorButton1.Text == "-")
                {
                    imaginaryNumber1 = 0.0 - imaginaryNumber1;
                }
                if(operatorButton2.Text == "-")
                {
                    imaginaryNumber2 = 0.0 - imaginaryNumber2;
                }
                ComplexData complexNumber1 = new ComplexData(realNumber1, imaginaryNumber1);
                ComplexData complexNumber2 = new ComplexData(realNumber2, imaginaryNumber2);
                if(operatorLabel.Text == "+")
                {
                    ComplexData answer = complexArithmetic.Calculate(complexNumber1, complexNumber2, new Func<ComplexData, ComplexData, ComplexData>(complexArithmetic.Add));
                    if (answer.ImaginaryNumber < 0)
                    {
                        operatorAnswerTextBox.Text = "-";
                        answer.ImaginaryNumber = 0 - answer.ImaginaryNumber;
                    }
                    else
                    {
                        operatorAnswerTextBox.Text = "+";
                    }
                    decimal realNumber = Convert.ToDecimal(answer.RealNumber);
                    decimal imaginaryNumber = Convert.ToDecimal(answer.ImaginaryNumber);
                    realAnswerTextBox.Text = Decimal.Round(realNumber, 2).ToString();
                    imaginaryAnswerTextBox.Text = Decimal.Round(imaginaryNumber).ToString() + "i";
                }
                else if(operatorLabel.Text == "-")
                {
                    ComplexData answer = complexArithmetic.Calculate(complexNumber1, complexNumber2, new Func<ComplexData, ComplexData, ComplexData>(complexArithmetic.Subtract));
                    if (answer.ImaginaryNumber < 0)
                    {
                        operatorAnswerTextBox.Text = "-";
                        answer.ImaginaryNumber = 0 - answer.ImaginaryNumber;
                    }
                    else
                    {
                        operatorAnswerTextBox.Text = "+";
                    }
                    decimal realNumber = Convert.ToDecimal(answer.RealNumber);
                    decimal imaginaryNumber = Convert.ToDecimal(answer.ImaginaryNumber);
                    realAnswerTextBox.Text = Decimal.Round(realNumber, 2).ToString();
                    imaginaryAnswerTextBox.Text = Decimal.Round(imaginaryNumber).ToString() + "i";
                }
                else if (operatorLabel.Text == "*")
                {
                    ComplexData answer = complexArithmetic.Calculate(complexNumber1, complexNumber2, new Func<ComplexData, ComplexData, ComplexData>(complexArithmetic.Multiply));
                    if (answer.ImaginaryNumber < 0)
                    {
                        operatorAnswerTextBox.Text = "-";
                        answer.ImaginaryNumber = 0 - answer.ImaginaryNumber;
                    }
                    else
                    {
                        operatorAnswerTextBox.Text = "+";
                    }
                    decimal realNumber = Convert.ToDecimal(answer.RealNumber);
                    decimal imaginaryNumber = Convert.ToDecimal(answer.ImaginaryNumber);
                    realAnswerTextBox.Text = Decimal.Round(realNumber, 2).ToString();
                    imaginaryAnswerTextBox.Text = Decimal.Round(imaginaryNumber).ToString() + "i";
                }
                else if (operatorLabel.Text == "/")
                {
                    ComplexData answer = complexArithmetic.Calculate(complexNumber1, complexNumber2, new Func<ComplexData, ComplexData, ComplexData>(complexArithmetic.Divide));
                    if (answer.ImaginaryNumber < 0)
                    {
                        operatorAnswerTextBox.Text = "-";
                        answer.ImaginaryNumber = 0 - answer.ImaginaryNumber;
                    }
                    else
                    {
                        operatorAnswerTextBox.Text = "+";
                    }
                    decimal realNumber = Convert.ToDecimal(answer.RealNumber);
                    decimal imaginaryNumber = Convert.ToDecimal(answer.ImaginaryNumber);
                    realAnswerTextBox.Text = Decimal.Round(realNumber, 2).ToString();
                    imaginaryAnswerTextBox.Text = Decimal.Round(imaginaryNumber).ToString() + "i";
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("You entered an invalid input.");
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complex Number Calculator\nBy: John K Higginson");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input two complex numbers.\nUse buttons to specify positive or negative imaginary numbers.\nSpecify an operator and click calculate.\n\nAnswer is rounded to two decimal places.");
        }
    }
}
