using System;

namespace Learning.DataStructures
{
    /// <summary>
    /// 
    /// </summary>
    public class BinaryTree
    {
        public void InOrder()
        {
            InOrder(root);
        }

        public void InOrder(BinaryTreeNode node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.WriteLine($"{ node.Key }");
                InOrder(node.Right);
            }
        }

        public void PostOrder()
        {
            PostOrder(root);
        }

        public void PostOrder(BinaryTreeNode node)
        {
            if (node == null)
                return;

            PostOrder(node.Left);
            PostOrder(node.Right);

            Console.WriteLine($"{node.Key} ");
        }

        public void PreOrder()
        {
            PreOrder(root);
        }

        public void PreOrder(BinaryTreeNode node)
        {
            if (node == null)
                return;

            Console.WriteLine($"{node.Key} ");

            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public BinaryTreeNode Insert(int item, BinaryTreeNode node = null)
        {
            // if tree is empty, return new node
            if (node == null)
                return new BinaryTreeNode { Key = item };

            // otherwise recur down the tree
            if (item < node.Key)
                node.Left = Insert(item, node.Left);
            else if (item > node.Key)
                node.Right = Insert(item, node.Right);

            //return unchanged node
            return node;
        }

        public BinaryTree()
        {
            root = null;
        }

        readonly BinaryTreeNode root;

    }

}
