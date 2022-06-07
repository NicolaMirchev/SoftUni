// See https://aka.ms/new-console-template for more information

using EntityFrameworkExercise;
using EntityFrameworkExercise.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

using (var db = new SoftUniContext())
{
    var employeesInSales = db.Employees
        .Where(s => s.Department.Name == "Sales" && s.Salary > 15000)
        .Select(e => new
        { 
             Name = e.FirstName + " " + e.LastName,
             Department  = e.Department,
             Salary = e.Salary,
             JobTitle = e.JobTitle,                
        })
        .ToArray();

    List<string> jsonStrings = new List<string>();
    foreach (var employee in employeesInSales)
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        string serializedObj = JsonSerializer.Serialize(employee,options);
        jsonStrings.Add(serializedObj);
        Console.WriteLine(serializedObj);
    }

        File.AppendAllLines("employees.json", jsonStrings);

}





//Department dep = new Department();
//dep.Name = "12345678910123456789101234567891012345678910123456789101234567891012345678910";

//dep.Manager = db.Employees.FindAsync(1).Result.Manager;


//await db.Departments.AddAsync(dep);

//await db.SaveChangesAsync();

//Console.WriteLine(db.Employees.FindAsync(2).Result.Salary);



