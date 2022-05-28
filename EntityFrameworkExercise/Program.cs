// See https://aka.ms/new-console-template for more information

using EntityFrameworkExercise;
using EntityFrameworkExercise.Models;
using Microsoft.EntityFrameworkCore;


var db = new SoftUniContext();


Console.WriteLine(StartUp.GetEmployeesFullInformation(db));






