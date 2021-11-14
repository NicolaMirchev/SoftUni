using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_exercise
{
    class Logger : ILogger
    {
        public Logger(IAppender appender)
        {
            Appender = appender;
        }
        public IAppender Appender { get; set; }

        public void Error(string dataAndTime, string message)
        {
            Appender.Append(dataAndTime, Appenders.ReportEnumenator.Error, message);
        }
        public void Info(string dataAndTime, string message)
        {
            Appender.Append(dataAndTime, Appenders.ReportEnumenator.Info, message);        
        }
    }
}
