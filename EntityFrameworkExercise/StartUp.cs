using EntityFrameworkExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExercise
{
    public class StartUp
    {

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var allEmplyees = context.Employees.Select(e => new { Name = $"{e.FirstName} {e.LastName} {e.MiddleName}",
                JobTitle = e.JobTitle,
                Salary = Math.Round(e.Salary, 2)}).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in allEmplyees)
            {
                sb.AppendLine($"{item.Name} {item.JobTitle} {item.Salary}");
            }
            return sb.ToString();
        }
        
        
    }
}
