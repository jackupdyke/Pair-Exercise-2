using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.CRM;

namespace PetElevator.Tests
{[TestClass]
    public class PetTests
    {
        [TestMethod]
        public void ListVaccinationsTest()
        {
            Pet testObject = new Pet("FakeName", "RealSpecies");

            testObject.Vaccinations.Add("Rabies");
            testObject.Vaccinations.Add("Distemper");
            testObject.Vaccinations.Add("Parvo");



            Assert.AreEqual("Rabies, Distemper, Parvo",(testObject.ListVaccinations()));
        }

      //  ["Rabies", "Distemper", "Parvo"], the output must be "Rabies, Distemper, Parvo".
    }
}
