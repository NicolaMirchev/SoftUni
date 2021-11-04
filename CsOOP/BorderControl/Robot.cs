using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Robot : IMember
    {
        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }
        public string Model { get; private set; }
        public string ID { get; set; }
    }
}
