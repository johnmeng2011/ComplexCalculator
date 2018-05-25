using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexCalculator;
using FluentAssertions;
using NUnit.Framework;

namespace ComplexCalculatorTest
{
    [TestFixture]
    public class ComplexCalculatorTest
    {
        private IComplexCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new ComplexCalculator.ComplexCalculator();
        }


        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.TestCases))]
        
        public void TestAdd(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Add(op1, op2).Should().Be(result);

        }
    }
}
