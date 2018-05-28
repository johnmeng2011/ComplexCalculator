using ComplexCalculator;
using ComplexCalculatorTest;
using FluentAssertions;
using NUnit.Framework;
using NSubstitute;

namespace  CalculatorTest
{
    [TestFixture]
    public class ParameterizedCalculatorTest
    {
        private IComplexCalculator _calculator;
        private IUser _user;

        [SetUp]
        public void SetUp()
        {
            _user = Substitute.For<IUser>();
            _user.CalculateServiceFee().Returns((decimal)10.0);
            _calculator = new ComplexCalculator.ComplexCalculator(_user);
        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.AddTestCases))]

        public void TestAdd(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Add(op1, op2).Should().Be(result);
            _user.Received().IncreaseAddTime();
            _user.DidNotReceive().IncreaseDivideTime();
            _user.DidNotReceive().IncreaseSubctractTime();
            _user.DidNotReceive().IncreaseMultiplyTime();

        }
    
       [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.SubtractTestCases))]

        public void TestSubtract(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Subtract(op1, op2).Should().Be(result);
            _user.Received().IncreaseSubctractTime();
            _user.DidNotReceive().IncreaseAddTime();
            _user.DidNotReceive().IncreaseDivideTime();
            _user.DidNotReceive().IncreaseMultiplyTime();

        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.MultiplyTestCases))]

        public void TestMultiply(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Multiply(op1, op2).Should().Be(result);
            _user.Received().IncreaseMultiplyTime();
            _user.DidNotReceive().IncreaseSubctractTime();
            _user.DidNotReceive().IncreaseAddTime();
            _user.DidNotReceive().IncreaseDivideTime();
        }

        [Test, TestCaseSource(typeof(ComplexCalculatorTestFactory), nameof(ComplexCalculatorTestFactory.DivideTestCases))]

        public void TestDivide(ComplexNumber op1, ComplexNumber op2, ComplexNumber result)
        {
            _calculator.Divide(op1, op2).Should().Be(result);
            _user.Received().IncreaseDivideTime();
            _user.DidNotReceive().IncreaseAddTime();
            _user.DidNotReceive().IncreaseSubctractTime();
            _user.DidNotReceive().IncreaseMultiplyTime();
        }

        [Test]
        public void GetServiceFee()
        {
            _calculator.GetServiceFee().Should().Be((decimal) 10.0);
            _user.Received().CalculateServiceFee();
            _user.DidNotReceive().IncreaseAddTime();
            _user.DidNotReceive().IncreaseSubctractTime();
            _user.DidNotReceive().IncreaseMultiplyTime();
            _user.DidNotReceive().IncreaseDivideTime();
        }

    }
}