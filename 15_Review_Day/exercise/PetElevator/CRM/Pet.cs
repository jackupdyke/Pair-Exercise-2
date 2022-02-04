using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    public class Pet
    {

        //Properties
        public string PetName { get; set; }

        public string Species { get; set; }

        public List<string> Vaccinations { get; set; }

      //Constructor

        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;
            Vaccinations = new List<string>();
        }

       // Methods

        public string ListVaccinations()
        {
            string list = "";
          for (int i= 0; i<Vaccinations.Count; i++)
            {
                list += Vaccinations[i];
                if (i == (Vaccinations.Count -1)) { break; }
                list += ", ";
            } return list;
        }

}
}
