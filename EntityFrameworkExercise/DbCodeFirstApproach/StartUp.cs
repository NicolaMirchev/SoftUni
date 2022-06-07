using DbCodeFirstApproach.Models;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DbCodeFirstApproach
{
    public class StartUp
    {

         public static async Task<string>  ImportUsers(ProductShopContext context, string[] inputJson) 
        {

            foreach (var item in inputJson)
            {
                User user = JsonSerializer.Deserialize<User>(item);

                Thread.Sleep(200);

                context.Users.Add(user);
                context.SaveChangesAsync();
            }


            return $"Successfully imported {context.Users.Count()}".ToString();
        }

    }
}
