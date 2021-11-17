using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPerson = new Student();
            var type = newPerson.GetType().BaseType;

            Type objectType = new object().GetType();
            while (type.FullName != objectType.FullName)
            {
                Console.WriteLine(type.FullName);
                type = type.BaseType;
            }
        }
    }
}
