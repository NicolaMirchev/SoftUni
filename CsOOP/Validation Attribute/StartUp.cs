﻿using System;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person(null, -1 );

            object newObject = person;

            Console.WriteLine(newObject);
         //   bool isValidEntity = Validator.IsValid(person);

          //  Console.WriteLine(isValidEntity);
        }
    }
}