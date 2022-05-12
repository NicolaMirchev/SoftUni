using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructImplementation
{
    public class TreeNode <T> : ITree<T>
    {
        private T valuePrivate;
        private TreeNode(T value, TreeNode<T> parent)
        {
            this.value = value;
            children = new List<TreeNode<T>>();
            this.parent = parent;
        }
        public TreeNode(T value)
        {
            this.value = value;
            children = new List<TreeNode<T>>();
            this.parent = null;
        }
        private TreeNode<T> parent;

        public T value {
            get { return valuePrivate; }
             
            set {
                if (value == null)
                {
                    throw new ArgumentException("Cannot have value null!!");
                }
                else valuePrivate = value;
            } }

        public List<TreeNode<T>> children { get; set; }

        public void AddChild(T value)
        {
            TreeNode<T> node = new TreeNode<T>(value, this);
            this.children.Add(node);
        }

        public void BSF(string spaces)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(spaces + " " + node.value);


                foreach (var element in node.children)
                {
                    queue.Enqueue(element);
                }
                

            }

            

        }

        public void DSF(string spaces)
        {

            Console.WriteLine(spaces + this.value);

            foreach (var child in this.children)
            {
                child.DSF(spaces += "  ");
            }

        }

        public int GetElementsCount()
        {
            throw new NotImplementedException();
        }

        public void GetRoot()
        {
            var parent = this.parent;

            while (parent != null)
            {
                parent = this;                
            }

            Console.WriteLine(parent.value);
        }
    }
}
