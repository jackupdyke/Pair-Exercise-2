using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Shared
{
    public class Customer : Person, IBillable
    {

        public string PhoneNumber { get; set; }
        public List<string> Pets { get; set; }
        public Dictionary<string, double> ServicesRendered { get; set; }

        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
            ServicesRendered = new Dictionary<string, double>();

        }

        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {
            PhoneNumber = "";
            ServicesRendered = new Dictionary<string, double>();
        }

        
       public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double totalCustomerAmountDue = 0;

            foreach(KeyValuePair<string, double> kvp in servicesRendered)
            {
                totalCustomerAmountDue += kvp.Value;
            }

            return totalCustomerAmountDue;
        }

    }
}
