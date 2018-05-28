using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexCalculator;
using FluentAssertions;
using NUnit.Framework;
using NSubstitute;

namespace CalculatorTest
{
    [TestFixture]
   public  class SingleCalculatorTest
    {
        private IComplexCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            var user = Substitute.For<IUser>();
            _calculator = new ComplexCalculator.ComplexCalculator(user);
        }
        [Test]
        public void AddTest()
        {
            var a = new ComplexNumber(1, 2);
            var b = new ComplexNumber(3, 4);
            var c = _calculator.Add(a, b);
            c.Should().Be(new ComplexNumber(4, 6));
        }

        [Test]
        public void SubtractTest()
        {
            var a = new ComplexNumber(1, 2);
            var b = new ComplexNumber(3, 4);
            var c = _calculator.Subtract(a, b);
            c.Should().Be(new ComplexNumber(-2, -2));

        }

        [Test]

        public void MultiplyTest()
        {
            var a = new ComplexNumber(1, 2);
            var b = new ComplexNumber(3, 4);
            var c = _calculator.Multiply(a, b);
            c.Should().Be(new ComplexNumber(-5, 10));
        }


        [Test]

        public void DivideTest()
        {
            var a = new ComplexNumber(1, 2);
            var b = new ComplexNumber(3, 4);
            var c = _calculator.Divide(a, b);
            c.Should().Be(new ComplexNumber(.440, 0.080));
        }
    }
}
