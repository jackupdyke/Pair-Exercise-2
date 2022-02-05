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
        // Test for 1 service
        public void GetBalanceDueSingleServiceTest()
        {

            Customer testObject = new Customer("nameFirst", "nameLast");

            testObject.ServicesRendered.Add("Walking", 50);

            Assert.AreEqual(50, testObject.GetBalanceDue(testObject.ServicesRendered));


        }
        [TestMethod]
        //Test for multiple services
        public void GetBalanceDueMultipleServicesTest()
        {
            Customer testObject = new Customer("nameFirst", "nameLast");

            testObject.ServicesRendered.Add("Grooming", 100);
            testObject.ServicesRendered.Add("Sitting", 50);

            Assert.AreEqual(150, testObject.GetBalanceDue(testObject.ServicesRendered));
        }
    }
}
