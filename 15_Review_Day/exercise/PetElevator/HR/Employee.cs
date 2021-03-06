using System.Collections.Generic;
using PetElevator.Shared;

namespace PetElevator.HR
{
    public class Employee : Person
    {
        public int EmployeeId { get; private set; }
        public string Title { get; set; }
        public Department Department { get; set; }
        public double Salary { get; set; }
        public Dictionary<string, double> ServicesRendered { get; set; }

        public override string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public Employee(string firstName, string lastName) : this(firstName, lastName, "", 0)
        {
            ServicesRendered = new Dictionary<string, double>();
        }

        public Employee(string firstName, string lastName, string title, double salary) : base(firstName, lastName)
        {
            Title = title;
            Salary = salary;
            ServicesRendered = new Dictionary<string, double>();
        }

        public void RaiseSalary(double percentage)
        {
            if (percentage > 0)
            {
                Salary *= (percentage / 100) + 1;
            }
        }

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double totalEmployeeAmountDue = 0;

            foreach (KeyValuePair<string, double> kvp in servicesRendered)
            {
                if(kvp.Key != "Walking")
                {
                    totalEmployeeAmountDue += kvp.Value;
                }
                else
                {
                    totalEmployeeAmountDue += (kvp.Value / 2.0);
                }
                
            }

            return totalEmployeeAmountDue;
        }

    }
}
