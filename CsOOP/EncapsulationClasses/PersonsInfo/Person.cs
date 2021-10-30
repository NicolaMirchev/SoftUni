using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
   public class Person
    {
        public Person(string firstN, string lastN, int age, decimal salary)
        {
            FirstName = firstN;
            LastName = lastN;
            Age = age;
            Salary = salary;
        }


        public decimal Salary { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage = percentage / 2;
            }
            Salary = Salary + percentage / 100 * Salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} recieves {Salary:f2} leva.";
        }
    }
}
