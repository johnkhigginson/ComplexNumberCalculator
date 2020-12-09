using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ComplexNumberCalculator
{
    class ComplexData
    {
        public double ImaginaryNumber
        {
            get;
            set;
        }

        public double RealNumber
        {
            get;
            set;
        }


        public ComplexData(string realNumber, string imaginaryNumber)
        {
            if(double.TryParse(realNumber, out double result1))
            {
                this.RealNumber = result1;
            }
            else
            {
                MessageBox.Show("{0} is not a valid input", realNumber);
            }
            if(double.TryParse(imaginaryNumber, out double result2))
            {
                this.ImaginaryNumber = result2;
            }
            else
            {
                MessageBox.Show("{0} is not a valid input", imaginaryNumber);
            }
        }

        public ComplexData(double realNumber, double imaginaryNumber)
        {
            this.RealNumber = realNumber;
            this.ImaginaryNumber = imaginaryNumber;
        }

        public static ComplexData operator +(ComplexData cn1, ComplexData cn2)
        {
            return new ComplexData(cn1.RealNumber + cn2.RealNumber, cn1.ImaginaryNumber + cn2.ImaginaryNumber);
        }

        public static ComplexData operator -(ComplexData cn1, ComplexData cn2)
        {
            return new ComplexData(cn1.RealNumber - cn2.RealNumber, cn1.ImaginaryNumber - cn2.ImaginaryNumber);
        }

        public static ComplexData operator *(ComplexData cn1, ComplexData cn2)
        {
            return new ComplexData(cn1.RealNumber * cn2.RealNumber - cn1.ImaginaryNumber * cn2.ImaginaryNumber, cn1.ImaginaryNumber * cn2.RealNumber + cn1.RealNumber * cn2.ImaginaryNumber);
        }

        public static ComplexData operator /(ComplexData cn1, ComplexData cn2)
        {
            return new ComplexData((cn1.RealNumber * cn2.RealNumber + cn1.ImaginaryNumber * cn2.ImaginaryNumber) / (cn2.RealNumber * cn2.RealNumber + cn2.ImaginaryNumber * cn2.ImaginaryNumber), (cn1.ImaginaryNumber * cn2.RealNumber - cn1.RealNumber * cn2.ImaginaryNumber) / (cn2.RealNumber * cn2.RealNumber + cn2.ImaginaryNumber * cn2.ImaginaryNumber));

        }
    }
}
