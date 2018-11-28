using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading
{
    class BSTree<T> : binTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public BSTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

    }
}
