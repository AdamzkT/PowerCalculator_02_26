using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power;

namespace PowerTests
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            var power = new PowerCalculator();
            int a = 2;
            int b = 3;
            double eredmeny = 8;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestZeroExponent()
        {
            var power = new PowerCalculator();
            int a = 5;
            int b = 0;
            double eredmeny = 1;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestNegativeExponent()
        {
            var power = new PowerCalculator();
            int a = 2;
            int b = -2;
            double eredmeny = 0.25;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestZeroBasePositiveExponent()
        {
            var power = new PowerCalculator();
            int a = 0;
            int b = 5;
            double eredmeny = 0;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {
            var power = new PowerCalculator();
            int a = 0;
            int b = 0;
            double eredmeny = 1;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestOneBaseAnyExponent()
        {
            var power = new PowerCalculator();
            int a = 1;
            int b = 100;
            double eredmeny = 1;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {
            var power = new PowerCalculator();
            int a = -3;
            int b = 4;
            double eredmeny = 81;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {
            var power = new PowerCalculator();
            int a = -2;
            int b = 3;
            double eredmeny = -8;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }

        [TestMethod]
        public void TestNegativeBaseNegativeExponent()
        {
            var power = new PowerCalculator();
            int a = -2;
            int b = -2;
            double eredmeny = 0.25;

            double result = power.CalculatePower(a, b);

            Assert.AreEqual(eredmeny, result);
        }
    }
}
