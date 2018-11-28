using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading
{
    class AVLTree<T> : binTree<T> where T : IComparable
    {
        public AVLTree()
        {
            root = null;
        }
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
                rotateRight(ref tree.Right);

            Node<T> pivot = tree.Right;

            tree.Right = pivot.Left;
            pivot.Left = tree;
            tree = pivot;
        }
        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
                rotateLeft(ref tree.Left);

            Node<T> pivot = tree.Left;

            tree.Left = pivot.Right;
            pivot.Right = tree;
            tree = pivot;

        }
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            tree.BalanceFactor = height(ref tree.Left) - height(ref tree.Right);
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
        }

        public void returnAll(LinkedList<T> returnList) // selects all nodes
        {
           
            returnall(root, ref returnList);
        }
        
        private void returnall(Node<T> tree, ref LinkedList<T> returnList)
        {
            if (tree != null)
            {
                returnall(tree.Left, ref returnList);
                returnList.AddLast(tree.Data);
                returnall(tree.Right, ref returnList);
            }


        }

        public Node<T> selectNode(string selectedNode) {
            return SelectedNode(new Country(selectedNode, 0, 0, 0, 0, new string[0]), root);
        }

        private Node<T> SelectedNode(Country findSelectedNode, Node<T> tree) {
            if (tree == null)
                return tree;
            else if (tree.Data.CompareTo(findSelectedNode) == 0)
                return tree;
            Node<T> selected = null;
            if (SelectedNode(findSelectedNode, tree.Left) != null)
                return SelectedNode(findSelectedNode, tree.Left);
            else if (SelectedNode(findSelectedNode, tree.Right) != null)
                return SelectedNode(findSelectedNode, tree.Right);
            return selected;
        }




    }
}
