using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace ClassLibraryTests
{
    [TestClass]
    class DataAccessTests
    {
        [TestMethod]
        public void AddPersonToPeopleList()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Andrew", LastName = "Keller" };
            List<PersonModel> people = new List<PersonModel>();


            /*pass in people list
             add person to list
             list is reference type so it will change the list
             
             newperson will add the person to the list*/
            DataAccess.AddPersonToPeopleList(people, newPerson);


            //in theory the list will start with nothing so should be true
            Assert.IsTrue(people.Count == 1);

     
        }



    }
}
