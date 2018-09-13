using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.CalculatorSoapClient CalcRef;

        [TestMethod]
        public void TestAdd()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        }

        [TestMethod]
        public void TestSubtrct()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.Subtrct(5, 2.4);
            Assert.AreEqual(d, 2.6);
        }

        [TestMethod]
        public void TestMultiply()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.Multiply(5, 2.4);
            Assert.AreEqual(d, 12);
        }

        [TestMethod]
        public void TestDivide()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.Divide(6, 3);
            Assert.AreEqual(d, 2);
        }

        [TestMethod]
        public void TestSqrRoot()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.SqrRoot(81);
            Assert.AreEqual(d, 9);
        }

        [TestMethod]
        public void TestByTwo()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.ByTwo(18);
            Assert.AreEqual(d, 9);
        }

        [TestMethod]
        public void TestByFour()
        {
            CalcRef = new Calculator.CalculatorSoapClient();
            double d = CalcRef.ByFour(16);
            Assert.AreEqual(d, 4);
        }
    }
}

