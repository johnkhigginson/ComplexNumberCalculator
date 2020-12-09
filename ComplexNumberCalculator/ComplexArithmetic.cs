using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumberCalculator
{
    class ComplexArithmetic
    {
        public ComplexArithmetic()
        {

        }

        public ComplexData Add(ComplexData cn1, ComplexData cn2)
        {
            return cn1 + cn2;
        }

        public ComplexData Subtract(ComplexData cn1, ComplexData cn2)
        {
            return cn1 - cn2;
        }

        public ComplexData Multiply(ComplexData cn1, ComplexData cn2)
        {
            return cn1 * cn2;
        }

        public ComplexData Divide(ComplexData cn1, ComplexData cn2)
        {
            return cn1 / cn2;
        }

        public ComplexData Calculate(ComplexData cn1, ComplexData cn2, Func<ComplexData, ComplexData, ComplexData> calc)
        {
            return calc(cn1, cn2);
        }
    }


    
}
