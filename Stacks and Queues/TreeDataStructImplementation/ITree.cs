using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructImplementation
{
    interface ITree <T>
    {

        public void DSF(string spaces);
        public void BSF(string spaces);
        public void GetRoot();

        public void AddChild(T value);

        public int GetElementsCount();

    }
}
