using System;

namespace TreeDataStructImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            var node = new TreeNode<int>(10);
            node.AddChild(45);
            node.AddChild(55);


            node.children[0].AddChild(1);
            node.children[0].AddChild(2);
            node.children[1].AddChild(66);
            node.children[1].AddChild(70);

            node.BSF("");




        }
    }
}
