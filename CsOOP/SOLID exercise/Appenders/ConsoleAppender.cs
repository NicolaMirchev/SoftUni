using SOLID_exercise.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_exercise
{
    class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }

        private ILayout Layout;

        ILayout IAppender.Layout => this.Layout;

        public void Append(string dateTime, ReportEnumenator reportLevel, string message)
        {
            Console.WriteLine(string.Format(this.Layout.Template, dateTime, reportLevel, message));        
        }
    }
}
