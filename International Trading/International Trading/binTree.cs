using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading
{
    class binTree<T> where T : IComparable
    {
        protected Node<T> root;

        public binTree()
        {
            root = null;
        }
        public binTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public int Height()
        {
            return height(ref root);
        }

        protected int height(ref Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            int leftHeight = height(ref tree.Left);
            int rightHeight = height(ref tree.Right);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }

        public int nodeCount()
        {
            return nodecount(ref root);
        }

        protected int nodecount(ref Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            int leftNodeCount = nodecount(ref tree.Left);
            int rightNodeCount = nodecount(ref tree.Right);

            if (leftNodeCount == 0 && rightNodeCount == 0)
            {
                return 1;
            }
            else
            {
                return 1 + (leftNodeCount + rightNodeCount);
            }
        }


        public Boolean RemoveItem(T item)
        {
            return removeItem(item, ref root);
        }

        private Boolean removeItem(T item, ref Node<T> tree)
        {
            //Case 1
            if (tree == null)
            {
                Console.WriteLine("Tree empty");
                return false;
            }
            //Find the item
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }
            //Case 2
            else if (tree.Left == null)
            {
                tree = tree.Right;
                return true;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
                return true;
            }
            //Case 3
            else
            {
                T newRoot = leastItem(tree.Right);
                tree.Data = newRoot;
                removeItem(newRoot, ref tree.Right);
                return true;
            }

            return false;
        }
        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null) //Stopping condition
            {
                return tree.Data;
            }
            return leastItem(tree.Left);
        }


    }
}
