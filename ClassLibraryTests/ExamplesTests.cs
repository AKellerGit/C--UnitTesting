using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace ClassLibraryTests
{
    [TestClass]
    public class ExamplesTests
    {
        [TestMethod]
        public void ExampleLoadTextFile_Valid()
        {
            string actual = Examples.ExampleLoadTextFile("This is a vlid file name.");

            Assert.IsTrue(actual.Length > 0);
        }

        [TestMethod]
        public void ExampleLoadTextFile_InvalidName()
        {
            Assert.ThrowsException<ArgumentException>(() => Examples.ExampleLoadTextFile(""));
        }
    }
}
