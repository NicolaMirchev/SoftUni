using System;

namespace SOLID_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ILayout layout = new SimpleLayout();

            IAppender appender = new ConsoleAppender(layout);

            Logger logger = new Logger(appender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
        }
    }
}
