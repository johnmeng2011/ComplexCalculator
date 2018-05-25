using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexCalculator;
using NUnit.Framework;

namespace ComplexCalculatorTest
{
    public class ComplexCalculatorTestFactory
    {
        private const string AddTestName = "Comlex Number '{0}' Add Complex Number '{1}'  should return '{2}'";

        public static TestCaseData CreateAddTestCase(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            var t = new TestCaseData(op1, op2, result);
            t.SetName(string.Format(AddTestName, op1,op2, result));
            return t;
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return CreateAddTestCase(new ComplexNumber(1, 2), new ComplexNumber(3, 4), new ComplexNumber(4, 6));
            }
        }
    }
}
