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
    public class ExamplesTests
    {
        [TestMethod]
        public void ExampleLoadTextFile_Valid()
        {
            string actual = Examples.ExampleLoadTextFile("This is a vlid file name.");

            Assert.IsTrue(actual.Length > 0);
        }
    }
}
