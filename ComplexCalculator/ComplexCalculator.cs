using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public class ComplexCalculator : IComplexCalculator
    {
        private IUser _user;

        public ComplexCalculator(IUser user)
        {
            _user = user;
        }

        public  ComplexNumber Add(ComplexNumber op1, ComplexNumber op2)
        {
            _user.IncreaseAddTime();
            return new ComplexNumber(op1.Real + op2.Real, op1.Image + op2.Image);
        }

        public ComplexNumber Subtract(ComplexNumber op1, ComplexNumber op2)
        {
            _user.IncreaseSubctractTime();
            return new ComplexNumber(op1.Real - op2.Real, op1.Image - op2.Image);
        }

        public ComplexNumber Multiply(ComplexNumber op1, ComplexNumber op2)
        {
            _user.IncreaseMultiplyTime();
            return new ComplexNumber(op1.Real*op2.Real-op1.Image*op2.Image, op1.Real*op2.Image + op1.Image*op2.Real);
        }

        public ComplexNumber Divide(ComplexNumber op1, ComplexNumber op2)
        {
            var a = op1.Real;
            var b = op1.Image;
            var c = op2.Real;
            var d = op2.Image;
            if(c==0 && d==0) throw new ArithmeticException("Divide by zero is not allowed");
            _user.IncreaseDivideTime();
            return new ComplexNumber((a*c+b*d)/(c*c+d*d), (b*c-a*d)/(c*c+d*d));
        }

        public decimal GetServiceFee()
        {
            return _user.CalculateServiceFee();
        }
    }
}
