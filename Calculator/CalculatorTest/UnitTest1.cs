using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTwoNumbers_ShouldBeAdded_OK()
        {
           int a = 3;
            int b = 3;
            string Plus = "+";
            int expected = 6;

            Calculator.Math m = new Calculator.Math(a, b, Plus);

            int actual = m.intPlus(a,b);
            Assert.AreEqual(expected, actual, 0.001, "added correctly");

        }

        [TestMethod]
        public void MinusTwoNumbers_ShouldBeDeminished_OK()
        {
            int a = 3;
            int b = 3;
            string Minus = "-";
            int expected = 0;

            Calculator.Math m = new Calculator.Math(a, b, Minus);

            int actual = m.intMinus(a, b);
            Assert.AreEqual(expected, actual, 0.001, "deminished correctly");

        }

        [TestMethod]
        public void MultiplyTwoNumbers_ShouldBeMultiplied_OK()
        {
            int a = 3;
            int b = 3;
            string Multiply = "*";
            int expected = 9;

            Calculator.Math m = new Calculator.Math(a, b, Multiply);

            int actual = m.intMultiply(a, b);
            Assert.AreEqual(expected, actual, 0.001, "Multiplied correctly");

        }

        [TestMethod]
        public void DivisionTwoNumbers_ShouldBeDivisioned_OK()
        {
            int a = 3;
            int b = 3;
            string Division = "/";
            int expected = 1;

            Calculator.Math m = new Calculator.Math(a, b, Division);

            int actual = m.intDivision(a, b);
            Assert.AreEqual(expected, actual, 0.001, "Divisioned correctly");

        }
    }
}



