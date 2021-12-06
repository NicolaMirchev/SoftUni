using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Core
{
   public interface IContoller
    {


        public void AddCar();
        public void AddRacer();
        public void BeginRace();
        public void Exit();
        public void Report();
    }
}
