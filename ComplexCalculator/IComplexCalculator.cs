using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public interface IComplexCalculator
    {
        ComplexNumber Add(ComplexNumber op1, ComplexNumber op2);
        ComplexNumber Subtract(ComplexNumber op1, ComplexNumber op2);
        ComplexNumber Multiply(ComplexNumber op1, ComplexNumber op2);
        ComplexNumber Divide(ComplexNumber op1, ComplexNumber op2);
        decimal GetServiceFee();
    }
}
