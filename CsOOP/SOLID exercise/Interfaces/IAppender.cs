using SOLID_exercise.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_exercise
{
    interface IAppender 
    {
        public ILayout Layout { get; }

        public void Append(string dateTime, ReportEnumenator reportLevel, string message);
    }
}
