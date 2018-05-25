using ComplexCalculator;
using ComplexCalculatorTest;
using FluentAssertions;
using NUnit.Framework;

namespace  CalculatorTest
{
    [TestFixture]
    public class ParameterizedCalculatorTest
    {
        private IComplexCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new ComplexCalculator.ComplexCalculator();
        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.AddTestCases))]

        public void TestAdd(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Add(op1, op2).Should().Be(result);
        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.SubtractTestCases))]

        public void TestSubtract(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Subtract(op1, op2).Should().Be(result);

        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.MultiplyTestCases))]

        public void TestMultiply(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Multiply(op1, op2).Should().Be(result);

        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.DivideTestCases))]

        public void TestDivide(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Divide(op1, op2).Should().Be(result);

        }

    }
}