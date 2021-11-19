
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter cI)
        {
            commandInterpreter = cI;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                string input = Console.ReadLine();

                Console.WriteLine(commandInterpreter.Read(input));


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
