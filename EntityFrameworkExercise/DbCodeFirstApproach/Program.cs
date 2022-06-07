// See https://aka.ms/new-console-template for more information
using DbCodeFirstApproach;
using DbCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;


var jsonData = File.ReadAllLines("users.json");


using (var db = new ProductShopContext())
{
    Console.WriteLine(await StartUp.ImportUsers(db, jsonData));
}

