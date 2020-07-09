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

        /* returns true if given search tree is binary
         * search tree (efficient version) */
        public virtual bool IsBinarySearchTree
        {
            get
            {
                return ResolveIsBinarySearchTree(root, int.MinValue, int.MaxValue);
            }
        }

        /* Returns true if the given tree is a BST and its
         * values are >= min and <= max. */
        public virtual bool ResolveIsBinarySearchTree(BinaryTreeNode node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null)
            {
                return true;
            }

            /* false if this node violates the min/max constraints */
            if (node.Key < min || node.Key > max)
            {
                return false;
            }

            /* otherwise check the subtrees recursively
             * tightening the min/max constraints */
            // Allow only distinct values  
            return (ResolveIsBinarySearchTree(node.Left, min, node.Key - 1) && ResolveIsBinarySearchTree(node.Right, node.Key + 1, max));
        }
        
        public int MinDepth(BinaryTreeNode root) {
           if (root == null) 
                return 0; 

            if (root.Left == null && root.Right == null) 
                return 1;

            // If left subtree is NULL, recur for right subtree  
            if (root.Left == null) 
                return MinDepth(root.Right) + 1; 

            // If right subtree is NULL, recur for left subtree  
            if (root.Right == null) 
                return MinDepth(root.Left) + 1;

            return Math.Min(MinDepth(root.Left), MinDepth(root.Right)) + 1; 
        }

        public virtual bool IsBalanced(BinaryTreeNode node) 
        { 
            int lh;
            int rh;

            if (node == null) 
                return true;

            lh = Height(node.Left); 
            rh = Height(node.Right); 

            if (Math.Abs(lh - rh) <= 1 && IsBalanced(node.Left) && IsBalanced(node.Right))
                return true;

            return false; 
        } 

        public virtual int Height(BinaryTreeNode node) 
        { 
            if (node == null)
                return 0;

            return 1 + Math.Max(Height(node.Left), Height(node.Right)); 
        } 

        public BinaryTreeNode BalanceInOrder(BinaryTreeNode[] nodes, int start, int end) 
        {
            if(start > end)
                return null;

            int mid = (start + end) / 2;
            BinaryTreeNode node = nodes[mid];

            node.Left = BalanceInOrder(start, mid-1, nodes);
            node.Right = BalanceInOrder(mid + 1, end, nodes);

            return node;
        }
        
        public BinaryTree()
        {
            root = null;
        }

        readonly BinaryTreeNode root;

    }

}
