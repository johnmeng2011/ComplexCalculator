using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
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
            t.SetName(string.Format(AddTestName, op1, op2, result));
            return t;
        }

        private const string SubtractTestName = "Comlex Number '{0}' Subtract Complex Number '{1}'  should return '{2}'";

        public static TestCaseData CreateSubtractTestCase(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            var t = new TestCaseData(op1, op2, result);
            t.SetName(string.Format(SubtractTestName, op1, op2, result));
            return t;
        }

        private const string MultiplyTestName = "Comlex Number '{0}' Multiply Complex Number '{1}'  should return '{2}'";

        public static TestCaseData CreateMultiplyTestCase(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            var t = new TestCaseData(op1, op2, result);
            t.SetName(string.Format(MultiplyTestName, op1, op2, result));
            return t;
        }

        private const string DivideTestName = "Comlex Number '{0}' Divide Complex Number '{1}'  should return '{2}'";

        public static TestCaseData CreateDivideTestCase(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            var t = new TestCaseData(op1, op2, result);
            t.SetName(string.Format(DivideTestName, op1, op2, result));
            return t;
        }

        public static IEnumerable AddTestCases
        {
            get
            {
                yield return CreateAddTestCase(new ComplexNumber(1, 2), new ComplexNumber(3, 4), new ComplexNumber(4, 6));
                yield return CreateAddTestCase(new ComplexNumber(-1, -2), new ComplexNumber(3, 4), new ComplexNumber(2, 2));

            }
        }

        public static IEnumerable SubtractTestCases
        {
            get
            {

                yield return CreateSubtractTestCase(new ComplexNumber(1, 2), new ComplexNumber(3, 4), new ComplexNumber(-2, -2));
                yield return CreateSubtractTestCase(new ComplexNumber(-1, -2), new ComplexNumber(3, 4), new ComplexNumber(-4, -6));
            }
        }

        public static IEnumerable MultiplyTestCases
        {
            get
            {

                yield return CreateMultiplyTestCase(new ComplexNumber(1, 2), new ComplexNumber(3, 4), new ComplexNumber(-5,10));
                yield return CreateMultiplyTestCase(new ComplexNumber(-1, -2), new ComplexNumber(3, 4), new ComplexNumber(5, -10));
            }
        }

          public static IEnumerable DivideTestCases
        {
            get
            {

                yield return CreateDivideTestCase(new ComplexNumber(1, 2), new ComplexNumber(3, 4), new ComplexNumber(.440,0.080));
                yield return CreateDivideTestCase(new ComplexNumber(-1, -2), new ComplexNumber(3, 4), new ComplexNumber(-.440, -0.080));
            }
        }
    }
}
