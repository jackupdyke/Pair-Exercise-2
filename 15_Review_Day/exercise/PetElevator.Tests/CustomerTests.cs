using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.Shared;

namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueTest()
        {

            Customer testObject = new Customer("nameFirst", "nameLast");

            testObject.servicesRendered.Add("Walking", 50);


            Assert.AreEqual(50, testObject.GetBalanceDue(testObject.servicesRendered));



        }
    }
}
