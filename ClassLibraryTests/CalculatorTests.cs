using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTests
{
    [TestClass]
    public class CalculatorTests
    {
        //says its a test and tells to run in testrunner
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 3, 5.0)]
        [DataRow(4.5, 3.9, 8.4)]
        public void Add_SimpleValuesCalculate(double x, double y, double z)
        {
            double a = Calculator.Add(x, y);

            Assert.AreEqual(a, z, 0, "Addition Failed");
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(5,4,1.25)]
        [DataRow(6,3,2)]
        [DataRow(5,0,0)]
        public void Divide_Calculate(double x , double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.AreEqual(expected, actual, 0, "Failed Divide Test");
        }
    }
}
